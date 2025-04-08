using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace term_Project
{
    internal class fileWorking
    {
        public static string openImageFile()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "browse image file ",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "img",
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*",
                
                FilterIndex = 2,
            };
            if (openFile.ShowDialog() == DialogResult.OK) return openFile.FileName;
            else return null;

        }

        public static void saveImages(List<Image> images)
        {
            List<string> objectName = detectImage.getObjectImage();
            List<string> objectConf = detectImage.getObjectConf();
            if (images == null || images.Count == 0)
            {
                MessageBox.Show("No image to save");
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Browse folder to save images";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    for (int i = 0; i < images.Count; i++)
                    {
                        string filePath;
                        if (i < 1)
                        {
                            filePath = Path.Combine(folderPath, $"DetectedImage{i + 1}.jpg");
                        }
                        else
                        {
                            filePath = Path.Combine(folderPath, $"{objectName[i - 1]} ({objectConf[i - 1]}).jpg");
                        }

                        int count = 1;
                        string originalFilePath = filePath;
                        while (File.Exists(filePath))
                        {
                            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFilePath);
                            string extension = Path.GetExtension(originalFilePath);
                            filePath = Path.Combine(folderPath, $"{fileNameWithoutExt}_{count}{extension}");
                            count++;
                        }

                        images[i].Save(filePath);
                    }
                    MessageBox.Show("Images saved successfully");
                }
                else
                {
                    MessageBox.Show("Save operation was canceled");
                }
            }
        }


        public static string openVideoFile()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "browse video file",

                CheckFileExists= true,
                CheckPathExists = true,

                DefaultExt = "mp4",
                Filter = "Video Files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv|All Files (*.*)|*.*",
                FilterIndex = 1

            };
            if (openFile.ShowDialog() == DialogResult.OK) return openFile.FileName;
            else
            {
                return null;
            }
        }
    }
}
