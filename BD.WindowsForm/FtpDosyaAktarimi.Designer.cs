﻿namespace BD.WindowsForm
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 75);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Karekodu okutup dosyaların aktarılmasını bekleyiniz. \r\nDosyalar aktarıldıktan son" +
    "ra Kaydet butonuna basınız.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 45);
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
            this.panel3.Location = new System.Drawing.Point(0, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 83);
            this.panel3.TabIndex = 6;
            // 
            // btnDosyaKaydet
            // 
            this.btnDosyaKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDosyaKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDosyaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDosyaKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaKaydet.Image = global::BD.WindowsForm.Properties.Resources.datatransfer;
            this.btnDosyaKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaKaydet.Location = new System.Drawing.Point(4, 3);
            this.btnDosyaKaydet.Name = "btnDosyaKaydet";
            this.btnDosyaKaydet.Size = new System.Drawing.Size(309, 73);
            this.btnDosyaKaydet.TabIndex = 8;
            this.btnDosyaKaydet.Text = "               Operasyon Kayıtları Kaydet";
            this.btnDosyaKaydet.UseVisualStyleBackColor = false;
            this.btnDosyaKaydet.Click += new System.EventHandler(this.btnDosyaKaydet_Click);
            // 
            // FtpDosyaAktarimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FtpDosyaAktarimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Aktarımı";
            this.Load += new System.EventHandler(this.FtpDosyaAktarimi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
    }
}