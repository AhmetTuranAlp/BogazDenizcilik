using System;
using System.Collections.Generic;
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
    }
}
