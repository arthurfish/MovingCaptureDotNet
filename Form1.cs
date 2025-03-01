using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;



namespace MovingCaptureDotNet
{
    public partial class Form1 : Form
    {
        const int GRABBING_INTERVAL_MILLISECOND = 200;
        const int CAPTURE_DELAY_MILLISECOND = 1000;

        public Form1()
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 700;
            positioningPlatform = new PositioningPlatform();
            heightAdjustDevice = new HeightAdjustDevice();
            heightAdjustDevice.Position = 0;
            camera = new Camera(pictureBox2);
            camera.startGrabing();
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.FormClosed += async (sender, e) =>
            {
                Console.WriteLine("Will release the camera.");
                camera.disposeCamera();
            };
            timer = new System.Timers.Timer(GRABBING_INTERVAL_MILLISECOND);
            timer.Elapsed += (s, e) => onTimerTick();
            timer.AutoReset = true;
            timer.Enabled = true;
            exposureTimeInput.DataBindings.Add("Value", camera, nameof(camera.exposureTime), true, DataSourceUpdateMode.OnPropertyChanged);
            moveSpeedInput.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.velocity), true, DataSourceUpdateMode.OnPropertyChanged);
            stepSizeInput.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.stepSize), true, DataSourceUpdateMode.OnPropertyChanged);
            startX0Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.startX0), true, DataSourceUpdateMode.OnPropertyChanged);
            startY0Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.startY0), true, DataSourceUpdateMode.OnPropertyChanged);
            endX1Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.endX1), true, DataSourceUpdateMode.OnPropertyChanged);
            endY1Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.endY1), true, DataSourceUpdateMode.OnPropertyChanged);
            captureNumberInput.DataBindings.Add("Value", camera, nameof(camera.captureNumber), true, DataSourceUpdateMode.OnPropertyChanged);

            commandListBox.DisplayMember = "Description";
            commandListBox.ValueMember = "Id";
            startX0InputCopy.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.startX0), true, DataSourceUpdateMode.OnPropertyChanged);
            startY0InputCopy.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.startY0), true, DataSourceUpdateMode.OnPropertyChanged);

            heightStepSize.DataBindings.Add("Value", heightAdjustDevice, nameof(heightAdjustDevice.StepSize), true, DataSourceUpdateMode.OnPropertyChanged);
            currentHeight.DataBindings.Add("Value", heightAdjustDevice, nameof(heightAdjustDevice.Position), true, DataSourceUpdateMode.OnPropertyChanged);
            button5.Enabled = (commandListBox.Items.Count >= 1);

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
            var dev = positioningPlatform;
            var d = directions[cmd];
            var s = dev.stepSize;
            dev.incrementMove(d.x * s, d.y * s);
        }

        private System.Timers.Timer timer;
        
        private void onTimerTick()
        {
            var _ = positioningPlatform.position;
            positionXLable.Invoke(new Action(() =>
            {
                positionXLable.Text = $"{positioningPlatform.position.x:F2}";
            }));
            positionYLable.Invoke(new Action(() =>
            {
                positionYLable.Text = $"{positioningPlatform.position.y:F2}";
            }));
            var image = camera.getImage();
            if (image != null)
            {
                pictureBox2.Invoke(new Action(() =>
                {
                    pictureBox2.Image = image;
                }));
            }

        }

        private void moveUpButtion_Click(object sender, EventArgs e)
        {
            moveHelper("up");
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            moveHelper("down");
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            moveHelper("left");
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            moveHelper("right");
        }

        private void returnToZeroButton_Click(object sender, EventArgs e)
        {
            positioningPlatform.position = (0, 0);
        }

        private void moveSpeedInput_ValueChanged(object sender, EventArgs e)
        {
        }

        private void moveToStartPosition_Click(object sender, EventArgs e)
        {
            var dev = positioningPlatform;
            dev.position = (dev.startX0, dev.startY0);
        }

        private void moveToEndPosition_Click(object sender, EventArgs e)
        {
            var dev = positioningPlatform;
            dev.position = (dev.endX1, dev.endY1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exposureTimeInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void moveToStartPosition_Click_1(object sender, EventArgs e)
        {
            positioningPlatform.position = (positioningPlatform.startX0, positioningPlatform.startY0);
        }

        private void positionXLable_Click(object sender, EventArgs e)
        {

        }

        private void moveToEndPosition_Click_1(object sender, EventArgs e)
        {
            positioningPlatform.position = (positioningPlatform.endX1, positioningPlatform.endY1);
        }

        private void caputureStartButton_Click(object sender, EventArgs e)
        {

            var (startX0, startY0, endX1, endY1) = (positioningPlatform.startX0, positioningPlatform.startY0, positioningPlatform.endX1, positioningPlatform.endY1);
            var captureNumber = camera.captureNumber;
            float deltaX = (endX1 - startX0) / (float)captureNumber;
            float deltaY = (endY1 - startY0) / (float)captureNumber;
            positioningPlatform.position = (startX0, startY0);
            var dir = Directory.CreateDirectory($"Image-Captured-At{DateTime.Now.ToString("MM-dd-HH-mm-ss")}");
            var captureInfo = $"({startX0}, {startY0}) -> ({endX1}, {endY1}), number: {captureNumber}, deltaX: {deltaX}, deltaY: {deltaY}\n";
            Console.WriteLine( captureInfo );
            File.WriteAllText(Path.Combine(dir.FullName, "CaptureInfo.txt"), captureInfo);
            Console.WriteLine("Capture Start.");
            for(int i = 0; i < camera.captureNumber; i++)
            {
                captureProgressBar.Value = (i+1) * 100 / captureNumber;
                positioningPlatform.position = (startX0 + i * deltaX, startY0 + i * deltaY);
                var image = camera.getImage();
                pictureBox2.Invoke(new Action(() => {
                    pictureBox2.Image = image;
                }));
                image.Save(Path.Combine(dir.FullName, $"{i+1}.bmp"));
                System.Threading.Thread.Sleep(CAPTURE_DELAY_MILLISECOND);
                Console.WriteLine($"Capturing image: [{i+1}/{captureNumber}] ");
            }
        }

        private void addRectCoordButton_Click(object sender, EventArgs e)
        {
            commandListBox.Items.Add(new CartesianCoordinateDirectionalMotion((double)deltaXInput.Value, (double)deltaYInput.Value, (double)deltaZInputRect.Value, (int)rectCoordStepsInput.Value));
            button5.Enabled = (commandListBox.Items.Count >= 1);
        }

        private void addPolarCoordButton_Click(object sender, EventArgs e)
        {
            commandListBox.Items.Add(new PolarCoordinateDirectionalMotion((double)thetaInput.Value, (double)deltaRInput.Value, (double)deltaZInputPolar.Value, (int)polarCoordStepsInput.Value));
            button5.Enabled = (commandListBox.Items.Count >= 1);
        }

        private void motionRemoveButton_Click(object sender, EventArgs e)
        {
            if(commandListBox.SelectedItem != null)
            {
                commandListBox.Items.Remove(commandListBox.SelectedItem);
            }
            else
            {
                commandListBox.Items.RemoveAt(commandListBox.Items.Count - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            var saver = new ImageSaver();
            var task = Task.Run(() =>
            {
                MotionUtils.applyMotions(
                    commandListBox.Items.Cast<IMotion>(),
                    motion => { 
                        positioningPlatform.incrementMove((float)motion.DeltaX, (float)motion.DeltaY);
                        heightAdjustDevice.IncrementMove((float)motion.DeltaZ);
                    },
                    positioningPlatform.isMoving,
                    p => commandApplyProgressBar.Invoke(new Action(() => {
                        commandApplyProgressBar.Value = (int)(100 * p);
                    })),
                    () =>
                    {
                        var image = camera.getImage();
                        commandApplyProgressBar.Invoke(new Action(() =>
                        {
                            pictureBox2.Image = image;
                        }));
                        var pos = positioningPlatform.position;
                        saver.AddImage(image, $"{pos.x}, {pos.y}, {heightAdjustDevice.Position}");
                    }
                );
                saver.Save();
                button5.Invoke(new Action(() =>
                {
                    button5.Enabled = true;
                }));
            });
                
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HeightUpButton_Click(object sender, EventArgs e)
        {
            heightAdjustDevice.Position += heightAdjustDevice.StepSize;
        }

        private void HeightZeroButton_Click(object sender, EventArgs e)
        {
            heightAdjustDevice.Position = 0;
        }

        private void HeightDownButton_Click(object sender, EventArgs e)
        {
            heightAdjustDevice.Position -= heightAdjustDevice.StepSize;
        }

        private void returnToZeroButton_Click_1(object sender, EventArgs e)
        {
            positioningPlatform.position = (0, 0);
        }
    }
}
