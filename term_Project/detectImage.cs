using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoloDotNet.Enums;
using YoloDotNet.Models;
using YoloDotNet;
using SkiaSharp;
using System.Security.Cryptography.X509Certificates;

namespace term_Project
{
    internal class detectImage
    {
        private static List<Image> images = new List<Image>();
        private static List<string> objectNames = new List<string>();
        private static List<string> objectConf = new List<string>();
        public static async Task detecting(string filePath, PictureBox pictureBox)
        {
            using var yolo = new Yolo(new YoloOptions
            {
                OnnxModel = @"D:\Source\C#winform\term_Project\term_Project\yolo11n.onnx",
                ModelType = ModelType.ObjectDetection,
                Cuda = false,
                GpuId = 0,
                PrimeGpu = false
            });

            using var image = SKImage.FromEncodedData(filePath);
            var results = yolo.RunObjectDetection(image, confidence: 0.25, iou: 0.7);
            // detect
            using (var surface = SKSurface.Create(new SKImageInfo(image.Width, image.Height)))
            {
                var canvas = surface.Canvas;
                canvas.DrawImage(image, 0, 0);

                foreach (var result in results)
                {
                    var rect = new SKRect(result.BoundingBox.Left, result.BoundingBox.Top, result.BoundingBox.Right, result.BoundingBox.Bottom);
                    var paint = new SKPaint { Color = SKColors.Blue, Style = SKPaintStyle.Stroke, StrokeWidth = 3 };
                    canvas.DrawRect(rect, paint);

                    string label = $"{result.Label.Name} {result.Confidence.ToString("P2")}";
                    var textPaint = new SKPaint { Color = SKColors.Blue, TextSize = 24, IsAntialias = true };

                    canvas.DrawText(label, result.BoundingBox.Left+5, result.BoundingBox.Top +20, textPaint);
                    objectNames.Add(result.Label.Name);
                    objectConf.Add(result.Confidence.ToString("F2"));

                }

                using var outputImage = surface.Snapshot();
                using var data = outputImage.Encode(SKEncodedImageFormat.Png, 100);
                using var ms = new MemoryStream(data.ToArray());
                var detectedImage = Image.FromStream(ms);
                images.Add(detectedImage);

            }
            // crop
            foreach (var result in results)
            {
                var bbox = result.BoundingBox;

                const float scaleFactor = 2.0f; // Nhân đôi độ phân giải ảnh
                var croppedInfo = new SKImageInfo(
                    (int)((bbox.Right - bbox.Left) * scaleFactor),
                    (int)((bbox.Bottom - bbox.Top) * scaleFactor)
                );

                using (var surfaceCrop = SKSurface.Create(croppedInfo))
                {
                    var canvasCrop = surfaceCrop.Canvas;

                    canvasCrop.SetMatrix(SKMatrix.CreateScale(scaleFactor, scaleFactor));
                    canvasCrop.DrawImage(
                        image,
                        new SKRect(bbox.Left, bbox.Top, bbox.Right, bbox.Bottom),
                        new SKRect(0, 0, croppedInfo.Width / scaleFactor, croppedInfo.Height / scaleFactor),
                        new SKPaint { FilterQuality = SKFilterQuality.High }
                    );

                    using var outputImageCrop = surfaceCrop.Snapshot();
                    using var dataCrop = outputImageCrop.Encode(SKEncodedImageFormat.Png, 500); // Chất lượng cao hơn
                    using var msCrop = new MemoryStream(dataCrop.ToArray());
                    var croppedImage = Image.FromStream(msCrop);

                    images.Add(croppedImage);
                }
            }

            //show
            foreach (var dImage in images)
            {

                if (pictureBox.InvokeRequired)
                {
                    pictureBox.Invoke(new Action(() =>
                    {
                        if (pictureBox.Image != null)
                        {
                            pictureBox.Image.Dispose();
                        }
                        pictureBox.Image = (Image)dImage.Clone();
                    }));
                }
                else
                {
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }
                    pictureBox.Image = (Image)dImage.Clone();
                }
                
                await Task.Delay(2000);
            }
        }

        public static List<Image> getListImage()
        {
            return images;
        }
        public static List<string> getObjectImage()
        {
            return objectNames;
        }
        public static List<string> getObjectConf()
        {
            return objectConf;
        }
    }
}
