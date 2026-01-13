using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace MovingCaptureDotNet.Services
{
    public class ImageSaver
    {
        private List<(Bitmap image, string info)> _images = new List<(Bitmap, string)>();
        const string BaseDir = "Image-Captured-Rect-Polar-";

        public void AddImage(Bitmap image, string info)
        {
            // Clone to avoid disposal issues if the source is reused/disposed elsewhere?
            // For now, assuming ownership transfer or safe usage.
            // Better to clone if we are formatting a list to save later.
            _images.Add((new Bitmap(image), info));
        }

        public void Save()
        {
            if (_images.Count == 0) return;

            var dirName = BaseDir + DateTime.Now.ToString("MM-dd-HH-mm-ss");
            var dir = Directory.CreateDirectory(dirName);
            
            using (var writer = new StreamWriter(Path.Combine(dir.FullName, "CaptureInfo.txt")))
            {
                for (int i = 0; i < _images.Count; i++)
                {
                    var (img, info) = _images[i];
                    img.Save(Path.Combine(dir.FullName, $"{i + 1}.bmp"));
                    writer.WriteLine($"[{i + 1}] {info}");
                    img.Dispose();
                }
            }
            _images.Clear();
        }
    }
}
