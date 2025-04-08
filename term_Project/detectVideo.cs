using SkiaSharp;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoloDotNet;
using YoloDotNet.Enums;
using YoloDotNet.Models;
using OpenCvSharp.Extensions;
using OpenCvSharp;
using System.Text;


namespace term_Project
{
    internal class detectVideo
    {
        public static async Task VideoDetecting(string filepath, PictureBox pictureBox)
        {
            using var yolo = new Yolo(new YoloOptions
            {
                OnnxModel = @"D:\Source\C#winform\term_Project\term_Project\yolo11n.onnx",
                ModelType = ModelType.ObjectDetection,
                Cuda = false,
                GpuId = 0,
                PrimeGpu = true,
            });

            using (VideoCapture videoCapture = new VideoCapture(filepath))
            {
                Mat frame = new Mat();
                bool isVideoRunning = true;
                var fps = videoCapture.Fps > 0 ? videoCapture.Fps : 30; 
                int delay = (int)(1000 / fps);

                while (isVideoRunning && videoCapture.IsOpened())
                {
                    if (!videoCapture.Read(frame) || frame.Empty())
                    {
                        isVideoRunning = false;
                        break;
                    }

                    using Bitmap bitmap = frame.ToBitmap();
                    using SKImage skImage = BitmapToSkImage(bitmap);

                    var detections = yolo.RunObjectDetection(skImage, confidence: 0.25, iou: 0.7);

                    using Graphics g = Graphics.FromImage(bitmap);
                    foreach (var detection in detections)
                    {
                        var rect = new Rectangle(
                            (int)detection.BoundingBox.Left,
                            (int)detection.BoundingBox.Top,
                            (int)detection.BoundingBox.Width,
                            (int)detection.BoundingBox.Height
                        );

                        using var pen = new Pen(Color.Blue, 2);
                        g.DrawRectangle(pen, rect);

                        string label = $"{detection.Label.Name} ({detection.Confidence:P2})";
                        var labelPosition = new PointF(rect.Left, Math.Max(0, rect.Top - 20)); 
                        g.DrawString(label, new Font("Arial", 14), Brushes.Blue, labelPosition);
                    }

                    // Cập nhật PictureBox
                    if (pictureBox.Image != null)
                        pictureBox.Image.Dispose(); 

                    pictureBox.Image = (Bitmap)bitmap.Clone();
                    await Task.Delay(delay);
                }
            }

        }


        public static SKImage BitmapToSkImage(Bitmap bitmap)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                SKBitmap skBitmap = SKBitmap.Decode(stream);
                return SKImage.FromBitmap(skBitmap);
            }
        }
    }
}
