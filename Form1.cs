using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCaptureDotNet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            positioningPlatform = new PositioningPlatform();
            var camera = new Camera(pictureBox2);
            camera.startGrabing();
            moveSpeedInput.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.velocity), true, DataSourceUpdateMode.OnPropertyChanged);
            stepSizeInput.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.stepSize), true, DataSourceUpdateMode.OnPropertyChanged);
            startX0Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.startX0), true, DataSourceUpdateMode.OnPropertyChanged);
            startY0Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.startY0), true, DataSourceUpdateMode.OnPropertyChanged);
            endX1Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.endX1), true, DataSourceUpdateMode.OnPropertyChanged);
            endY1Input.DataBindings.Add("Value", positioningPlatform, nameof(positioningPlatform.endY1), true, DataSourceUpdateMode.OnPropertyChanged);
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
    }
}
