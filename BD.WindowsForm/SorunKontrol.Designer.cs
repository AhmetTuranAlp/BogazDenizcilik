namespace BD.WindowsForm
{
    partial class SorunKontrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barkodAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnArac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barkodAktarToolStripMenuItem
            // 
            this.barkodAktarToolStripMenuItem.Name = "barkodAktarToolStripMenuItem";
            this.barkodAktarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.barkodAktarToolStripMenuItem.Text = "Barkod Aktar";
            this.barkodAktarToolStripMenuItem.Click += new System.EventHandler(this.barkodAktarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barkodAktarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barkod:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Yenile;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Location = new System.Drawing.Point(865, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(53, 43);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnArac
            // 
            this.btnArac.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Operasyon_Ara;
            this.btnArac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArac.Location = new System.Drawing.Point(806, 4);
            this.btnArac.Name = "btnArac";
            this.btnArac.Size = new System.Drawing.Size(53, 43);
            this.btnArac.TabIndex = 8;
            this.btnArac.UseVisualStyleBackColor = true;
            this.btnArac.Click += new System.EventHandler(this.btnArac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(477, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblToplamKayit);
            this.panel5.Controls.Add(this.btnTemizle);
            this.panel5.Controls.Add(this.btnArac);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtAra);
            this.panel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(305, 460);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(925, 54);
            this.panel5.TabIndex = 34;
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKayit.Location = new System.Drawing.Point(16, 21);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(84, 13);
            this.lblToplamKayit.TabIndex = 10;
            this.lblToplamKayit.Text = "Toplam Kayıt:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(534, 18);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 20);
            this.txtAra.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cmbPersonel);
            this.panel4.Controls.Add(this.btnEkle);
            this.panel4.Controls.Add(this.txtAciklama);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtBarkod);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 512);
            this.panel4.TabIndex = 32;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(8, 77);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(282, 22);
            this.cmbPersonel.TabIndex = 29;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(8, 135);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(282, 315);
            this.txtAciklama.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Acıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Adı:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(8, 25);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(282, 20);
            this.txtBarkod.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(305, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 456);
            this.panel1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(918, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnEkle.BackgroundImage = global::BD.WindowsForm.Properties.Resources.SorunAdd;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(8, 456);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(282, 50);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // SorunKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 516);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SorunKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SorunKontrol";
            this.Load += new System.EventHandler(this.SorunKontrol_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ToolStripMenuItem barkodAktarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnArac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}