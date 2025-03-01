using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCaptureDotNet
{
    internal class ImageSaver
    {
        List<(Bitmap, string)> _images;
        DirectoryInfo _dir;
        public ImageSaver()
        {
            _images = new List<(Bitmap, string)>();
            _dir = Directory.CreateDirectory($"Image-At{DateTime.Now:MM-dd_HH-mm-ss}"); 
        }

        public void AddImage( Bitmap image, string description)
        {
            _images.Add( (image, description) );
        }
        
        public void Save(string extraDesciption="")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( extraDesciption+"\n" );
            for (int i = 0; i < _images.Count; i++)
            {
                _images[i].Item1.Save(Path.Combine(_dir.FullName, $"{i + 1}.bmp"));
                sb.AppendLine($"{i+1}, {_images[i].Item2.ToString()}\n");
            }
            File.WriteAllText(Path.Combine(_dir.FullName, "CaptureInfo.txt"), sb.ToString());
            Console.WriteLine( sb.ToString() );
        }
    }
}
