namespace App_gestion_de_archivos
{
    partial class Form_pictures
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
            this.btm_picture = new System.Windows.Forms.Button();
            this.Pictu_Box = new System.Windows.Forms.PictureBox();
            this.ComB_stel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictu_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // btm_picture
            // 
            this.btm_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btm_picture.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_picture.Location = new System.Drawing.Point(703, 12);
            this.btm_picture.Name = "btm_picture";
            this.btm_picture.Size = new System.Drawing.Size(140, 39);
            this.btm_picture.TabIndex = 0;
            this.btm_picture.Text = "Open picture";
            this.btm_picture.UseVisualStyleBackColor = true;
            this.btm_picture.Click += new System.EventHandler(this.btm_picture_Click);
            // 
            // Pictu_Box
            // 
            this.Pictu_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pictu_Box.BackColor = System.Drawing.SystemColors.Control;
            this.Pictu_Box.Location = new System.Drawing.Point(12, 12);
            this.Pictu_Box.Name = "Pictu_Box";
            this.Pictu_Box.Size = new System.Drawing.Size(685, 426);
            this.Pictu_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pictu_Box.TabIndex = 2;
            this.Pictu_Box.TabStop = false;
            this.Pictu_Box.Click += new System.EventHandler(this.Pictu_Box_Click);
            // 
            // ComB_stel
            // 
            this.ComB_stel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComB_stel.FormattingEnabled = true;
            this.ComB_stel.Items.AddRange(new object[] {
            "*.jpeg ",
            "*.jpg",
            "*.png",
            "*.gif",
            "*.bmp",
            "*.svg"});
            this.ComB_stel.Location = new System.Drawing.Point(703, 67);
            this.ComB_stel.Name = "ComB_stel";
            this.ComB_stel.Size = new System.Drawing.Size(140, 21);
            this.ComB_stel.TabIndex = 3;
            // 
            // Form_pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.ComB_stel);
            this.Controls.Add(this.Pictu_Box);
            this.Controls.Add(this.btm_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form_pictures";
            this.Text = "Form_pictures";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_pictures_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pictu_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btm_picture;
        private System.Windows.Forms.PictureBox Pictu_Box;
        private System.Windows.Forms.ComboBox ComB_stel;
    }
}