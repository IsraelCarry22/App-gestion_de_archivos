namespace App_gestion_de_archivos
{
    partial class Form_video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_video));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_pcb_next = new System.Windows.Forms.PictureBox();
            this.btn_pcb_play = new System.Windows.Forms.PictureBox();
            this.btn_pcb_back = new System.Windows.Forms.PictureBox();
            this.sound = new XComponent.SliderBar.MACTrackBar();
            this.duration = new XComponent.SliderBar.MACTrackBar();
            this.Reproductor_video = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_video = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor_video)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btn_pcb_next);
            this.panel1.Controls.Add(this.btn_pcb_play);
            this.panel1.Controls.Add(this.btn_pcb_back);
            this.panel1.Controls.Add(this.sound);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 78);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(947, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "0:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "0:00";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::App_gestion_de_archivos.Properties.Resources._005_sonido;
            this.pictureBox4.Location = new System.Drawing.Point(691, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btn_pcb_next
            // 
            this.btn_pcb_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_next.Image = global::App_gestion_de_archivos.Properties.Resources._003_siguiente;
            this.btn_pcb_next.Location = new System.Drawing.Point(520, 34);
            this.btn_pcb_next.Name = "btn_pcb_next";
            this.btn_pcb_next.Size = new System.Drawing.Size(52, 41);
            this.btn_pcb_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_next.TabIndex = 4;
            this.btn_pcb_next.TabStop = false;
            this.btn_pcb_next.Click += new System.EventHandler(this.btn_pcb_next_Click);
            // 
            // btn_pcb_play
            // 
            this.btn_pcb_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_play.Image = global::App_gestion_de_archivos.Properties.Resources._002_jugar;
            this.btn_pcb_play.Location = new System.Drawing.Point(462, 34);
            this.btn_pcb_play.Name = "btn_pcb_play";
            this.btn_pcb_play.Size = new System.Drawing.Size(52, 41);
            this.btn_pcb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_play.TabIndex = 3;
            this.btn_pcb_play.TabStop = false;
            this.btn_pcb_play.Click += new System.EventHandler(this.btn_pcb_play_Click);
            // 
            // btn_pcb_back
            // 
            this.btn_pcb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pcb_back.Image = global::App_gestion_de_archivos.Properties.Resources._001_atras;
            this.btn_pcb_back.Location = new System.Drawing.Point(404, 34);
            this.btn_pcb_back.Name = "btn_pcb_back";
            this.btn_pcb_back.Size = new System.Drawing.Size(52, 41);
            this.btn_pcb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_pcb_back.TabIndex = 2;
            this.btn_pcb_back.TabStop = false;
            this.btn_pcb_back.Click += new System.EventHandler(this.btn_pcb_back_Click);
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.sound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sound.IndentHeight = 6;
            this.sound.Location = new System.Drawing.Point(793, 48);
            this.sound.Maximum = 100;
            this.sound.Minimum = 0;
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(191, 22);
            this.sound.TabIndex = 1;
            this.sound.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.sound.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.sound.TickHeight = 4;
            this.sound.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sound.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.sound.TrackerSize = new System.Drawing.Size(10, 10);
            this.sound.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sound.TrackLineHeight = 3;
            this.sound.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sound.Value = 0;
            this.sound.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.sound_ValueChanged);
            // 
            // duration
            // 
            this.duration.BackColor = System.Drawing.Color.Transparent;
            this.duration.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.duration.Cursor = System.Windows.Forms.Cursors.Default;
            this.duration.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.duration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.duration.IndentHeight = 6;
            this.duration.Location = new System.Drawing.Point(3, 6);
            this.duration.Maximum = 100;
            this.duration.Minimum = 0;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(981, 22);
            this.duration.TabIndex = 0;
            this.duration.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.duration.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.duration.TickHeight = 4;
            this.duration.TickStyle = System.Windows.Forms.TickStyle.None;
            this.duration.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.duration.TrackerSize = new System.Drawing.Size(10, 10);
            this.duration.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.duration.TrackLineHeight = 3;
            this.duration.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.duration.Value = 0;
            this.duration.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.duration_ValueChanged);
            // 
            // Reproductor_video
            // 
            this.Reproductor_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reproductor_video.Enabled = true;
            this.Reproductor_video.Location = new System.Drawing.Point(0, 24);
            this.Reproductor_video.Name = "Reproductor_video";
            this.Reproductor_video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor_video.OcxState")));
            this.Reproductor_video.Size = new System.Drawing.Size(987, 445);
            this.Reproductor_video.TabIndex = 2;
            // 
            // timer_video
            // 
            this.timer_video.Tick += new System.EventHandler(this.timer_video_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "--";
            // 
            // Form_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(987, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reproductor_video);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_video";
            this.Text = "Form_video";
            this.Load += new System.EventHandler(this.Form_video_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pcb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor_video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_pcb_back;
        private XComponent.SliderBar.MACTrackBar sound;
        private XComponent.SliderBar.MACTrackBar duration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btn_pcb_next;
        private System.Windows.Forms.PictureBox btn_pcb_play;
        private System.Windows.Forms.Timer timer_video;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor_video;
        private System.Windows.Forms.Label label4;
    }
}