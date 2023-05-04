namespace App_gestion_de_archivos
{
    partial class Form_Start
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btm_organize = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btm_video = new System.Windows.Forms.Button();
            this.btm_picture = new System.Windows.Forms.Button();
            this.btm_open_folders = new System.Windows.Forms.Button();
            this.btm_music = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btm_organize
            // 
            this.btm_organize.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_organize.Location = new System.Drawing.Point(12, 106);
            this.btm_organize.Name = "btm_organize";
            this.btm_organize.Size = new System.Drawing.Size(171, 42);
            this.btm_organize.TabIndex = 0;
            this.btm_organize.Text = "Organize";
            this.btm_organize.UseVisualStyleBackColor = true;
            this.btm_organize.Click += new System.EventHandler(this.btm_organizar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // btm_video
            // 
            this.btm_video.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_video.Location = new System.Drawing.Point(194, 106);
            this.btm_video.Name = "btm_video";
            this.btm_video.Size = new System.Drawing.Size(171, 42);
            this.btm_video.TabIndex = 2;
            this.btm_video.Text = "Video";
            this.btm_video.UseVisualStyleBackColor = true;
            this.btm_video.Click += new System.EventHandler(this.btm_video_Click);
            // 
            // btm_picture
            // 
            this.btm_picture.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_picture.Location = new System.Drawing.Point(12, 167);
            this.btm_picture.Name = "btm_picture";
            this.btm_picture.Size = new System.Drawing.Size(171, 42);
            this.btm_picture.TabIndex = 3;
            this.btm_picture.Text = "Picture";
            this.btm_picture.UseVisualStyleBackColor = true;
            this.btm_picture.Click += new System.EventHandler(this.btm_picture_Click);
            // 
            // btm_open_folders
            // 
            this.btm_open_folders.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_open_folders.Location = new System.Drawing.Point(93, 215);
            this.btm_open_folders.Name = "btm_open_folders";
            this.btm_open_folders.Size = new System.Drawing.Size(171, 42);
            this.btm_open_folders.TabIndex = 4;
            this.btm_open_folders.Text = "Open folders";
            this.btm_open_folders.UseVisualStyleBackColor = true;
            this.btm_open_folders.Click += new System.EventHandler(this.btm_open_folders_Click);
            // 
            // btm_music
            // 
            this.btm_music.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_music.Location = new System.Drawing.Point(194, 167);
            this.btm_music.Name = "btm_music";
            this.btm_music.Size = new System.Drawing.Size(171, 42);
            this.btm_music.TabIndex = 5;
            this.btm_music.Text = "Music";
            this.btm_music.UseVisualStyleBackColor = true;
            this.btm_music.Click += new System.EventHandler(this.btm_music_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(377, 275);
            this.Controls.Add(this.btm_music);
            this.Controls.Add(this.btm_open_folders);
            this.Controls.Add(this.btm_picture);
            this.Controls.Add(this.btm_video);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btm_organize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form_Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btm_organize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btm_video;
        private System.Windows.Forms.Button btm_picture;
        private System.Windows.Forms.Button btm_open_folders;
        private System.Windows.Forms.Button btm_music;
    }
}

