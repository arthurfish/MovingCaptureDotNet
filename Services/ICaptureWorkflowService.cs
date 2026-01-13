using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovingCaptureDotNet.Domain.Models;

namespace MovingCaptureDotNet.Services
{
    public interface ICaptureWorkflowService
    {
        Task ExecuteCaptureSequenceAsync(
            float startX, float startY, float endX, float endY, float startZ,
            int captureNumber,
            IProgress<int> progress,
            Action<System.Drawing.Image> onImageCaptured,
            string outputDirectory);

        Task ApplyMotionsAsync(
            IEnumerable<IMotion> motions,
            float startZ,
            IProgress<int> progress,
            Action<System.Drawing.Image> onImageCaptured,
            string outputDirectory);
    }
}
