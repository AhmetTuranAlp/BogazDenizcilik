namespace BD.WindowsForm
{
    partial class Raporlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTarihAra = new System.Windows.Forms.Button();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpCalismaTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblPersonelCalisma = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cmbSecimIcerik = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sorunFiltrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anahtarKaybiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracHasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camAcikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitesKonumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elfrenKonumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruncYokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SorunluKayitlariListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYenile
            // 
            this.btnYenile.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Yenile;
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Location = new System.Drawing.Point(904, 2);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(61, 41);
            this.btnYenile.TabIndex = 13;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            this.btnYenile.MouseHover += new System.EventHandler(this.btnYenile_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rapor Türü:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 591);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTarihAra);
            this.groupBox3.Controls.Add(this.mtbBitis);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtpTarih);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mtbBaslangic);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(3, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 140);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saat Bazlı Rapor";
            // 
            // btnTarihAra
            // 
            this.btnTarihAra.BackgroundImage = global::BD.WindowsForm.Properties.Resources.saarArama;
            this.btnTarihAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTarihAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTarihAra.Location = new System.Drawing.Point(177, 76);
            this.btnTarihAra.Name = "btnTarihAra";
            this.btnTarihAra.Size = new System.Drawing.Size(48, 46);
            this.btnTarihAra.TabIndex = 9;
            this.btnTarihAra.UseVisualStyleBackColor = true;
            this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
            this.btnTarihAra.MouseHover += new System.EventHandler(this.btnTarihAra_MouseHover);
            // 
            // mtbBitis
            // 
            this.mtbBitis.Location = new System.Drawing.Point(117, 102);
            this.mtbBitis.Mask = "00:00";
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(47, 20);
            this.mtbBitis.TabIndex = 8;
            this.mtbBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbBitis.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "";
            this.dtpTarih.Location = new System.Drawing.Point(19, 42);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(206, 20);
            this.dtpTarih.TabIndex = 6;
            this.dtpTarih.Value = new System.DateTime(2017, 10, 19, 11, 8, 23, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bitiş Saati:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Başlangıç Saati:";
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.Location = new System.Drawing.Point(117, 76);
            this.mtbBaslangic.Mask = "00:00";
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(47, 20);
            this.mtbBaslangic.TabIndex = 7;
            this.mtbBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBarkod);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 507);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 80);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barkod İle Rapor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Barkod:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(19, 42);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(206, 20);
            this.txtBarkod.TabIndex = 10;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpCalismaTarih);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.lblBaslangic);
            this.groupBox1.Controls.Add(this.lblPersonelCalisma);
            this.groupBox1.Controls.Add(this.lblBitis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.cmbSecimIcerik);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 353);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Raporlar";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(20, 194);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(206, 20);
            this.dtpBitis.TabIndex = 4;
            // 
            // dtpCalismaTarih
            // 
            this.dtpCalismaTarih.CustomFormat = "";
            this.dtpCalismaTarih.Location = new System.Drawing.Point(20, 140);
            this.dtpCalismaTarih.Name = "dtpCalismaTarih";
            this.dtpCalismaTarih.Size = new System.Drawing.Size(206, 20);
            this.dtpCalismaTarih.TabIndex = 3;
            this.dtpCalismaTarih.Value = new System.DateTime(2017, 10, 19, 11, 8, 23, 0);
            this.dtpCalismaTarih.Visible = false;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "";
            this.dtpBaslangic.Location = new System.Drawing.Point(20, 140);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(206, 20);
            this.dtpBaslangic.TabIndex = 1;
            this.dtpBaslangic.Value = new System.DateTime(2017, 10, 19, 11, 8, 23, 0);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(17, 124);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(95, 14);
            this.lblBaslangic.TabIndex = 10;
            this.lblBaslangic.Text = "Başlangıç Tarihi:";
            // 
            // lblPersonelCalisma
            // 
            this.lblPersonelCalisma.AutoSize = true;
            this.lblPersonelCalisma.Location = new System.Drawing.Point(17, 124);
            this.lblPersonelCalisma.Name = "lblPersonelCalisma";
            this.lblPersonelCalisma.Size = new System.Drawing.Size(37, 14);
            this.lblPersonelCalisma.TabIndex = 12;
            this.lblPersonelCalisma.Text = "Tarih:";
            this.lblPersonelCalisma.Visible = false;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(17, 178);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(67, 14);
            this.lblBitis.TabIndex = 11;
            this.lblBitis.Text = "Bitiş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alt Tür:";
            // 
            // btnGetir
            // 
            this.btnGetir.BackgroundImage = global::BD.WindowsForm.Properties.Resources.search;
            this.btnGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetir.Location = new System.Drawing.Point(91, 248);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(48, 49);
            this.btnGetir.TabIndex = 5;
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            this.btnGetir.MouseHover += new System.EventHandler(this.btnGetir_MouseHover);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Personel Raporu",
            "Operasyon Raporu",
            "Operasyon Sorun Raporu",
            "Performans(Personel)",
            "Performans(Ekip)"});
            this.cmbTur.Location = new System.Drawing.Point(20, 43);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(206, 22);
            this.cmbTur.TabIndex = 1;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // cmbSecimIcerik
            // 
            this.cmbSecimIcerik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSecimIcerik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSecimIcerik.Enabled = false;
            this.cmbSecimIcerik.FormattingEnabled = true;
            this.cmbSecimIcerik.Location = new System.Drawing.Point(20, 89);
            this.cmbSecimIcerik.Name = "cmbSecimIcerik";
            this.cmbSecimIcerik.Size = new System.Drawing.Size(206, 22);
            this.cmbSecimIcerik.TabIndex = 2;
            this.cmbSecimIcerik.SelectedIndexChanged += new System.EventHandler(this.cmbSecimIcerik_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(258, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 539);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowMerge = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorunFiltrelemeToolStripMenuItem,
            this.SorunluKayitlariListeleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 48);
            // 
            // sorunFiltrelemeToolStripMenuItem
            // 
            this.sorunFiltrelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anahtarKaybiToolStripMenuItem,
            this.aracHasarToolStripMenuItem,
            this.camAcikToolStripMenuItem,
            this.vitesKonumToolStripMenuItem,
            this.elfrenKonumToolStripMenuItem,
            this.digerToolStripMenuItem,
            this.soruncYokToolStripMenuItem});
            this.sorunFiltrelemeToolStripMenuItem.Name = "sorunFiltrelemeToolStripMenuItem";
            this.sorunFiltrelemeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sorunFiltrelemeToolStripMenuItem.Text = "Sorun Filtreleme";
            // 
            // anahtarKaybiToolStripMenuItem
            // 
            this.anahtarKaybiToolStripMenuItem.CheckOnClick = true;
            this.anahtarKaybiToolStripMenuItem.Name = "anahtarKaybiToolStripMenuItem";
            this.anahtarKaybiToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.anahtarKaybiToolStripMenuItem.Text = "Anahtar Kaybi";
            this.anahtarKaybiToolStripMenuItem.Click += new System.EventHandler(this.anahtarKaybiToolStripMenuItem_Click);
            // 
            // aracHasarToolStripMenuItem
            // 
            this.aracHasarToolStripMenuItem.CheckOnClick = true;
            this.aracHasarToolStripMenuItem.Name = "aracHasarToolStripMenuItem";
            this.aracHasarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aracHasarToolStripMenuItem.Text = "Arac Hasar";
            this.aracHasarToolStripMenuItem.Click += new System.EventHandler(this.aracHasarToolStripMenuItem_Click);
            // 
            // camAcikToolStripMenuItem
            // 
            this.camAcikToolStripMenuItem.CheckOnClick = true;
            this.camAcikToolStripMenuItem.Name = "camAcikToolStripMenuItem";
            this.camAcikToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.camAcikToolStripMenuItem.Text = "Cam Acik";
            this.camAcikToolStripMenuItem.Click += new System.EventHandler(this.camAcikToolStripMenuItem_Click);
            // 
            // vitesKonumToolStripMenuItem
            // 
            this.vitesKonumToolStripMenuItem.CheckOnClick = true;
            this.vitesKonumToolStripMenuItem.Name = "vitesKonumToolStripMenuItem";
            this.vitesKonumToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vitesKonumToolStripMenuItem.Text = "Vites Konum";
            this.vitesKonumToolStripMenuItem.Click += new System.EventHandler(this.vitesKonumToolStripMenuItem_Click);
            // 
            // elfrenKonumToolStripMenuItem
            // 
            this.elfrenKonumToolStripMenuItem.CheckOnClick = true;
            this.elfrenKonumToolStripMenuItem.Name = "elfrenKonumToolStripMenuItem";
            this.elfrenKonumToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.elfrenKonumToolStripMenuItem.Text = "Elfren Konum";
            this.elfrenKonumToolStripMenuItem.Click += new System.EventHandler(this.elfrenKonumToolStripMenuItem_Click);
            // 
            // digerToolStripMenuItem
            // 
            this.digerToolStripMenuItem.CheckOnClick = true;
            this.digerToolStripMenuItem.Name = "digerToolStripMenuItem";
            this.digerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.digerToolStripMenuItem.Text = "Diger";
            this.digerToolStripMenuItem.Click += new System.EventHandler(this.digerToolStripMenuItem_Click);
            // 
            // soruncYokToolStripMenuItem
            // 
            this.soruncYokToolStripMenuItem.CheckOnClick = true;
            this.soruncYokToolStripMenuItem.Name = "soruncYokToolStripMenuItem";
            this.soruncYokToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.soruncYokToolStripMenuItem.Text = "SorunYok";
            this.soruncYokToolStripMenuItem.Click += new System.EventHandler(this.soruncYokToolStripMenuItem_Click);
            // 
            // SorunluKayitlariListeleToolStripMenuItem
            // 
            this.SorunluKayitlariListeleToolStripMenuItem.Name = "SorunluKayitlariListeleToolStripMenuItem";
            this.SorunluKayitlariListeleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.SorunluKayitlariListeleToolStripMenuItem.Text = "Sorunlu Kayıtları Listele";
            this.SorunluKayitlariListeleToolStripMenuItem.Click += new System.EventHandler(this.SorunluKayitlariListeleToolStripMenuItem_Click);
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToplamKayit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKayit.Location = new System.Drawing.Point(24, 17);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(79, 14);
            this.lblToplamKayit.TabIndex = 14;
            this.lblToplamKayit.Text = "Toplam Kayıt:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnYenile);
            this.panel3.Controls.Add(this.btnYazdır);
            this.panel3.Controls.Add(this.btnPDF);
            this.panel3.Controls.Add(this.lblToplamKayit);
            this.panel3.Location = new System.Drawing.Point(258, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 48);
            this.panel3.TabIndex = 8;
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Print;
            this.btnYazdır.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdır.Location = new System.Drawing.Point(837, 2);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(61, 41);
            this.btnYazdır.TabIndex = 12;
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            this.btnYazdır.MouseHover += new System.EventHandler(this.btnYazdır_MouseHover);
            // 
            // btnPDF
            // 
            this.btnPDF.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Pdf;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(770, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(61, 41);
            this.btnPDF.TabIndex = 11;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            this.btnPDF.MouseHover += new System.EventHandler(this.btnPDF_MouseHover);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTarihAra;
        private System.Windows.Forms.MaskedTextBox mtbBitis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbBaslangic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpCalismaTarih;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblPersonelCalisma;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.ComboBox cmbSecimIcerik;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sorunFiltrelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anahtarKaybiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracHasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camAcikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitesKonumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elfrenKonumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruncYokToolStripMenuItem;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.ToolStripMenuItem SorunluKayitlariListeleToolStripMenuItem;
    }
}