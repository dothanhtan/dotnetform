using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoThanhTan
{
    public partial class Pictures : Form
    {
        Image image;
        string openFileName;
        string pathDirectoryImg;
        List<string> imageFiles = new List<string>();
        int index = 1;
        public Pictures()
        {
            InitializeComponent();
            picture.AllowDrop = true;
            pathDirectoryImg = Application.StartupPath + "/img";
            if (Directory.Exists(Application.StartupPath + "/img"))
            {
                var files = Directory.GetFiles(Application.StartupPath + "/img", "*.*", SearchOption.AllDirectories);
                if (files.Length > 0)
                {
                    foreach (string filename in files)
                    {
                        if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                        {
                            imageFiles.Add(filename);
                        }
                    }
                    FileStream fileStream = new FileStream(imageFiles[0], FileMode.Open, FileAccess.Read);
                    picture.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                }

            }
            else
            {
                picture.Image = Properties.Resources.design_form_SV;
            }
        }

        private void linkavartar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose image";
            openFileDialog.Filter = "File image(*.png, *.jpg)|*.png;*.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileName = openFileDialog.FileName;
                try
                {
                    var files = Directory.GetFiles(folderDialog.SelectedPath, "*.*", SearchOption.AllDirectories);
                    imageFiles = new List<string>();
                    int count = 1;
                    foreach (string filename in files)
                    {
                        if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                        {                        
                            imageFiles.Add(filename);                        
                        }
                    }
                    if (imageFiles.Count > 0)
                    {
                        timer.Stop();
                        if (Directory.Exists(Application.StartupPath + "/img"))
                        {
                            var old_files = Directory.GetFiles(Application.StartupPath + "/img", "*.*", SearchOption.AllDirectories);
                            if (old_files.Length > 0)
                            {
                                foreach (string filename in old_files)
                                {
                                    if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                                    {

                                        File.Delete(filename);
                                    }
                                }
                            }
                        }

                        foreach (string filename in imageFiles)
                        {
                            image = Image.FromFile(filename);
                            if (image != null)
                            {
                                if (!Directory.Exists(pathDirectoryImg))
                                {
                                    Directory.CreateDirectory(pathDirectoryImg);
                                }

                                string st = String.Format("/slide_{0}.png", count);
                                image.Save(pathDirectoryImg + st);
                                count++;

                            }
                        }

                    }

                    MessageBox.Show("Upload successful. New picture will upload after 3s",
                                "Notification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    index = 0;
                    timer.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occurred while attempting to upload the file. The error is:"
                                    + System.Environment.NewLine + ex.ToString() + System.Environment.NewLine);
                }
                Invalidate();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                FileStream fileStream = new FileStream(imageFiles[index], FileMode.Open, FileAccess.Read);
                picture.Image = Image.FromStream(fileStream);
                fileStream.Close();
                if (index == imageFiles.Count - 1)
                    index = 0;
                else
                    index++;
            }
        }
    }
}
