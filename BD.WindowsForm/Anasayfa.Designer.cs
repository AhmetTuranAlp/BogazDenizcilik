namespace BD.WindowsForm
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elTerminaldenAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operasyonTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorunlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operasyonSayfasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operasyonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elTerminaldenAktarToolStripMenuItem,
            this.operasyonTakipToolStripMenuItem,
            this.rapolarToolStripMenuItem,
            this.personelYönetimiToolStripMenuItem,
            this.sorunlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elTerminaldenAktarToolStripMenuItem
            // 
            this.elTerminaldenAktarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elTerminaldenAktarToolStripMenuItem.Name = "elTerminaldenAktarToolStripMenuItem";
            this.elTerminaldenAktarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.elTerminaldenAktarToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.elTerminaldenAktarToolStripMenuItem.Text = "El Terminalden Aktar";
            this.elTerminaldenAktarToolStripMenuItem.Click += new System.EventHandler(this.elTerminaldenAktarToolStripMenuItem_Click);
            // 
            // operasyonTakipToolStripMenuItem
            // 
            this.operasyonTakipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operasyonSayfasıToolStripMenuItem,
            this.operasyonEkleToolStripMenuItem});
            this.operasyonTakipToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.operasyonTakipToolStripMenuItem.Name = "operasyonTakipToolStripMenuItem";
            this.operasyonTakipToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.operasyonTakipToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.operasyonTakipToolStripMenuItem.Text = "Operasyon Takip";
            // 
            // rapolarToolStripMenuItem
            // 
            this.rapolarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rapolarToolStripMenuItem.Name = "rapolarToolStripMenuItem";
            this.rapolarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.rapolarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.rapolarToolStripMenuItem.Text = "Rapolar";
            this.rapolarToolStripMenuItem.Click += new System.EventHandler(this.rapolarToolStripMenuItem_Click);
            // 
            // personelYönetimiToolStripMenuItem
            // 
            this.personelYönetimiToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelYönetimiToolStripMenuItem.Name = "personelYönetimiToolStripMenuItem";
            this.personelYönetimiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.personelYönetimiToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.personelYönetimiToolStripMenuItem.Text = "Personel Yönetimi";
            this.personelYönetimiToolStripMenuItem.Click += new System.EventHandler(this.personelYönetimiToolStripMenuItem_Click);
            // 
            // sorunlarToolStripMenuItem
            // 
            this.sorunlarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorunlarToolStripMenuItem.Name = "sorunlarToolStripMenuItem";
            this.sorunlarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.sorunlarToolStripMenuItem.Text = "Sorunlar";
            this.sorunlarToolStripMenuItem.Click += new System.EventHandler(this.sorunlarToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // operasyonSayfasıToolStripMenuItem
            // 
            this.operasyonSayfasıToolStripMenuItem.Name = "operasyonSayfasıToolStripMenuItem";
            this.operasyonSayfasıToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.operasyonSayfasıToolStripMenuItem.Text = "Operasyon Sayfası";
            this.operasyonSayfasıToolStripMenuItem.Click += new System.EventHandler(this.operasyonSayfasıToolStripMenuItem_Click);
            // 
            // operasyonEkleToolStripMenuItem
            // 
            this.operasyonEkleToolStripMenuItem.Name = "operasyonEkleToolStripMenuItem";
            this.operasyonEkleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.operasyonEkleToolStripMenuItem.Text = "Operasyon Ekle";
            this.operasyonEkleToolStripMenuItem.Click += new System.EventHandler(this.operasyonEkleToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BD.WindowsForm.Properties.Resources.Arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 467);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Boğaz Denizcilik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elTerminaldenAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operasyonTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorunlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operasyonSayfasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operasyonEkleToolStripMenuItem;
    }
}