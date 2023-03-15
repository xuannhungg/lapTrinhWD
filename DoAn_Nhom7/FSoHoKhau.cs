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
    public partial class FSoHoKhau : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        SoHoKhauDAO hkdao = new SoHoKhauDAO();
        public FSoHoKhau()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SoHoKhau hk = new SoHoKhau(txtMaKhuVuc.Text, txtXaPhuong.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, txtGhiChu.Text, txtMaSoHoKhau.Text, txtHoTenChuHo.Text, txtDiaChi.Text, tpNgayLap.Text);
            hkdao.ThemSoHoKhau(hk);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SoHoKhau hk = new SoHoKhau(txtMaKhuVuc.Text, txtXaPhuong.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, txtGhiChu.Text, txtMaSoHoKhau.Text, txtHoTenChuHo.Text, txtDiaChi.Text, tpNgayLap.Text);
            hkdao.XoaSoHoKhau(hk);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SoHoKhau hk = new SoHoKhau(txtMaKhuVuc.Text, txtXaPhuong.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, txtGhiChu.Text, txtMaSoHoKhau.Text, txtHoTenChuHo.Text, txtDiaChi.Text, tpNgayLap.Text);
            hkdao.SuaSoHoKhau(hk);
        }
    }
}
