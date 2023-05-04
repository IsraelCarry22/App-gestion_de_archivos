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
    public partial class Form_pictures : Form
    {
        String[] Path_imagen;
        int Cont;
        bool image = false;
        public Form_pictures()
        {
            InitializeComponent();
            Cont = 0;
        }

        private void btm_return_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btm_picture_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String folderpath = folderBrowserDialog.SelectedPath;
            Path_imagen = Directory.GetFiles(folderpath, $"*{ComB_stel.SelectedItem}");
            if (Path_imagen.Length == 0)
            {
                return;
            }
            Pictu_Box.Image = Image.FromFile(Path_imagen[0]);
            Cont = 0;
            image = true;
        }

        private void Pictu_Box_Click(object sender, EventArgs e)
        {
            if (image == true)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                btm_picture.Visible = false;
                ComB_stel.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void Form_pictures_KeyDown(object sender, KeyEventArgs e)
        {
            if (image == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                        btm_picture.Visible = true;
                        ComB_stel.Visible = true;
                        break;
                    case Keys.D:
                        if (Cont == Path_imagen.Length - 1)
                        {
                            Cont = 0;
                        }
                        else
                        {
                            Cont++;
                        }
                        Pictu_Box.Image = Image.FromFile(Path_imagen[Cont]);
                        break;
                    case Keys.A:
                        if (Cont == 0)
                        {
                            Cont = Path_imagen.Length - 1;
                        }
                        else
                        {
                            Cont--;
                        }
                        Pictu_Box.Image = Image.FromFile(Path_imagen[Cont]);
                        break;
                    default:
                        break;
                }
            }
            else { }
        }
    }
}