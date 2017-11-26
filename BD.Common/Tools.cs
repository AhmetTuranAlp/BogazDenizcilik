using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Common
{
    public class Tools
    {
        public void DatagridBoyutlandir(DataGridView grid,int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
    }
}
