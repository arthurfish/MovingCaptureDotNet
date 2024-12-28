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
            var camera = new Camera(pictureBox2);
            camera.startGrabing();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
