namespace BD.WindowsForm
{
    partial class PersonelYonetimi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbEkip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKartID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayrılmışPersonellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifPersonellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekipsizPersonellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kayıtDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmsEkip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekipEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekipDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekipSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.cmsEkip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 495);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtAra);
            this.panel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(308, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 54);
            this.panel5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(342, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(377, 16);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(234, 20);
            this.txtAra.TabIndex = 6;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnKaydet);
            this.panel4.Controls.Add(this.cmbEkip);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtKartID);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtSoyad);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtAd);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 465);
            this.panel4.TabIndex = 21;
            // 
            // cmbEkip
            // 
            this.cmbEkip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEkip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbEkip.FormattingEnabled = true;
            this.cmbEkip.Location = new System.Drawing.Point(12, 193);
            this.cmbEkip.Name = "cmbEkip";
            this.cmbEkip.Size = new System.Drawing.Size(273, 22);
            this.cmbEkip.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ekip Adı:";
            // 
            // txtKartID
            // 
            this.txtKartID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKartID.Location = new System.Drawing.Point(12, 140);
            this.txtKartID.Name = "txtKartID";
            this.txtKartID.Size = new System.Drawing.Size(273, 20);
            this.txtKartID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kart ID:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(12, 86);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(273, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(12, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(273, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Personel Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(308, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 409);
            this.panel1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtDüzenleToolStripMenuItem,
            this.kayıtSilToolStripMenuItem,
            this.ayrılmışPersonellerToolStripMenuItem,
            this.aktifPersonellerToolStripMenuItem,
            this.ekipsizPersonellerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 114);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.kayıtSilToolStripMenuItem.Text = "Kayıt Sil";
            this.kayıtSilToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilToolStripMenuItem_Click);
            // 
            // ayrılmışPersonellerToolStripMenuItem
            // 
            this.ayrılmışPersonellerToolStripMenuItem.Name = "ayrılmışPersonellerToolStripMenuItem";
            this.ayrılmışPersonellerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ayrılmışPersonellerToolStripMenuItem.Text = "Ayrılmış Personeller";
            this.ayrılmışPersonellerToolStripMenuItem.Click += new System.EventHandler(this.ayrılmışPersonellerToolStripMenuItem_Click);
            // 
            // aktifPersonellerToolStripMenuItem
            // 
            this.aktifPersonellerToolStripMenuItem.Name = "aktifPersonellerToolStripMenuItem";
            this.aktifPersonellerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aktifPersonellerToolStripMenuItem.Text = "Aktif Personeller";
            this.aktifPersonellerToolStripMenuItem.Click += new System.EventHandler(this.aktifPersonellerToolStripMenuItem_Click);
            // 
            // ekipsizPersonellerToolStripMenuItem
            // 
            this.ekipsizPersonellerToolStripMenuItem.Name = "ekipsizPersonellerToolStripMenuItem";
            this.ekipsizPersonellerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ekipsizPersonellerToolStripMenuItem.Text = "Ekipsiz Personeller";
            this.ekipsizPersonellerToolStripMenuItem.Click += new System.EventHandler(this.ekipsizPersonellerToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ekip İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.dataGridView2);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(933, 465);
            this.panel8.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.cmsEkip;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(921, 453);
            this.dataGridView2.TabIndex = 1;
            // 
            // kayıtDüzenleToolStripMenuItem
            // 
            this.kayıtDüzenleToolStripMenuItem.Name = "kayıtDüzenleToolStripMenuItem";
            this.kayıtDüzenleToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.kayıtDüzenleToolStripMenuItem.Text = "Kayıt Düzenle";
            this.kayıtDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kayıtDüzenleToolStripMenuItem_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 236);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 48);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmsEkip
            // 
            this.cmsEkip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekipEkleToolStripMenuItem,
            this.ekipDüzenleToolStripMenuItem,
            this.ekipSilToolStripMenuItem});
            this.cmsEkip.Name = "cmsEkip";
            this.cmsEkip.Size = new System.Drawing.Size(142, 70);
            // 
            // ekipEkleToolStripMenuItem
            // 
            this.ekipEkleToolStripMenuItem.Name = "ekipEkleToolStripMenuItem";
            this.ekipEkleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ekipEkleToolStripMenuItem.Text = "Ekip Ekle";
            this.ekipEkleToolStripMenuItem.Click += new System.EventHandler(this.ekipEkleToolStripMenuItem_Click);
            // 
            // ekipDüzenleToolStripMenuItem
            // 
            this.ekipDüzenleToolStripMenuItem.Name = "ekipDüzenleToolStripMenuItem";
            this.ekipDüzenleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ekipDüzenleToolStripMenuItem.Text = "Ekip Düzenle";
            this.ekipDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ekipDüzenleToolStripMenuItem_Click);
            // 
            // ekipSilToolStripMenuItem
            // 
            this.ekipSilToolStripMenuItem.Name = "ekipSilToolStripMenuItem";
            this.ekipSilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ekipSilToolStripMenuItem.Text = "Ekip Sil";
            this.ekipSilToolStripMenuItem.Click += new System.EventHandler(this.ekipSilToolStripMenuItem_Click);
            // 
            // PersonelYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(946, 498);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonelYonetimi";
            this.Text = "PersonelYonetimi";
            this.Load += new System.EventHandler(this.PersonelYonetimi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.cmsEkip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbEkip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKartID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayrılmışPersonellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifPersonellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekipsizPersonellerToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtDüzenleToolStripMenuItem;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ContextMenuStrip cmsEkip;
        private System.Windows.Forms.ToolStripMenuItem ekipEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekipDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekipSilToolStripMenuItem;
    }
}