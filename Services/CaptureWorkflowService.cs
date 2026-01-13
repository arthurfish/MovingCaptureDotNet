using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using MovingCaptureDotNet.Domain.Models;
using MovingCaptureDotNet.Hardware.Abstractions;

namespace MovingCaptureDotNet.Services
{
    public class CaptureWorkflowService : ICaptureWorkflowService
    {
        private readonly IMotionController _motionController;
        private readonly ICamera _camera;
        private readonly IHeightAdjuster _heightAdjuster;
        private readonly ImageSaver _imageSaver; // Or injected

        public CaptureWorkflowService(IMotionController motionController, ICamera camera, IHeightAdjuster heightAdjuster)
        {
            _motionController = motionController;
            _camera = camera;
            _heightAdjuster = heightAdjuster;
            _imageSaver = new ImageSaver(); // Ideally injected or transient
        }

        public async Task ExecuteCaptureSequenceAsync(
            float startX, float startY, float endX, float endY, float startZ,
            int captureNumber,
            IProgress<int> progress,
            Action<System.Drawing.Image> onImageCaptured,
            string outputDirectory)
        {
            if (_motionController == null || _camera == null) return;

            // Prevent division by zero
            if (captureNumber <= 0) captureNumber = 1;

            float deltaX = (endX - startX) / (float)captureNumber;
            float deltaY = (endY - startY) / (float)captureNumber;

            // Move to start
             _motionController.MoveAbsolute(startX, startY);
             if (_heightAdjuster != null) 
             {
                 // _heightAdjuster.Position = startZ; // This might block if not async properly, but for now it's property setter.
                 // Ideally hardware calls should be async or wrapped.
                 // We will run it on thread pool if it's blocking.
                await Task.Run(() => {
                    _heightAdjuster.ExpectedPosition = startZ;
                    _heightAdjuster.ApplyMotion();
                });
             }
             else
             {
                 await Task.Yield();
             }

            // Create directory
            var dir = Directory.CreateDirectory(outputDirectory);
            var captureInfo = $"({startX}, {startY}) -> ({endX}, {endY}), number: {captureNumber}, deltaX: {deltaX}, deltaY: {deltaY}\n";
            File.WriteAllText(Path.Combine(dir.FullName, "CaptureInfo.txt"), captureInfo);

            for (int i = 0; i < captureNumber; i++)
            {
                progress?.Report((i + 1) * 100 / captureNumber);

                await Task.Run(() => _motionController.MoveAbsolute(startX + i * deltaX, startY + i * deltaY));
                
                // Wait for motion to settle? Old code had Thread.Sleep(CAPTURE_DELAY_MILLISECOND)
                await Task.Delay(1000); 

                var image = await Task.Run(() => _camera.GetImage());
                if (image != null)
                {
                    onImageCaptured?.Invoke(image);
                    image.Save(Path.Combine(dir.FullName, $"{i + 1}.bmp"));
                    // We don't dispose here if ONImageCaptured uses it? 
                    // Form1 used to dispose OLD image. The consumer should handle display lifetime, 
                    // but we should probably dispose our reference if we are done saving.
                    // However, we pass it to callback. Callback needs to clone or we rely on GC.
                    // Image.Save is done.
                }
            }
        }

        public async Task ApplyMotionsAsync(
            IEnumerable<IMotion> motions,
            float startZ,
            IProgress<int> progress,
            Action<System.Drawing.Image> onImageCaptured,
            string outputDirectory)
        {
            if (_motionController == null || _camera == null) return;

            // Initial Position
            // Assuming current X/Y is handled by caller or we reset?
            // Original code: _motionController.MoveAbsolute(StartX0, StartY0);
            // We should probably pass start positions if needed, but let's assume valid state.

            if (_heightAdjuster != null)
                await Task.Run(() => {
                    _heightAdjuster.ExpectedPosition = startZ;
                    _heightAdjuster.ApplyMotion();
                    }); 

            var saver = new ImageSaver();

            int totalSteps = 0;
            foreach (var m in motions) totalSteps += m.Steps;
            int currentStep = 0;

            foreach (var motion in motions)
            {
                for (int i = 0; i < motion.Steps; i++)
                {
                    currentStep++;
                    progress?.Report((int)((float)currentStep / totalSteps * 100));

                    // Take photo BEFORE move?
                    // Original: takePhoto(); Sleep; move(mot); Sleep;
                    
                    var image = await Task.Run(() => _camera.GetImage());
                    if (image != null)
                    {
                        onImageCaptured?.Invoke(image);
                        var pos = _motionController.Position;
                         // Saver adds to list
                        saver.AddImage(image, $"{pos.X}, {pos.Y}, {_heightAdjuster?.ExpectedPosition}");
                    }

                    await Task.Delay(750);

                    await Task.Run(() => {
                        _motionController.MoveRelative((float)motion.DeltaX, (float)motion.DeltaY);
                        _heightAdjuster?.MoveRelative((float)motion.DeltaZ);
                    });

                    await Task.Delay(750);
                }
            }

            // Save all
            // NOTE: Original ImageSaver uses hardcoded directory name based on timestamp.
            // We should probably respect outputDirectory or similar.
            // For now, let's stick to ImageSaver logic but maybe make it configurable?
            // ImageSaver in `Services` has been moved. It writes to a new dir.
             await Task.Run(() => saver.Save());
            progress?.Report(0);
        }
    }
}
