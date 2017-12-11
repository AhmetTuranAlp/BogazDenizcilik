namespace BD.WindowsForm
{
    partial class FtpDosyaAktarimi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDosyaKaydet = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 33);
            this.panel2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 305);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnDosyaKaydet);
            this.panel3.Location = new System.Drawing.Point(0, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 83);
            this.panel3.TabIndex = 6;
            // 
            // btnDosyaKaydet
            // 
            this.btnDosyaKaydet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDosyaKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDosyaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDosyaKaydet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaKaydet.Location = new System.Drawing.Point(4, 4);
            this.btnDosyaKaydet.Name = "btnDosyaKaydet";
            this.btnDosyaKaydet.Size = new System.Drawing.Size(309, 72);
            this.btnDosyaKaydet.TabIndex = 8;
            this.btnDosyaKaydet.Text = "Operasyon Kayıtları Kaydet";
            this.btnDosyaKaydet.UseVisualStyleBackColor = false;
            this.btnDosyaKaydet.Click += new System.EventHandler(this.btnDosyaKaydet_Click);
            // 
            // FtpDosyaAktarimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FtpDosyaAktarimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Aktarımı";
            this.Load += new System.EventHandler(this.FtpDosyaAktarimi_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDosyaKaydet;
    }
}