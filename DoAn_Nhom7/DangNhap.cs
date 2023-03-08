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
    public partial class DangNhap : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        TaiKhoanDAO tkdao = new TaiKhoanDAO();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
            tkdao.DangNhap(tk);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.ShowDialog();
        }
    }
}
