using NAudio.Dmo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_gestion_de_archivos
{
    public partial class Form_video : Form
    {
        bool play = false;
        public OpenFileDialog Video = new OpenFileDialog();

        public Form_video()
        {
            InitializeComponent();
        }

        private void btn_pcb_play_Click(object sender, EventArgs e)
        {
            if (play == false)
            {
                Reproductor_video.Ctlcontrols.pause();
                timer_video.Stop();

                btn_pcb_play.Image = Properties.Resources._004_pausa;
                play = true;
            }
            else
            {
                Reproductor_video.Ctlcontrols.play();
                timer_video.Start();

                btn_pcb_play.Image = Properties.Resources._002_jugar;
                play = false;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Video.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Video.Filter = "Archivo files|*.mp4;*.avi;*.mov;*.wmv;*.mkv;*";
            Reproductor_video.Ctlcontrols.play();
            Reproductor_video.URL = Video.FileName;
            timer_video.Start();

            duration.Enabled = true;
            btn_pcb_play.Image = Properties.Resources._002_jugar;
            label4.Text = Video.SafeFileName;
            play = false;
        }

        private void btn_pcb_back_Click(object sender, EventArgs e)
        {
            if ((duration.Value = duration.Value - 10) < 0)
            {
                duration.Value = 0;
            }
            else
            {
                duration.Value = duration.Value - 10;
            }
        }

        private void btn_pcb_next_Click(object sender, EventArgs e)
        {
            duration.Value = duration.Value + 10;
        }

        private void Form_video_Load(object sender, EventArgs e)
        {
            label2.Text = (sound.Value = Reproductor_video.settings.volume = 50).ToString();
            this.Reproductor_video.uiMode = "none";
        }


        private void duration_ValueChanged(object sender, decimal value)
        {
            duration.Maximum = (int)Reproductor_video.currentMedia.duration;
            if (duration.Value == (int)Reproductor_video.Ctlcontrols.currentPosition) { }
            else
            {
                Reproductor_video.Ctlcontrols.currentPosition = duration.Value;
            }
        }

        private void timer_video_Tick(object sender, EventArgs e)
        {
            try
            {
                duration.Value = (int)Reproductor_video.Ctlcontrols.currentPosition;
                label1.Text = Reproductor_video.Ctlcontrols.currentPositionString;
                label3.Text = Reproductor_video.currentMedia.durationString;
            }
            catch 
            {
                throw;
            }
        }

        private void sound_ValueChanged(object sender, decimal value)
        {
            Reproductor_video.settings.volume = sound.Value;
            label2.Text = Reproductor_video.settings.volume.ToString();
        }
    }
}