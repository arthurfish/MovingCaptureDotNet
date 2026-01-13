using System;
using System.Diagnostics;
using System.Windows.Forms;
using MovingCaptureDotNet.Hardware.Implementations;
using MovingCaptureDotNet.Services;

namespace MovingCaptureDotNet
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Composition Root
            var motion = new ZMotionController();
            try { motion.Connect("192.168.0.11"); } 
            catch { Trace.WriteLine("[PLATFORM] Can not connect.");/* Log or Ignore */ }

            var height = new SerialHeightAdjuster();
            try { if (!height.Connect()) Trace.WriteLine("Height Connect Fail"); }
            catch { }

            var camera = new HikVisionCamera();
            try { 
                camera.Initialize();
            }
            catch {
                Trace.WriteLine("[CAMERA] Can not connect.");
            }

            var service = new CaptureWorkflowService(motion, camera, height);

            var form = new Form1(motion, camera, height, service);

            Application.Run(form);
        }
    }
}
