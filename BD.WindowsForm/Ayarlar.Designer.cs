namespace BD.WindowsForm
{
    partial class Ayarlar
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgSifreView = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmsBackup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.konumAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pcbBackupLoading = new System.Windows.Forms.PictureBox();
            this.lblBackupLoading = new System.Windows.Forms.Label();
            this.chkGoogleDriveBackup = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.btnBackupKonum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pcbRestoreLoading = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.lblRestoreLoading = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResoreKonum = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSifreView)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.cmsBackup.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackupLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRestoreLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.dtgSifreView);
            this.panel6.Location = new System.Drawing.Point(400, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(536, 465);
            this.panel6.TabIndex = 42;
            // 
            // dtgSifreView
            // 
            this.dtgSifreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSifreView.Location = new System.Drawing.Point(3, 3);
            this.dtgSifreView.Name = "dtgSifreView";
            this.dtgSifreView.Size = new System.Drawing.Size(526, 455);
            this.dtgSifreView.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dataGridView2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(0, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(938, 469);
            this.panel7.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.cmsBackup;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(514, 462);
            this.dataGridView2.TabIndex = 4;
            // 
            // cmsBackup
            // 
            this.cmsBackup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konumAktarToolStripMenuItem});
            this.cmsBackup.Name = "cmsBackup";
            this.cmsBackup.Size = new System.Drawing.Size(145, 26);
            // 
            // konumAktarToolStripMenuItem
            // 
            this.konumAktarToolStripMenuItem.Name = "konumAktarToolStripMenuItem";
            this.konumAktarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.konumAktarToolStripMenuItem.Text = "Konum Aktar";
            this.konumAktarToolStripMenuItem.Click += new System.EventHandler(this.konumAktarToolStripMenuItem_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.tabControl2);
            this.panel8.Location = new System.Drawing.Point(519, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(415, 462);
            this.panel8.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(413, 458);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.pcbBackupLoading);
            this.tabPage4.Controls.Add(this.lblBackupLoading);
            this.tabPage4.Controls.Add(this.chkGoogleDriveBackup);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.btnBackup);
            this.tabPage4.Controls.Add(this.txtBackup);
            this.tabPage4.Controls.Add(this.btnBackupKonum);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(405, 431);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Veritabanı Yedek Alma";
            // 
            // pcbBackupLoading
            // 
            this.pcbBackupLoading.Image = global::BD.WindowsForm.Properties.Resources.source;
            this.pcbBackupLoading.Location = new System.Drawing.Point(143, 276);
            this.pcbBackupLoading.Name = "pcbBackupLoading";
            this.pcbBackupLoading.Size = new System.Drawing.Size(130, 126);
            this.pcbBackupLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBackupLoading.TabIndex = 47;
            this.pcbBackupLoading.TabStop = false;
            this.pcbBackupLoading.Visible = false;
            // 
            // lblBackupLoading
            // 
            this.lblBackupLoading.AutoSize = true;
            this.lblBackupLoading.Location = new System.Drawing.Point(140, 405);
            this.lblBackupLoading.Name = "lblBackupLoading";
            this.lblBackupLoading.Size = new System.Drawing.Size(155, 14);
            this.lblBackupLoading.TabIndex = 46;
            this.lblBackupLoading.Text = "Veritabanı Yedeği Alınıyor...";
            this.lblBackupLoading.Visible = false;
            // 
            // chkGoogleDriveBackup
            // 
            this.chkGoogleDriveBackup.AutoSize = true;
            this.chkGoogleDriveBackup.Checked = true;
            this.chkGoogleDriveBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoogleDriveBackup.Location = new System.Drawing.Point(95, 205);
            this.chkGoogleDriveBackup.Name = "chkGoogleDriveBackup";
            this.chkGoogleDriveBackup.Size = new System.Drawing.Size(130, 18);
            this.chkGoogleDriveBackup.TabIndex = 45;
            this.chkGoogleDriveBackup.Text = "Google Drive Yükle";
            this.chkGoogleDriveBackup.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BD.WindowsForm.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(134, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(307, 231);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(95, 176);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(287, 20);
            this.txtBackup.TabIndex = 3;
            // 
            // btnBackupKonum
            // 
            this.btnBackupKonum.Location = new System.Drawing.Point(307, 202);
            this.btnBackupKonum.Name = "btnBackupKonum";
            this.btnBackupKonum.Size = new System.Drawing.Size(75, 23);
            this.btnBackupKonum.TabIndex = 4;
            this.btnBackupKonum.Text = "Browse";
            this.btnBackupKonum.UseVisualStyleBackColor = true;
            this.btnBackupKonum.Click += new System.EventHandler(this.btnBackupKonum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Location:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.pcbRestoreLoading);
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.btnRestore);
            this.tabPage5.Controls.Add(this.txtRestore);
            this.tabPage5.Controls.Add(this.lblRestoreLoading);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.btnResoreKonum);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(405, 431);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Veritabanı Geri Yükleme";
            // 
            // pcbRestoreLoading
            // 
            this.pcbRestoreLoading.Image = global::BD.WindowsForm.Properties.Resources.source;
            this.pcbRestoreLoading.Location = new System.Drawing.Point(151, 263);
            this.pcbRestoreLoading.Name = "pcbRestoreLoading";
            this.pcbRestoreLoading.Size = new System.Drawing.Size(130, 126);
            this.pcbRestoreLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRestoreLoading.TabIndex = 44;
            this.pcbRestoreLoading.TabStop = false;
            this.pcbRestoreLoading.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BD.WindowsForm.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(134, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(307, 231);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(95, 176);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(287, 20);
            this.txtRestore.TabIndex = 7;
            // 
            // lblRestoreLoading
            // 
            this.lblRestoreLoading.AutoSize = true;
            this.lblRestoreLoading.Location = new System.Drawing.Point(131, 392);
            this.lblRestoreLoading.Name = "lblRestoreLoading";
            this.lblRestoreLoading.Size = new System.Drawing.Size(172, 14);
            this.lblRestoreLoading.TabIndex = 6;
            this.lblRestoreLoading.Text = "Veritabanı Yedeği Yükleniyor...";
            this.lblRestoreLoading.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 14);
            this.label10.TabIndex = 6;
            this.label10.Text = "Location:";
            // 
            // btnResoreKonum
            // 
            this.btnResoreKonum.Location = new System.Drawing.Point(307, 202);
            this.btnResoreKonum.Name = "btnResoreKonum";
            this.btnResoreKonum.Size = new System.Drawing.Size(75, 23);
            this.btnResoreKonum.TabIndex = 8;
            this.btnResoreKonum.Text = "Browse";
            this.btnResoreKonum.UseVisualStyleBackColor = true;
            this.btnResoreKonum.Click += new System.EventHandler(this.btnResoreKonum_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnTemizle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 465);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BD.WindowsForm.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(125, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(105, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(347, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 18);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "...";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Şifre:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Yenile;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(105, 291);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(83, 44);
            this.btnTemizle.TabIndex = 41;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Şifre Tekrarı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::BD.WindowsForm.Properties.Resources.SifreUpdate;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(249, 291);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 44);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(105, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şifre İşlemeleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Veritabanı Yedek İşlemleri";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 497);
            this.tabControl1.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 497);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSifreView)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.cmsBackup.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackupLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRestoreLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgSifreView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Button btnBackupKonum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnResoreKonum;
        private System.Windows.Forms.ContextMenuStrip cmsBackup;
        private System.Windows.Forms.ToolStripMenuItem konumAktarToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkGoogleDriveBackup;
        private System.Windows.Forms.PictureBox pcbRestoreLoading;
        private System.Windows.Forms.Label lblBackupLoading;
        private System.Windows.Forms.Label lblRestoreLoading;
        private System.Windows.Forms.PictureBox pcbBackupLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}