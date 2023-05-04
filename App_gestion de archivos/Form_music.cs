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
    public partial class Form_music : Form
    {
        bool Musica = false;
        bool play = false;
        int cont = 0;
        string[] Archivos_mp3;
        string[] rutas_archivos_mp3;
        public Form_music()
        {
            InitializeComponent();
            cont = 0;
        }

        private void btn_pcb_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog caja_busqueda = new OpenFileDialog();
            caja_busqueda.Multiselect = true;
            if (caja_busqueda.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Archivos_mp3 = caja_busqueda.SafeFileNames;
            rutas_archivos_mp3 = caja_busqueda.FileNames;
            foreach (var Archivo_mp3 in Archivos_mp3)
            {
                list_songs.Items.Add(Archivo_mp3);
            }
            reproductor.URL = rutas_archivos_mp3[0];
            list_songs.SelectedIndex = 0;
            btn_pcb_play.Image = Properties.Resources.pausa;
            Musica = true;
        }

        private void btm_return_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void list_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            reproductor.URL = rutas_archivos_mp3[list_songs.SelectedIndex];
            label1.Text = Archivos_mp3[list_songs.SelectedIndex];
        }

        private void btn_pcb_stop_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.stop();
            btn_pcb_play.Image = Properties.Resources.play;
            play = false;
        }

        private void btn_pcb_play_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case true:
                    reproductor.Ctlcontrols.pause();
                    btn_pcb_play.Image = Properties.Resources.play;
                    play = false;
                    break;
                case false:
                    reproductor.Ctlcontrols.play();
                    btn_pcb_play.Image = Properties.Resources.pausa;
                    play = true;
                    break;
            }
        }

        public void metodos_track()
        {
            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                status.Maximum = (int)reproductor.Ctlcontrols.currentItem.duration;
                timer_song.Start();
            }
            else if (reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer_song.Stop();
            }
            else if (reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer_song.Stop();
                status.Value = 0;
            }
        }

        private void timer_song_Tick(object sender, EventArgs e)
        {
            metodos_track();
            status.Value = (int)reproductor.Ctlcontrols.currentPosition;
            Sonido.Value = reproductor.settings.volume;
        }

        private void reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            metodos_track();
        }

        private void Sonido_ValueChanged(object sender, decimal value)
        {
            reproductor.settings.volume = Sonido.Value;
        }

        private void status_ValueChanged(object sender, decimal value)
        {
            reproductor.settings.playCount = status.Value;
        }

        private void btn_pcb_atras_Click(object sender, EventArgs e)
        {
            if (Musica != true)
            {
                return;
            }
            if (cont == rutas_archivos_mp3.Length - 1)
            {
                cont = 0;
            }
            else
            {
                cont++;
            }
            reproductor.URL = rutas_archivos_mp3[cont];
            label1.Text = Archivos_mp3[cont];
        }

        private void btn_pcb_adelante_Click(object sender, EventArgs e)
        {
            if (Musica != true)
            {
                return;
            }
            if (cont == 0)
            {
                cont = rutas_archivos_mp3.Length - 1;
            }
            else
            {
                cont--;
            }
            reproductor.URL = rutas_archivos_mp3[cont];
            label1.Text = Archivos_mp3[cont];
        }
    }
}