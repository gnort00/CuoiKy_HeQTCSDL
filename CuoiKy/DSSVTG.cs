using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuoiKy
{
    public partial class DSSVTG : Form
    {
        public DSSVTG()
        {
            InitializeComponent();
        }

        private SqlCommand command;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DBMS_SV5T_K;User ID=sa;Password=ldtrong0");
        private void KetNoiCSDL()
        {
            conn.Open();
            string sql = "select HoTen,SINHVIEN.MaSV,TrangThai from SINHVIEN inner join THAMGIA On SINHVIEN.MaSV = THAMGIA.MaSV";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dg_DS.DataSource = dt;
        }

        private void DSSVTG_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

        private void dg_DS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // 0 là chỉ mục cột STT
            {
                e.Value = e.RowIndex + 1; // Thêm 1 vào chỉ mục hàng để tạo STT bắt đầu từ 1
            }
        }
    }
}
