using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace App_gestion_de_archivos
{
    public partial class Form_archive : Form
    {
        public Form_archive()
        {
            InitializeComponent();
        }

        private void btm_return_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btn_open_archive_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo_exist = new OpenFileDialog();
            if (archivo_exist.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Process.Start(archivo_exist.FileName);
        }

        private void btn_open_pro_office_Click(object sender, EventArgs e)
        {
            string programa = "";
            if (bom_box_programa.Text == "")
            {
                errorProvider1.SetError(bom_box_programa, "Seleccione un Programa");
                return;
            }
            errorProvider1.SetError(bom_box_programa, "");
            switch (bom_box_programa.Text)
            {
                case "Word":
                    programa = "WINWORD.EXE";
                    break;
                case "Excel":
                    programa = "EXCEL.EXE";
                    break;
                case "Power point":
                    programa = "POWERPNT.EXE";
                    break;
                case "Outlook":
                    programa = "OUTLOOK.EXE";
                    break;
                case "Access":
                    programa = "MSACCESS.EXE";
                    break;
                case "Publisher":
                    programa = "MSPUB.EXE";
                    break;
            }
            Process.Start(programa);
        }
    }
}
