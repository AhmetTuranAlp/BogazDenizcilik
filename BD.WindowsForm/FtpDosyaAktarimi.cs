using BD.Data;
using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BD.WindowsForm
{
    public partial class FtpDosyaAktarimi : Form
    {
        public FtpDosyaAktarimi()
        {
            InitializeComponent();
        }

        FTPIslemleri ftp = new FTPIslemleri();

        private Image qrCreate(string Data, int qrCode)
        {
            QRCodeEncoder code = new QRCodeEncoder();
            code.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            code.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            code.QRCodeVersion = qrCode;

            Bitmap bt = code.Encode(Data);
            return bt;
        }

        private void FtpDosyaAktarimi_Load(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();

            pictureBox1.Image = qrCreate(ipAdresi, 6);

            if (!Directory.Exists(Application.StartupPath + @"\XmlData"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\XmlData");
            }

        }

        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            ftp.Listeleme();
            ftp.XmlKaydet(progressBar1);

        }
    }
}
