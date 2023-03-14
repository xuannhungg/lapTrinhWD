using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    public partial class HonNhanVaGiaDinh : Form
    {
        public HonNhanVaGiaDinh()
        {
            InitializeComponent();
        }

        private void btnDangKyKetHon_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            DangKyKetHon form1 = new DangKyKetHon();
            form1.ShowDialog();
=======
            DangKyKetHon formDKKetHon = new DangKyKetHon();
            formDKKetHon.Show();
>>>>>>> e408a5d496f29d4c6997a4b20c0f0f4f9e81324a
        }

        private void btnDangKyLyHon_Click(object sender, EventArgs e)
        {
            DangKyLyHon form1 = new DangKyLyHon();
            form1.ShowDialog();
        }

<<<<<<< HEAD
        private void HonNhanVaGiaDinh_Load(object sender, EventArgs e)
=======
        private void button3_Click(object sender, EventArgs e)
>>>>>>> e408a5d496f29d4c6997a4b20c0f0f4f9e81324a
        {

        }
    }
}
