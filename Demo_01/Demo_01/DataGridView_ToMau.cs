using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_01
{
    public partial class DataGridView_ToMau : DataGridView
    {
        public DataGridView_ToMau()
        {
            InitializeComponent();
        }
        private void DataGridView_ToMau_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else
            {
                e.CellStyle.BackColor = Color.Blue;
            }
        }
    }
}
