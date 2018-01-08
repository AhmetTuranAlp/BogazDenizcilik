namespace BD.WindowsForm
{
    partial class Yardim
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbTeamviewer = new System.Windows.Forms.PictureBox();
            this.pcbAlpemix = new System.Windows.Forms.PictureBox();
            this.pcbAnydesk = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTeamviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlpemix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnydesk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 187);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BD.WindowsForm.Properties.Resources.logo_proje54;
            this.pictureBox1.Location = new System.Drawing.Point(23, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "İndirme işlemini gerçekleştirmek için aşağıda bulunan uygulama logolarına tıklaya" +
    "rak uygulamayı \r\nbilgisayarınıza indirebilirsiniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(273, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "İletişim Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(370, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "destek@proje54.com";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destek almak için lütfen aşağıdaki programlardan birini indirip bilgisayarınıza k" +
    "urun ve belirtilen mail \r\nadresi ile bizimle iletişime geçin.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pcbTeamviewer);
            this.panel1.Controls.Add(this.pcbAlpemix);
            this.panel1.Controls.Add(this.pcbAnydesk);
            this.panel1.Location = new System.Drawing.Point(2, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 60);
            this.panel1.TabIndex = 9;
            // 
            // pcbTeamviewer
            // 
            this.pcbTeamviewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbTeamviewer.Image = global::BD.WindowsForm.Properties.Resources.teamviewer;
            this.pcbTeamviewer.Location = new System.Drawing.Point(3, 3);
            this.pcbTeamviewer.Name = "pcbTeamviewer";
            this.pcbTeamviewer.Size = new System.Drawing.Size(194, 51);
            this.pcbTeamviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTeamviewer.TabIndex = 6;
            this.pcbTeamviewer.TabStop = false;
            this.pcbTeamviewer.Click += new System.EventHandler(this.pcbTeamviewer_Click);
            // 
            // pcbAlpemix
            // 
            this.pcbAlpemix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbAlpemix.Image = global::BD.WindowsForm.Properties.Resources.alpemix;
            this.pcbAlpemix.Location = new System.Drawing.Point(202, 3);
            this.pcbAlpemix.Name = "pcbAlpemix";
            this.pcbAlpemix.Size = new System.Drawing.Size(194, 51);
            this.pcbAlpemix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAlpemix.TabIndex = 4;
            this.pcbAlpemix.TabStop = false;
            this.pcbAlpemix.Click += new System.EventHandler(this.pcbAlpemix_Click);
            // 
            // pcbAnydesk
            // 
            this.pcbAnydesk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbAnydesk.Image = global::BD.WindowsForm.Properties.Resources.anydesk;
            this.pcbAnydesk.Location = new System.Drawing.Point(402, 3);
            this.pcbAnydesk.Name = "pcbAnydesk";
            this.pcbAnydesk.Size = new System.Drawing.Size(194, 51);
            this.pcbAnydesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAnydesk.TabIndex = 5;
            this.pcbAnydesk.TabStop = false;
            this.pcbAnydesk.Click += new System.EventHandler(this.pcbAnydesk_Click);
            // 
            // Yardim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Yardim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazılım Destek";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTeamviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlpemix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnydesk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTeamviewer;
        private System.Windows.Forms.PictureBox pcbAlpemix;
        private System.Windows.Forms.PictureBox pcbAnydesk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}