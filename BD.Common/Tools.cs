using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace BD.Common
{
    public class Tools
    {
        public void DatagridBoyutlandir(DataGridView grid, int sayi)
        {
            try
            {
                for (int i = 0; i < sayi; i++)
                {
                    grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void HataliOperasyonKayitlari(DataGridView grid)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (grid.Rows[i].Cells["SorunYok"].Value.ToString() == "False")
                {
                    renk.BackColor = Color.Red;
                }
                grid.Rows[i].DefaultCellStyle = renk;
            }
        }

        public void SorunFiltre(DataGridView izgara, int index, ToolStripMenuItem menu)
        {
            try
            {
                if (menu.Checked == true)
                {
                    izgara.Columns[index].Visible = false;
                }
                else if (menu.Checked == false)
                {
                    izgara.Columns[index].Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void pdfKaydet(DataGridView veriTablosu, string deger, DateTime tarih, System.Drawing.Image resim)
        {
            try
            {
                PdfPTable pdfTablosu = new PdfPTable(veriTablosu.ColumnCount);
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(resim, BaseColor.WHITE);
                img.ScalePercent(10, 10);
                img.SetAbsolutePosition(50, 750);
                pdfTablosu.AddCell(new PdfPCell(new Phrase(tarih.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, 1))) { Colspan = 16, Border = 0, PaddingTop = 10, HorizontalAlignment = Element.ALIGN_RIGHT });
                pdfTablosu.AddCell(new PdfPCell(new Phrase(deger, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, 1))) { Colspan = 16, Border = 0, PaddingBottom = 30, HorizontalAlignment = Element.ALIGN_RIGHT });


                iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 8, iTextSharp.text.Font.NORMAL);

                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTablosu.DefaultCell.BorderWidth = 1;



                foreach (DataGridViewColumn sutun in veriTablosu.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, fontNormal));
                    pdfHucresi.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTablosu.AddCell(pdfHucresi);
                }

                foreach (DataGridViewRow satir in veriTablosu.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), fontNormal));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "projePDfDosyaAdı";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 50, 50, 50, 50);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(img);

                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }
    }
}
