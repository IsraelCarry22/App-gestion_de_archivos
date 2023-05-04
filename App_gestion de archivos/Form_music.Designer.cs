namespace App_gestion_de_archivos
{
    partial class Form_music
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_music));
            this.list_songs = new System.Windows.Forms.ListBox();
            this.btn_pcb_add = new System.Windows.Forms.PictureBox();
            this.Sonido = new XComponent.SliderBar.MACTrackBar();
            this.status = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pcb_stop = new System.Windows.Forms.PictureBox();
            this.btn_pcb_play = new System.Windows.Forms.PictureBox();
            this.btn_pcb_sound = new System.Windows.Forms.PictureBox();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_song = new System.Windows.Forms.Timer(this.components);
            this.btn_pcb_atras = new System.Windows.Forms.PictureBox();
            this.btn_pcb_adelante = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_adelante)).BeginInit();
            this.SuspendLayout();
            // 
            // list_songs
            // 
            this.list_songs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_songs.FormattingEnabled = true;
            this.list_songs.Location = new System.Drawing.Point(10, 209);
            this.list_songs.Name = "list_songs";
            this.list_songs.Size = new System.Drawing.Size(361, 303);
            this.list_songs.TabIndex = 4;
            this.list_songs.SelectedIndexChanged += new System.EventHandler(this.list_songs_SelectedIndexChanged);
            // 
            // btn_pcb_add
            // 
            this.btn_pcb_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_add.Image = global::App_gestion_de_archivos.Properties.Resources.agregar;
            this.btn_pcb_add.Location = new System.Drawing.Point(12, 40);
            this.btn_pcb_add.Name = "btn_pcb_add";
            this.btn_pcb_add.Size = new System.Drawing.Size(68, 67);
            this.btn_pcb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_add.TabIndex = 5;
            this.btn_pcb_add.TabStop = false;
            this.btn_pcb_add.Click += new System.EventHandler(this.btn_pcb_add_Click);
            // 
            // Sonido
            // 
            this.Sonido.BackColor = System.Drawing.Color.Transparent;
            this.Sonido.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Sonido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sonido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Sonido.IndentHeight = 6;
            this.Sonido.Location = new System.Drawing.Point(76, 126);
            this.Sonido.Maximum = 100;
            this.Sonido.Minimum = 0;
            this.Sonido.Name = "Sonido";
            this.Sonido.Size = new System.Drawing.Size(226, 32);
            this.Sonido.TabIndex = 10;
            this.Sonido.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Sonido.TickColor = System.Drawing.Color.Red;
            this.Sonido.TickHeight = 4;
            this.Sonido.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Sonido.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Sonido.TrackerSize = new System.Drawing.Size(20, 20);
            this.Sonido.TrackLineColor = System.Drawing.Color.Gray;
            this.Sonido.TrackLineHeight = 3;
            this.Sonido.TrackLineSelectedColor = System.Drawing.Color.Gray;
            this.Sonido.Value = 0;
            this.Sonido.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Sonido_ValueChanged);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.status.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.status.IndentHeight = 6;
            this.status.Location = new System.Drawing.Point(12, 177);
            this.status.Maximum = 100;
            this.status.Minimum = 0;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(290, 26);
            this.status.TabIndex = 11;
            this.status.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.status.TickColor = System.Drawing.Color.Red;
            this.status.TickHeight = 4;
            this.status.TickStyle = System.Windows.Forms.TickStyle.None;
            this.status.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.status.TrackerSize = new System.Drawing.Size(14, 14);
            this.status.TrackLineColor = System.Drawing.Color.Silver;
            this.status.TrackLineHeight = 3;
            this.status.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.status.Value = 0;
            this.status.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.status_ValueChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "--";
            // 
            // btn_pcb_stop
            // 
            this.btn_pcb_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_stop.Image = global::App_gestion_de_archivos.Properties.Resources.boton_detener;
            this.btn_pcb_stop.Location = new System.Drawing.Point(303, 40);
            this.btn_pcb_stop.Name = "btn_pcb_stop";
            this.btn_pcb_stop.Size = new System.Drawing.Size(68, 67);
            this.btn_pcb_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_stop.TabIndex = 15;
            this.btn_pcb_stop.TabStop = false;
            this.btn_pcb_stop.Click += new System.EventHandler(this.btn_pcb_stop_Click);
            // 
            // btn_pcb_play
            // 
            this.btn_pcb_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_play.Image = global::App_gestion_de_archivos.Properties.Resources.play;
            this.btn_pcb_play.Location = new System.Drawing.Point(160, 40);
            this.btn_pcb_play.Name = "btn_pcb_play";
            this.btn_pcb_play.Size = new System.Drawing.Size(68, 67);
            this.btn_pcb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_play.TabIndex = 16;
            this.btn_pcb_play.TabStop = false;
            this.btn_pcb_play.Click += new System.EventHandler(this.btn_pcb_play_Click);
            // 
            // btn_pcb_sound
            // 
            this.btn_pcb_sound.Image = global::App_gestion_de_archivos.Properties.Resources.volumen;
            this.btn_pcb_sound.Location = new System.Drawing.Point(12, 113);
            this.btn_pcb_sound.Name = "btn_pcb_sound";
            this.btn_pcb_sound.Size = new System.Drawing.Size(68, 67);
            this.btn_pcb_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_sound.TabIndex = 17;
            this.btn_pcb_sound.TabStop = false;
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(10, 445);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(162, 67);
            this.reproductor.TabIndex = 3;
            this.reproductor.Visible = false;
            this.reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.reproductor_PlayStateChange);
            // 
            // timer_song
            // 
            this.timer_song.Enabled = true;
            this.timer_song.Interval = 1;
            this.timer_song.Tick += new System.EventHandler(this.timer_song_Tick);
            // 
            // btn_pcb_atras
            // 
            this.btn_pcb_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_atras.Image = global::App_gestion_de_archivos.Properties.Resources._001_atras;
            this.btn_pcb_atras.Location = new System.Drawing.Point(97, 51);
            this.btn_pcb_atras.Name = "btn_pcb_atras";
            this.btn_pcb_atras.Size = new System.Drawing.Size(46, 47);
            this.btn_pcb_atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_atras.TabIndex = 18;
            this.btn_pcb_atras.TabStop = false;
            this.btn_pcb_atras.Click += new System.EventHandler(this.btn_pcb_atras_Click);
            // 
            // btn_pcb_adelante
            // 
            this.btn_pcb_adelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_adelante.Image = global::App_gestion_de_archivos.Properties.Resources._003_siguiente;
            this.btn_pcb_adelante.Location = new System.Drawing.Point(244, 51);
            this.btn_pcb_adelante.Name = "btn_pcb_adelante";
            this.btn_pcb_adelante.Size = new System.Drawing.Size(46, 47);
            this.btn_pcb_adelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_adelante.TabIndex = 19;
            this.btn_pcb_adelante.TabStop = false;
            this.btn_pcb_adelante.Click += new System.EventHandler(this.btn_pcb_adelante_Click);
            // 
            // Form_music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(389, 517);
            this.Controls.Add(this.btn_pcb_adelante);
            this.Controls.Add(this.btn_pcb_atras);
            this.Controls.Add(this.btn_pcb_sound);
            this.Controls.Add(this.btn_pcb_play);
            this.Controls.Add(this.btn_pcb_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Sonido);
            this.Controls.Add(this.btn_pcb_add);
            this.Controls.Add(this.list_songs);
            this.Controls.Add(this.reproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_music";
            this.Text = "Form_music";
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_adelante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.ListBox list_songs;
        private System.Windows.Forms.PictureBox btn_pcb_add;
        private XComponent.SliderBar.MACTrackBar Sonido;
        private XComponent.SliderBar.MACTrackBar status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_pcb_stop;
        private System.Windows.Forms.PictureBox btn_pcb_play;
        private System.Windows.Forms.PictureBox btn_pcb_sound;
        private System.Windows.Forms.Timer timer_song;
        private System.Windows.Forms.PictureBox btn_pcb_atras;
        private System.Windows.Forms.PictureBox btn_pcb_adelante;
    }
}