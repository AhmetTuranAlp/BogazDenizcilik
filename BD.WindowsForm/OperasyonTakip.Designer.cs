namespace BD.WindowsForm
{
    partial class OperasyonTakip
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aramaKutusunaBarkodAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 520);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aramaKutusunaBarkodAktarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 26);
            // 
            // aramaKutusunaBarkodAktarToolStripMenuItem
            // 
            this.aramaKutusunaBarkodAktarToolStripMenuItem.Name = "aramaKutusunaBarkodAktarToolStripMenuItem";
            this.aramaKutusunaBarkodAktarToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.aramaKutusunaBarkodAktarToolStripMenuItem.Text = "Arama Kutusuna Barkod Aktar";
            this.aramaKutusunaBarkodAktarToolStripMenuItem.Click += new System.EventHandler(this.aramaKutusunaBarkodAktarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblToplamKayit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(1, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 52);
            this.panel1.TabIndex = 8;
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKayit.Location = new System.Drawing.Point(10, 17);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(84, 13);
            this.lblToplamKayit.TabIndex = 5;
            this.lblToplamKayit.Text = "Toplam Kayıt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(720, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(777, 17);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 20);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // OperasyonTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OperasyonTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operasyon Takip";
            this.Load += new System.EventHandler(this.OperasyonTakip_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aramaKutusunaBarkodAktarToolStripMenuItem;
    }
}