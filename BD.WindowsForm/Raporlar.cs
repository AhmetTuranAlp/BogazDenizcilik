using BD.Common;
using BD.Data;
using BD.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.WindowsForm
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        OperasyonIslemleri operasyon = new OperasyonIslemleri();
        Tools arac = new Tools();
        PersonelIslemleri personel = new PersonelIslemleri();
        EkipIslemleri ekip = new EkipIslemleri();
        SorunKontrolIslemleri sorun = new SorunKontrolIslemleri();

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operasyon.TableListe("spOperasyonListe");
            arac.DatagridBoyutlandir(dataGridView1, 16);
            arac.HataliOperasyonKayitlari(dataGridView1);
            lblToplamKayit.Text = "Operasyon Adet: " + (dataGridView1.RowCount - 1);
        }

        public void TwoDtp()
        {
            lblPersonelCalisma.Visible = false;
            dtpCalismaTarih.Visible = false;

            lblBaslangic.Visible = true;
            dtpBaslangic.Visible = true;

            lblBitis.Visible = true;
            dtpBitis.Visible = true;
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTur.SelectedItem.ToString() == "Personel Raporu")
            {
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                cmbSecimIcerik.Items.Add("Genel Rapor");
                var perso = personel.PersonelListe();
                foreach (var per in perso)
                {
                    cmbSecimIcerik.Items.Add(per.Adi + " " + per.Soyad);
                }
                AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
                foreach (var item in perso)
                {
                    veri.Add(item.Adi + " " + item.Soyad);
                }
                cmbSecimIcerik.AutoCompleteCustomSource = veri;
            }
            else if (cmbTur.SelectedItem.ToString() == "Operasyon Raporu")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                cmbSecimIcerik.AutoCompleteCustomSource = null;
                cmbSecimIcerik.Items.Add("Yükleme");
                cmbSecimIcerik.Items.Add("Tahliye");
                cmbSecimIcerik.Items.Add("Terminal");
            }
            else if (cmbTur.SelectedItem.ToString() == "Performans(Personel)")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                var perso = personel.PersonelListe();
                cmbSecimIcerik.Items.Add("Genel Performans");
                foreach (var per in perso)
                {
                    cmbSecimIcerik.Items.Add(per.Adi + " " + per.Soyad);
                }
                AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
                foreach (var item in perso)
                {
                    veri.Add(item.Adi + " " + item.Soyad);
                }
                cmbSecimIcerik.AutoCompleteCustomSource = veri;
            }
            else if (cmbTur.SelectedItem.ToString() == "Performans(Ekip)")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = true;
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Items.Clear();
                var ek = ekip.Listeleme();
                cmbSecimIcerik.Items.Add("Genel Performans");
                foreach (var item in ek)
                {
                    cmbSecimIcerik.Items.Add(item.EkipAdi);
                }
                AutoCompleteStringCollection veriEkip = new AutoCompleteStringCollection();
                foreach (var item in ek)
                {
                    veriEkip.Add(item.EkipAdi);
                }
                cmbSecimIcerik.AutoCompleteCustomSource = veriEkip;
            }
            else if (cmbTur.SelectedItem.ToString() == "Operasyon Sorun Raporu")
            {
                TwoDtp();
                cmbSecimIcerik.Enabled = false;
            }
        }

        private void cmbSecimIcerik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTur.SelectedItem.ToString() == "Personel Raporu")
                {
                    if (cmbSecimIcerik.SelectedItem.ToString() == "Genel Rapor")
                    {
                        TwoDtp();
                    }
                    else
                    {
                        lblPersonelCalisma.Visible = true;
                        dtpCalismaTarih.Visible = true;

                        lblBaslangic.Visible = false;
                        dtpBaslangic.Visible = false;

                        lblBitis.Visible = false;
                        dtpBitis.Visible = false;

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var liste = operasyon.Listeleme();
            var baslangic = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpBaslangic.Value));
            var bitis = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 23:59:59}", dtpBitis.Value));
            List<DTO.OperasyonModelViewDTO> lst = new List<DTO.OperasyonModelViewDTO>();
            try
            {
                sorunFiltrelemeToolStripMenuItem.Enabled = true;
                if (cmbTur.SelectedItem.ToString() == "Personel Raporu")
                {
                    if (cmbSecimIcerik.SelectedItem.ToString() == "Genel Rapor")
                    {
                        DataView dv = operasyon.TableListe("spOperasyonListe").DefaultView;
                        dv.RowFilter = string.Format("Zaman >= '{0}' AND Zaman <= '{1}'", baslangic, bitis);
                        dataGridView1.DataSource = dv;
                        arac.DatagridBoyutlandir(dataGridView1, 16);
                        arac.HataliOperasyonKayitlari(dataGridView1);
                    }
                    else
                    {
                        if (cmbSecimIcerik.SelectedItem != null)
                        {
                            var CalismaBas = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 00:00:00}", dtpCalismaTarih.Value));
                            var CalismaBit = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy 23:59:59}", dtpCalismaTarih.Value));
                            DataView dv = operasyon.TableListe("spOperasyonListe").DefaultView;
                            dv.RowFilter = string.Format("Zaman >= '{0}' AND Zaman <= '{1}' AND Adi +' '+ Soyad ='{2}'", CalismaBas, CalismaBit, cmbSecimIcerik.SelectedItem.ToString());

                            int dvListe = dv.Count;
                            dataGridView1.DataSource = dv;
                            arac.DatagridBoyutlandir(dataGridView1, 16);
                            arac.HataliOperasyonKayitlari(dataGridView1);

                            PersonelIslemleri personelIslemleri = new PersonelIslemleri();
                            string perEkip = personelIslemleri.PersonelEkipAdi(cmbSecimIcerik.SelectedItem.ToString());
                            DataView couuntDV = operasyon.TableListe("spOperasyonListe").DefaultView;
                            couuntDV.RowFilter = string.Format("Zaman >= '{0}' AND Zaman <= '{1}' AND EkipAdi ='{2}'", CalismaBas, CalismaBit, perEkip);
                            int ekipCalisma = couuntDV.Count;
                            
                            if (dvListe == 0 && ekipCalisma > 0)
                            {
                                MessageBox.Show("Bu tarihde ekip elemanları çalışmış olup " + cmbSecimIcerik.SelectedItem.ToString() + " adlı personel calışmamıştır.");
                            }
                            else if (dvListe == 0 && ekipCalisma == 0)
                            {
                                MessageBox.Show("Bu tarihde tüm ekip elemanları çalışmamıştır.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Tüm kriterleri girmeniz gerekiyor.");
                        }
                    }
                }
                else if (cmbTur.SelectedItem.ToString() == "Operasyon Raporu")
                {

                    DataView dv = operasyon.TableListe("spOperasyonListe").DefaultView;
                    dv.RowFilter = string.Format("Zaman >= '{0}' AND Zaman <= '{1}' AND Tip = '{2}'", baslangic, bitis, cmbSecimIcerik.SelectedItem.ToString());
                    dataGridView1.DataSource = dv;
                    arac.DatagridBoyutlandir(dataGridView1, 16);
                    arac.HataliOperasyonKayitlari(dataGridView1);
                }
                else if (cmbTur.SelectedItem.ToString() == "Performans(Personel)")
                {
                    sorunFiltrelemeToolStripMenuItem.Enabled = false;
                    if (cmbSecimIcerik.SelectedItem.ToString() == "Genel Performans")
                    {
                        lst.Clear();
                        foreach (var item in liste)
                        {
                            if (Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) >= baslangic && Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) <= bitis)
                            {
                                lst.Add(item);
                            }
                        }

                        dataGridView1.DataSource = lst.GroupBy(x => new { x.Adi, x.Soyad }).Select(x => new { Toplam = x.Count(), x.Key.Adi, x.Key.Soyad }).OrderByDescending(x => x.Toplam).ToList();
                        for (int i = 0; i < 3; i++)
                        {
                            dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        int yuk = 0;
                        int ter = 0;
                        int tah = 0;
                        lst.Clear();
                        foreach (var item in liste)
                        {
                            if (Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) >= baslangic && Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) <= bitis)
                            {
                                if (item.Adi + " " + item.Soyad == cmbSecimIcerik.SelectedItem.ToString())
                                {
                                    lst.Add(item);
                                    if (item.Tip == "Yükleme")
                                        yuk++;
                                    else if (item.Tip == "Terminal")
                                        ter++;
                                    else if (item.Tip == "Tahliye")
                                        tah++;
                                }
                            }
                        }
                        dataGridView1.DataSource = lst.GroupBy(x => new { x.Adi, x.Soyad }).Select(y => new { y.Key.Adi, y.Key.Soyad, Yükleme = yuk, Tahliye = tah, Terminal = ter }).ToList();
                    }

                }
                else if (cmbTur.SelectedItem.ToString() == "Performans(Ekip)")
                {
                    lst.Clear();
                    if (cmbSecimIcerik.SelectedItem.ToString() == "Genel Performans")
                    {
                        foreach (var item in liste)
                        {
                            if (Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) >= baslangic && Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) <= bitis)
                            {
                                lst.Add(item);
                            }
                        }

                        dataGridView1.DataSource = lst.GroupBy(x => new { x.EkipAdi }).Select(y => new { y.Key.EkipAdi, Toplam = y.Count() }).ToList();
                        for (int i = 0; i < 2; i++)
                        {
                            dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    else
                    {
                        int yuk = 0;
                        int ter = 0;
                        int tah = 0;
                        lst.Clear();
                        foreach (var item in liste)
                        {
                            if (Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) >= baslangic && Convert.ToDateTime(string.Format("{0: dd/MM/yyyy HH:mm:ss}", item.Zaman.Value)) <= bitis)
                            {
                                if (item.EkipAdi == cmbSecimIcerik.SelectedItem.ToString())
                                {
                                    lst.Add(item);
                                    if (item.Tip == "Yükleme")
                                        yuk++;
                                    else if (item.Tip == "Terminal")
                                        ter++;
                                    else if (item.Tip == "Tahliye")
                                        tah++;
                                }
                            }
                        }
                        dataGridView1.DataSource = lst.GroupBy(x => new { x.EkipAdi }).Select(y => new { y.Key.EkipAdi, Yükleme = yuk, Tahliye = tah, Terminal = ter }).ToList();
                        for (int i = 0; i < 4; i++)
                        {
                            dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }

                }
                else if (cmbTur.SelectedItem.ToString() == "Operasyon Sorun Raporu")
                {
                    dataGridView1.DataSource = sorun.SorunluKayitlarListeleme();
                    arac.DatagridBoyutlandir(dataGridView1, 6);
                }
                cmbTur.Text = "";
                cmbSecimIcerik.Text = "";
                cmbSecimIcerik.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm kriterleri girmeniz gerekiyor.");
            }

            lblToplamKayit.Text = "Operasyon Adet: " + (dataGridView1.RowCount - 1);
        }

        //Yazdırma İşlemi Başlangıç------------------------------------------------------------
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.PrintPreviewControl.Zoom = 0.8;

            ToolStripButton btnYazdir = new ToolStripButton("Yazdır");
            btnYazdir.Click += btnYazdir_Click;
            ((ToolStrip)onizleme.Controls[1]).Items.Insert(0, btnYazdir);
            ((ToolStrip)onizleme.Controls[1]).Items.RemoveAt(1);

            ((Form)onizleme).WindowState = FormWindowState.Maximized;
            onizleme.ShowDialog();
        }

        void btnYazdir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        if (GridCol.Visible == true)
                        {
                            iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                              (double)iTotalWidth * (double)iTotalWidth *
                              ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                            iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                        GridCol.InheritedStyle.Font, iTmpWidth).Height) + 20;
                            GridCol.DefaultCellStyle.Font = new Font("Arial", 10F, GraphicsUnit.Pixel);

                            arrColumnLefts.Add(iLeftMargin);
                            arrColumnWidths.Add(iTmpWidth);
                            iLeftMargin += iTmpWidth;
                        }
                    }
                }

                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];

                    iCellHeight = GridRow.Height + 30;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawImage(Properties.Resources.logo, 100, 70, 200, 70);
                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            String kayitAdet = lblToplamKayit.Text;

                            e.Graphics.DrawString(strDate, new Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(new Font(dataGridView1.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height + 5);

                            e.Graphics.DrawString(kayitAdet, new Font(dataGridView1.Font, FontStyle.Bold),
                                 Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                 e.Graphics.MeasureString(kayitAdet, new Font(dataGridView1.Font,
                                 FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                 e.Graphics.MeasureString("Çıktı Başlığı", new Font(new Font(dataGridView1.Font,
                                 FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height + 35);

                            iTopMargin = e.MarginBounds.Top + 50;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                if (GridCol.Visible == true)
                                {
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                             new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                             (int)arrColumnWidths[iCount], iHeaderHeight));


                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));

                                    e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                    iCount++;
                                }



                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Visible == true)
                            {
                                if (Cel.Value != null)
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }

                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                        iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                                iCount++;
                            }
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    if (dgvGridCol.Visible == true)
                    {
                        iTotalWidth += dgvGridCol.Width;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Yazdırma İşlemi Bitiş------------------------------------------------------------

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string barkod = txtBarkod.Text;
                dataGridView1.DataSource = operasyon.OperasyonAramaListe(barkod);
                arac.HataliOperasyonKayitlari(dataGridView1);
            }
            lblToplamKayit.Text = "Toplam Kayıt: " + dataGridView1.RowCount;
            arac.DatagridBoyutlandir(dataGridView1, 16);
        }

        private void anahtarKaybiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 8, anahtarKaybiToolStripMenuItem);
        }

        private void aracHasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 9, aracHasarToolStripMenuItem);
        }

        private void camAcikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 10, camAcikToolStripMenuItem);
        }

        private void vitesKonumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 11, vitesKonumToolStripMenuItem);
        }

        private void elfrenKonumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 12, elfrenKonumToolStripMenuItem);
        }

        private void digerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 13, digerToolStripMenuItem);
        }

        private void soruncYokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac.SorunFiltre(dataGridView1, 14, soruncYokToolStripMenuItem);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operasyon.TableListe("spOperasyonListe");
            arac.DatagridBoyutlandir(dataGridView1, 16);
            arac.HataliOperasyonKayitlari(dataGridView1);
            lblToplamKayit.Text = "Operasyon Adet: " + dataGridView1.RowCount;
        }


        private void btnPDF_Click(object sender, EventArgs e)
        {
            arac.pdfKaydet(dataGridView1, lblToplamKayit.Text.ToString(), DateTime.Now, Properties.Resources.logo);
        }

        private void btnPDF_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPDF, "PDF Cıktısı AL");
        }

        private void btnYazdır_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnYazdır, "Yazdır");
        }

        private void btnYenile_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnYenile, "Sayfayı Yenile");
        }

        private void btnGetir_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGetir, "Kriterlere göre kayıt getir");
        }

        private void btnTarihAra_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnTarihAra, "Kriterlere göre kayıt getir");
        }

        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            try
            {
                sorunFiltrelemeToolStripMenuItem.Enabled = true;
                var tarih = Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", dtpTarih.Value));
                List<OperasyonModelViewDTO> lstTarih = new List<OperasyonModelViewDTO>();
                var liste = operasyon.Listeleme();
                if (mtbBaslangic.Text.Trim() != ":" && mtbBitis.Text.Trim() != ":")
                {
                    foreach (var item in liste)
                    {
                        if (Convert.ToDateTime(string.Format("{0: dd/MM/yyyy}", item.Zaman.Value)) == tarih)
                        {
                            if (Convert.ToDateTime(string.Format("{0: HH:mm:00}", item.Zaman.Value)) >= Convert.ToDateTime(mtbBaslangic.Text) && Convert.ToDateTime(string.Format("{0: HH:mm:59}", item.Zaman.Value)) <= Convert.ToDateTime(mtbBitis.Text))
                            {
                                lstTarih.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tüm kriterleri girmeniz gerekiyor.");
                }
                dataGridView1.DataSource = lstTarih;
                arac.DatagridBoyutlandir(dataGridView1, 16);
                arac.HataliOperasyonKayitlari(dataGridView1);
                mtbBaslangic.Clear();
                mtbBitis.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Tüm kriterleri girmeniz gerekiyor.");
            }
            lblToplamKayit.Text = "Operasyon Adet: " + dataGridView1.RowCount;
        }

        private void SorunluKayitlariListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = operasyon.SorunluKayitlariListeleme();
            arac.DatagridBoyutlandir(dataGridView1, 16);
            arac.HataliOperasyonKayitlari(dataGridView1);
            lblToplamKayit.Text = "Operasyon Adet: " + dataGridView1.RowCount;
           
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle renk = new DataGridViewCellStyle();
                    if (dataGridView1.Rows[i].Cells["SorunYok"].Value.ToString() == "False")
                    {
                        renk.BackColor = Color.Red;
                    }
                    dataGridView1.Rows[i].DefaultCellStyle = renk;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operasyon.OperasyonAramaListe(txtBarkod.Text.ToString());
            arac.DatagridBoyutlandir(dataGridView1, 16);
            lblToplamKayit.Text = "Toplam Kayıt: " + dataGridView1.RowCount;
        }
    }


}
