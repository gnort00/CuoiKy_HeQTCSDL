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
    public partial class QuanLyChuongTrinh : Form
    {
        public QuanLyChuongTrinh()
        {
            InitializeComponent();
        }
        private SqlCommand command;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DBMS_SV5T_K;User ID=sa;Password=ldtrong0");
        private void KetNoiCSDL()
        {
            conn.Open();
            string sql = "Select MaCT,TenCT,TrangThai From CHUONGTRINH";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dg_QLCT.DataSource = dt;
        }

        private void QuanLyChuongTrinh_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }
    }
}
