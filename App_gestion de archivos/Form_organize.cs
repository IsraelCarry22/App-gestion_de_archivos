using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_gestion_de_archivos
{
	public partial class Form_Start : Form
	{
        FolderBrowserDialog usb_stick;
        string[] videoExtensions; 
        string[] audioExtensions; 
        string[] imageExtensions; 
        string[] documentExtensions;
        string[] otherExtensions;
        public Form_Start()
		{
			InitializeComponent();
            usb_stick = new FolderBrowserDialog();
            videoExtensions = new string[] { ".mp4", ".avi", ".mov", ".mkv" };
            audioExtensions = new string[] { ".mp3", ".wav", ".flac" };
            imageExtensions = new string[] { ".jpg", ".png", ".gif" };
            documentExtensions = new string[] { ".txt", ".docx", ".pdf", ".xlsx" };
            otherExtensions = new string[0];
            btm_open_folders.Enabled = false;
            btm_picture.Enabled = false;
            btm_music.Enabled = false;
            btm_video.Enabled = false;
        }

        private void btm_organizar_Click(object sender, EventArgs e)
        {
            if (usb_stick.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String directory = usb_stick.SelectedPath;

            DirectoryInfo dif = new DirectoryInfo(directory);

            String desktop_folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            String n_d_f_o = Path.Combine(desktop_folder, "Archivos organizados (USB)"); //new_desktop_folder_organized

            if (Directory.Exists(n_d_f_o))
            {
                MessageBox.Show("Los archivos ya están organizados.", "Archivos organizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btm_open_folders.Enabled = true;
                btm_picture.Enabled = true;
                btm_music.Enabled = true;
                btm_video.Enabled = true;
            }
            else
            {
                Directory.CreateDirectory(n_d_f_o);

                int all_files = dif.GetFiles().Length;
                progressBar1.Maximum = all_files;
                progressBar1.Minimum = 0;

                foreach (FileInfo file in dif.GetFiles())
                {
                    String file_extension = Path.GetExtension(file.Name);

                    if (Array.IndexOf(videoExtensions, file_extension) != -1)
                    {
                        string videoFolderPath = Path.Combine(n_d_f_o, "videos");
                        Directory.CreateDirectory(videoFolderPath);
                        string subfolderPath = Path.Combine(videoFolderPath, file_extension.Replace(".", ""));
                        Directory.CreateDirectory(subfolderPath);
                        File.Copy(file.FullName, Path.Combine(subfolderPath, Path.GetFileName(file.Name)));
                    }
                    else if (Array.IndexOf(audioExtensions, file_extension) != -1)
                    {
                        string audioFolderPath = Path.Combine(n_d_f_o, "audio");
                        Directory.CreateDirectory(audioFolderPath);
                        string subfolderPath = Path.Combine(audioFolderPath, file_extension.Replace(".", ""));
                        Directory.CreateDirectory(subfolderPath);
                        File.Copy(file.FullName, Path.Combine(subfolderPath, Path.GetFileName(file.Name)));
                    }
                    else if (Array.IndexOf(imageExtensions, file_extension) != -1)
                    {
                        string imageFolderPath = Path.Combine(n_d_f_o, "imagenes");
                        Directory.CreateDirectory(imageFolderPath);
                        string subfolderPath = Path.Combine(imageFolderPath, file_extension.Replace(".", ""));
                        Directory.CreateDirectory(subfolderPath);
                        File.Copy(file.FullName, Path.Combine(subfolderPath, Path.GetFileName(file.Name)));
                    }
                    else if (Array.IndexOf(documentExtensions, file_extension) != -1)
                    {
                        string documentFolderPath = Path.Combine(n_d_f_o, "documentos");
                        Directory.CreateDirectory(documentFolderPath);
                        string subfolderPath = Path.Combine(documentFolderPath, file_extension.Replace(".", ""));
                        Directory.CreateDirectory(subfolderPath);
                        File.Copy(file.FullName, Path.Combine(subfolderPath, Path.GetFileName(file.Name)));
                    }
                    else
                    {
                        string otherFolderPath = Path.Combine(n_d_f_o, "otros");
                        Directory.CreateDirectory(otherFolderPath);
                        File.Copy(file.FullName, Path.Combine(otherFolderPath, Path.GetFileName(file.Name)));
                    }
                    progressBar1.Value++;
                }
                MessageBox.Show("Archivos organizados exitosamente");
                btm_open_folders.Enabled = true;
                btm_picture.Enabled = true;
                btm_music.Enabled = true;
                btm_video.Enabled = true;
            }
        }

        private void btm_video_Click(object sender, EventArgs e)
        {
            Form_video F_V = new Form_video();
            F_V.Show();
        }

        private void btm_picture_Click(object sender, EventArgs e)
        {
            Form_pictures F_P = new Form_pictures();
            F_P.Show();
        }

        private void btm_open_folders_Click(object sender, EventArgs e)
        {
            Form_archive F_A = new Form_archive();
            F_A.Show();
        }

        private void btm_music_Click(object sender, EventArgs e)
        {
            Form_music F_M = new Form_music();
            F_M.Show();
        }
    }
}