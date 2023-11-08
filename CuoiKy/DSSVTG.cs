using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy
{
    public partial class DSSVTG : Form
    {
        public DSSVTG()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // 0 là chỉ mục cột STT
            {
                e.Value = e.RowIndex + 1; // Thêm 1 vào chỉ mục hàng để tạo STT bắt đầu từ 1
            }
        }
    }
}
