namespace BD.WindowsForm
{
    partial class OperasyonEkle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSorunYok = new System.Windows.Forms.CheckBox();
            this.chkDiger = new System.Windows.Forms.CheckBox();
            this.chkElfrenKonum = new System.Windows.Forms.CheckBox();
            this.chkVitesKonum = new System.Windows.Forms.CheckBox();
            this.chkCamAcik = new System.Windows.Forms.CheckBox();
            this.chkAracHasar = new System.Windows.Forms.CheckBox();
            this.chkAnahtarKaybi = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.DTPZaman = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKartID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 280);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnEkle);
            this.panel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(3, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 58);
            this.panel3.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(612, 47);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Operasyon Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkSorunYok);
            this.panel2.Controls.Add(this.chkDiger);
            this.panel2.Controls.Add(this.chkElfrenKonum);
            this.panel2.Controls.Add(this.chkVitesKonum);
            this.panel2.Controls.Add(this.chkCamAcik);
            this.panel2.Controls.Add(this.chkAracHasar);
            this.panel2.Controls.Add(this.chkAnahtarKaybi);
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(3, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 94);
            this.panel2.TabIndex = 8;
            // 
            // chkSorunYok
            // 
            this.chkSorunYok.AutoSize = true;
            this.chkSorunYok.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSorunYok.Location = new System.Drawing.Point(506, 19);
            this.chkSorunYok.Name = "chkSorunYok";
            this.chkSorunYok.Size = new System.Drawing.Size(79, 18);
            this.chkSorunYok.TabIndex = 0;
            this.chkSorunYok.Text = "SorunYok";
            this.chkSorunYok.UseVisualStyleBackColor = true;
            this.chkSorunYok.CheckedChanged += new System.EventHandler(this.chkSorunYok_CheckedChanged);
            // 
            // chkDiger
            // 
            this.chkDiger.AutoSize = true;
            this.chkDiger.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDiger.Location = new System.Drawing.Point(353, 55);
            this.chkDiger.Name = "chkDiger";
            this.chkDiger.Size = new System.Drawing.Size(55, 18);
            this.chkDiger.TabIndex = 0;
            this.chkDiger.Text = "Diger";
            this.chkDiger.UseVisualStyleBackColor = true;
            // 
            // chkElfrenKonum
            // 
            this.chkElfrenKonum.AutoSize = true;
            this.chkElfrenKonum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkElfrenKonum.Location = new System.Drawing.Point(353, 19);
            this.chkElfrenKonum.Name = "chkElfrenKonum";
            this.chkElfrenKonum.Size = new System.Drawing.Size(97, 18);
            this.chkElfrenKonum.TabIndex = 0;
            this.chkElfrenKonum.Text = "ElfrenKonum";
            this.chkElfrenKonum.UseVisualStyleBackColor = true;
            // 
            // chkVitesKonum
            // 
            this.chkVitesKonum.AutoSize = true;
            this.chkVitesKonum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkVitesKonum.Location = new System.Drawing.Point(199, 55);
            this.chkVitesKonum.Name = "chkVitesKonum";
            this.chkVitesKonum.Size = new System.Drawing.Size(94, 18);
            this.chkVitesKonum.TabIndex = 0;
            this.chkVitesKonum.Text = "VitesKonum";
            this.chkVitesKonum.UseVisualStyleBackColor = true;
            // 
            // chkCamAcik
            // 
            this.chkCamAcik.AutoSize = true;
            this.chkCamAcik.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCamAcik.Location = new System.Drawing.Point(199, 19);
            this.chkCamAcik.Name = "chkCamAcik";
            this.chkCamAcik.Size = new System.Drawing.Size(75, 18);
            this.chkCamAcik.TabIndex = 0;
            this.chkCamAcik.Text = "CamAcik";
            this.chkCamAcik.UseVisualStyleBackColor = true;
            // 
            // chkAracHasar
            // 
            this.chkAracHasar.AutoSize = true;
            this.chkAracHasar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAracHasar.Location = new System.Drawing.Point(35, 55);
            this.chkAracHasar.Name = "chkAracHasar";
            this.chkAracHasar.Size = new System.Drawing.Size(82, 18);
            this.chkAracHasar.TabIndex = 0;
            this.chkAracHasar.Text = "AracHasar";
            this.chkAracHasar.UseVisualStyleBackColor = true;
            // 
            // chkAnahtarKaybi
            // 
            this.chkAnahtarKaybi.AutoSize = true;
            this.chkAnahtarKaybi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAnahtarKaybi.Location = new System.Drawing.Point(35, 19);
            this.chkAnahtarKaybi.Name = "chkAnahtarKaybi";
            this.chkAnahtarKaybi.Size = new System.Drawing.Size(98, 18);
            this.chkAnahtarKaybi.TabIndex = 0;
            this.chkAnahtarKaybi.Text = "AnahtarKaybi";
            this.chkAnahtarKaybi.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtBarkod);
            this.panel4.Controls.Add(this.DTPZaman);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbTip);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbKartID);
            this.panel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 112);
            this.panel4.TabIndex = 7;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(80, 17);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(200, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // DTPZaman
            // 
            this.DTPZaman.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPZaman.Location = new System.Drawing.Point(385, 61);
            this.DTPZaman.Name = "DTPZaman";
            this.DTPZaman.Size = new System.Drawing.Size(200, 20);
            this.DTPZaman.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod:";
            // 
            // cmbTip
            // 
            this.cmbTip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Yükleme",
            "Tahliye",
            "Terminal"});
            this.cmbTip.Location = new System.Drawing.Point(80, 62);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(200, 22);
            this.cmbTip.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(332, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Zaman:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tip:";
            // 
            // cmbKartID
            // 
            this.cmbKartID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKartID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbKartID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKartID.FormattingEnabled = true;
            this.cmbKartID.Location = new System.Drawing.Point(385, 17);
            this.cmbKartID.Name = "cmbKartID";
            this.cmbKartID.Size = new System.Drawing.Size(200, 22);
            this.cmbKartID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(334, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kart ID:";
            // 
            // OperasyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 283);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OperasyonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operasyon Ekle";
            this.Load += new System.EventHandler(this.OperasyonEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkSorunYok;
        private System.Windows.Forms.CheckBox chkDiger;
        private System.Windows.Forms.CheckBox chkElfrenKonum;
        private System.Windows.Forms.CheckBox chkVitesKonum;
        private System.Windows.Forms.CheckBox chkCamAcik;
        private System.Windows.Forms.CheckBox chkAracHasar;
        private System.Windows.Forms.CheckBox chkAnahtarKaybi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.DateTimePicker DTPZaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKartID;
    }
}