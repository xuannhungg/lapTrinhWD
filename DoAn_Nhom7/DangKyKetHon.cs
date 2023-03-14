using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    public partial class DangKyKetHon : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        CongDanDAO cddao = new CongDanDAO();
        public DangKyKetHon()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CongDan cdA = new CongDan(txtGiayToTuyThanNam.Text);
            cddao.CapNhatKetHon(cdA);
            CongDan cdB = new CongDan(txtGiayToTuyThanNu.Text);
            cddao.CapNhatKetHon(cdB);
        }

        private void txtGiayToTuyThanNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn.Open();
                string sqlStr = "Select * from CongDan where cmnd = '" + txtGiayToTuyThanNam.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                while (dta.Read())
                {
                    txtHoTenNam.Text = Convert.ToString(dta["hoTen"]);
                    txtNgaySinhNam.Text = Convert.ToString(dta["ngayThangNamSinh"]); ;
                    txtDanTocNam.Text = Convert.ToString(dta["danToc"]);
                    txtQuocTichNam.Text = Convert.ToString(dta["queQuan"]);
                    txtNoiCuTruNam.Text = Convert.ToString(dta["noiThuongTru"]);
                }
                conn.Close();
            }
        }

        private void txtGiayToTuyThanNu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn.Open();
                string sqlStr = "Select * from CongDan where cmnd = '" + txtGiayToTuyThanNu.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                while (dta.Read())
                {
                    txtHoTenNu.Text = Convert.ToString(dta["hoTen"]);
                    txtNgaySinhNu.Text = Convert.ToString(dta["ngayThangNamSinh"]); ;
                    txtDanTocNu.Text = Convert.ToString(dta["danToc"]);
                    txtQuocTichNu.Text = Convert.ToString(dta["queQuan"]);
                    txtNoiCuTruNu.Text = Convert.ToString(dta["noiThuongTru"]);
                }
                conn.Close();
            }
        }
    }
}
