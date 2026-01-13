using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MovingCaptureDotNet.Domain.Models;
using MovingCaptureDotNet.Hardware.Abstractions;
using MovingCaptureDotNet.Hardware.Implementations;
using MovingCaptureDotNet.Services;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MovingCaptureDotNet
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        const int GRABBING_INTERVAL_MILLISECOND = 100; // Updated for smoother UI

        private readonly IMotionController _motionController;
        private readonly IHeightAdjuster _heightAdjuster;
        private readonly ICamera _camera;
        private readonly ICaptureWorkflowService _captureService;

        private System.Timers.Timer _timer;

        // View Model Properties
        private float _motionStepSize = 5;
        public float MotionStepSize
        {
            get => _motionStepSize;
            set { _motionStepSize = value; OnPropertyChanged(nameof(MotionStepSize)); }
        }

        private float _startX0;
        public float StartX0
        {
            get => _startX0;
            set { _startX0 = value; OnPropertyChanged(nameof(StartX0)); }
        }

        private float _startY0;
        public float StartY0
        {
            get => _startY0;
            set { _startY0 = value; OnPropertyChanged(nameof(StartY0)); }
        }

        private float _endX1;
        public float EndX1
        {
            get => _endX1;
            set { _endX1 = value; OnPropertyChanged(nameof(EndX1)); }
        }

        private float _endY1;
        public float EndY1
        {
            get => _endY1;
            set { _endY1 = value; OnPropertyChanged(nameof(EndY1)); }
        }
        
        private bool _isCapturing = false;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Default constructor for Designer support (if needed) - but we use DI mostly
        // Ideally we shouldn't have this if we enforce DI, but WinForms designer sometimes needs it.
        // We will make the DI constructor the main one.
        public Form1(IMotionController motionController, ICamera camera, IHeightAdjuster heightAdjuster, ICaptureWorkflowService captureService)
        {
            InitializeComponent();
            _motionController = motionController;
            _camera = camera;
            _heightAdjuster = heightAdjuster;
            _captureService = captureService;

            this.Width = 1500;
            this.Height = 800;

            InitializeBindings();
            InitializeHardwareAsync(); // Fire and forget specific init if needed, or caller handled it.
            
            // Timer for Live View
            _timer = new System.Timers.Timer(GRABBING_INTERVAL_MILLISECOND);
            _timer.Elapsed += (s, e) => onTimerTick();
            _timer.AutoReset = true;
            _timer.Enabled = true;

            this.FormClosed += Form1_FormClosed;
        }

        // Fallback for designer?
        public Form1() { InitializeComponent(); } 

        private void InitializeBindings()
        {
            if (_camera != null)
            {
                exposureTimeInput.DataBindings.Add("Value", _camera, nameof(_camera.ExposureTime), true, DataSourceUpdateMode.OnPropertyChanged);
                captureNumberInput.DataBindings.Add("Value", _camera, nameof(_camera.CaptureNumber), true, DataSourceUpdateMode.OnPropertyChanged);
            }

            if (_motionController != null)
            {
                moveSpeedInput.DataBindings.Add("Value", _motionController, nameof(_motionController.Velocity), true, DataSourceUpdateMode.OnPropertyChanged);
            }

            // Local bindings
            stepSizeInput.DataBindings.Add("Value", this, nameof(MotionStepSize), true, DataSourceUpdateMode.OnPropertyChanged);
            
            startX0Input.DataBindings.Add("Value", this, nameof(StartX0), true, DataSourceUpdateMode.OnPropertyChanged);
            startY0Input.DataBindings.Add("Value", this, nameof(StartY0), true, DataSourceUpdateMode.OnPropertyChanged);
            
            endX1Input.DataBindings.Add("Value", this, nameof(EndX1), true, DataSourceUpdateMode.OnPropertyChanged);
            endY1Input.DataBindings.Add("Value", this, nameof(EndY1), true, DataSourceUpdateMode.OnPropertyChanged);

            startX0InputCopy.DataBindings.Add("Value", this, nameof(StartX0), true, DataSourceUpdateMode.OnPropertyChanged);
            startY0InputCopy.DataBindings.Add("Value", this, nameof(StartY0), true, DataSourceUpdateMode.OnPropertyChanged);

            if (_heightAdjuster != null)
            {
                heightStepSize.DataBindings.Add("Value", _heightAdjuster, nameof(_heightAdjuster.StepSize), true, DataSourceUpdateMode.OnPropertyChanged);
                currentHeight.DataBindings.Add("Value", _heightAdjuster, nameof(_heightAdjuster.ExpectedPosition), true, DataSourceUpdateMode.OnPropertyChanged);
            }

            commandListBox.DisplayMember = "Description";
            commandListBox.ValueMember = "Id";
            button5.Enabled = true; 
        }

        private async void InitializeHardwareAsync()
        {
            // Hardware init is mostly done in Program.cs, but we can do extra setup here.
            // Example: Start Grabbing
            if (_camera != null)
            {
                try 
                {
                    _camera.StartGrabbing(); 
                }
                catch(Exception ex) 
                {
                    MessageBox.Show($"Camera Start Failed: {ex.Message}");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Releasing hardware...");
            _camera?.Dispose();

            _timer.Stop();
            
            // _motionController doesn't implement IDisposable but maybe should? 
            // original code didn't dispose it.
            
            // _heightAdjuster needed disconnect?
            (_heightAdjuster as SerialHeightAdjuster)?.Disconnect();
        }

        private Dictionary<String, (int x, int y)> directions = new Dictionary<string, (int, int)>
        {
            {"up", (0, +1) },
            {"down", (0, -1)},
            {"left", (-1, 0)},
            {"right", (+1, 0)},
        };

        private void moveHelper(String cmd)
        {
            if (_motionController == null) return;
            if (directions.ContainsKey(cmd))
            {
                var d = directions[cmd];
                _motionController.MoveRelative(d.x * MotionStepSize, d.y * MotionStepSize);
            }
        }

        private System.Timers.Timer timer;

        private void onTimerTick()
        {
            if (_isCapturing) return;

            // Update UI on main thread
            if (_motionController != null)
            {
                // Reading properties might be fast, but updating UI must be invoked
                var pos = _motionController.Position;
                try
                {
                    BeginInvoke(new Action(() =>
                    {
                        positionXLable.Text = $"{pos.X:F2}";
                        positionYLable.Text = $"{pos.Y:F2}";
                    }));
                }
                catch { } // Ignore if form closing
            }

            if (_camera != null)
            {
                // GetImage might block or throw if busy
                try
                {
                    var image = _camera.GetImage();
                    if (image != null)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            var old = pictureBox2.Image;
                            pictureBox2.Image = image;
                            if (old != null) old.Dispose();
                        }));
                    }
                }
                catch { }
            }

        }

        private void moveUpButtion_Click(object sender, EventArgs e) => moveHelper("up");
        private void moveDownButton_Click(object sender, EventArgs e) => moveHelper("down");
        private void moveLeftButton_Click(object sender, EventArgs e) => moveHelper("left");
        private void moveRightButton_Click(object sender, EventArgs e) => moveHelper("right");

        private void returnToZeroButton_Click(object sender, EventArgs e) => _motionController?.MoveAbsolute(0, 0);

        private void moveToStartPosition_Click(object sender, EventArgs e)
        {
            _motionController?.MoveAbsolute(StartX0, StartY0);
            if (_heightAdjuster != null)
            {
                _heightAdjuster.ExpectedPosition = (float)startZ0Input.Value;
                _heightAdjuster.ApplyMotion();
            }

        }

        private void moveToEndPosition_Click(object sender, EventArgs e) => _motionController?.MoveAbsolute(EndX1, EndY1);

        // Duplicate handlers from original code naming - merged logic
        private void moveToEndPosition_Click_1(object sender, EventArgs e) => moveToEndPosition_Click(sender, e);
        private void moveToStartPosition_Click_1(object sender, EventArgs e) => moveToStartPosition_Click(sender, e);
        private void returnToZeroButton_Click_1(object sender, EventArgs e) => returnToZeroButton_Click(sender, e);
        
        // Empty handlers to satisfy designer if they exist
        private void moveSpeedInput_ValueChanged(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void exposureTimeInput_ValueChanged(object sender, EventArgs e) { }
        private void positionXLable_Click(object sender, EventArgs e) { }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void currentHeight_ValueChanged(object sender, EventArgs e) { }

        private async void caputureStartButton_Click(object sender, EventArgs e)
        {
            if (_captureService == null) return;
            
            try
            {
                _isCapturing = true;
                caputureStartButton.Enabled = false;
                
                string dirName = $"Image-Captured-At{DateTime.Now:MM-dd-HH-mm-ss}";
                
                await _captureService.ExecuteCaptureSequenceAsync(
                    StartX0, StartY0, EndX1, EndY1, (float)startZ0Input.Value,
                    _camera.CaptureNumber,
                    new Progress<int>(p => captureProgressBar.Value = p),
                    img => {
                         // Update PictureBox with captured image copy
                         // Need to invoke? This Action runs on context of service? 
                         // Service uses Task.Run so likely background.
                         BeginInvoke(new Action(() => {
                             var old = pictureBox2.Image;
                             pictureBox2.Image = new Bitmap(img); // Clone to display
                             if(old != null) old.Dispose();
                         }));
                    },
                    dirName
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Capture Error: {ex.Message}");
            }
            finally
            {
                _isCapturing = false;
                caputureStartButton.Enabled = true;
            }
        }

        private void addRectCoordButton_Click(object sender, EventArgs e)
        {
            commandListBox.Items.Add(new CartesianCoordinateDirectionalMotion((double)deltaXInput.Value, (double)deltaYInput.Value, (double)deltaZInputRect.Value, (int)rectCoordStepsInput.Value));
            button5.Enabled = true;
        }

        private void addPolarCoordButton_Click(object sender, EventArgs e)
        {
            commandListBox.Items.Add(new PolarCoordinateDirectionalMotion((double)thetaInput.Value, (double)deltaRInput.Value, (double)deltaZInputPolar.Value, (int)polarCoordStepsInput.Value));
            button5.Enabled = true;
        }

        private void motionRemoveButton_Click(object sender, EventArgs e)
        {
            if(commandListBox.SelectedItem != null)
                commandListBox.Items.Remove(commandListBox.SelectedItem);
            else if (commandListBox.Items.Count > 0)
                commandListBox.Items.RemoveAt(commandListBox.Items.Count - 1);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (_captureService == null) return;
            var motions = commandListBox.Items.Cast<IMotion>().ToList();
            if (motions.Count == 0) return;

            try
            {
                _isCapturing = true;
                button5.Enabled = false;
                
                await _captureService.ApplyMotionsAsync(
                    motions,
                    (float)startZ0Input.Value,
                    new Progress<int>(p => commandApplyProgressBar.Value = p),
                    img => {
                         BeginInvoke(new Action(() => {
                             var old = pictureBox2.Image;
                             pictureBox2.Image = new Bitmap(img);
                             if(old != null) old.Dispose();
                         }));
                    },
                    "" // Uses internal ImageSaver logic for now
                );
            }
            catch(Exception ex)
            {
                 MessageBox.Show($"Motion Sequence Error: {ex.Message}");
            }
            finally
            {
                _isCapturing = false;
                button5.Enabled = true;
            }
        }

        private void HeightUpButton_Click(object sender, EventArgs e) { _heightAdjuster?.MoveRelative(_heightAdjuster.StepSize); startZ0Input.Value = (decimal)_heightAdjuster.ExpectedPosition; }
        private void HeightDownButton_Click(object sender, EventArgs e) { _heightAdjuster?.MoveRelative(-_heightAdjuster.StepSize); startZ0Input.Value = (decimal)_heightAdjuster.ExpectedPosition; }
        private void HeightZeroButton_Click(object sender, EventArgs e)
        {
            if (_heightAdjuster != null) {
                _heightAdjuster.ExpectedPosition = 0;
                startZ0Input.Value = 0;
                _heightAdjuster.ApplyMotion();
            }
        }

    }
}
