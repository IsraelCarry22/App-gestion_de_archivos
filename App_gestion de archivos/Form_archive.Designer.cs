namespace App_gestion_de_archivos
{
    partial class Form_archive
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
            this.btn_open_pro_office = new System.Windows.Forms.Button();
            this.btn_open_archive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bom_box_programa = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open_pro_office
            // 
            this.btn_open_pro_office.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_open_pro_office.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_pro_office.Location = new System.Drawing.Point(40, 112);
            this.btn_open_pro_office.Name = "btn_open_pro_office";
            this.btn_open_pro_office.Size = new System.Drawing.Size(194, 64);
            this.btn_open_pro_office.TabIndex = 0;
            this.btn_open_pro_office.Text = "Abrir prog office";
            this.btn_open_pro_office.UseVisualStyleBackColor = true;
            this.btn_open_pro_office.Click += new System.EventHandler(this.btn_open_pro_office_Click);
            // 
            // btn_open_archive
            // 
            this.btn_open_archive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_open_archive.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_archive.Location = new System.Drawing.Point(240, 112);
            this.btn_open_archive.Name = "btn_open_archive";
            this.btn_open_archive.Size = new System.Drawing.Size(203, 64);
            this.btn_open_archive.TabIndex = 1;
            this.btn_open_archive.Text = "Abrir archivo";
            this.btn_open_archive.UseVisualStyleBackColor = true;
            this.btn_open_archive.Click += new System.EventHandler(this.btn_open_archive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programa de office:";
            // 
            // bom_box_programa
            // 
            this.bom_box_programa.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bom_box_programa.FormattingEnabled = true;
            this.bom_box_programa.Items.AddRange(new object[] {
            "Word",
            "Excel",
            "Power point",
            "Outlook",
            "Access",
            "Publisher"});
            this.bom_box_programa.Location = new System.Drawing.Point(212, 9);
            this.bom_box_programa.Name = "bom_box_programa";
            this.bom_box_programa.Size = new System.Drawing.Size(203, 29);
            this.bom_box_programa.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(482, 188);
            this.Controls.Add(this.bom_box_programa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open_archive);
            this.Controls.Add(this.btn_open_pro_office);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_archive";
            this.Text = "Form_archive";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_pro_office;
        private System.Windows.Forms.Button btn_open_archive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bom_box_programa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}