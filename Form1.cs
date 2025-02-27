﻿using System;
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
            this.Width = 800;
            this.Height = 700;
            positioningPlatform = new PositioningPlatform();
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
            commandListBox.Items.Add(new CartesianCoordinateDirectionalMotion((double)deltaXInput.Value, (double)deltaYInput.Value));
        }

        private void addPolarCoordButton_Click(object sender, EventArgs e)
        {
            commandListBox.Items.Add(new PolarCoordinateDirectionalMotion((double)thetaInput.Value, (double)deltaRInput.Value));
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
    }
}
