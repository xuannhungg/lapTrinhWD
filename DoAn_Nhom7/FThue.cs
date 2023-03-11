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

namespace DoAn_Nhom7
{
    public partial class FThue : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conStr);
        ThueDAO thueDao = new ThueDAO();
        public FThue()
        {
            InitializeComponent();
        }

        private void FThue_Load(object sender, EventArgs e)
        {
            LayDanhSach();
        }
        public void LayDanhSach()
        {
            this.dGVThue.DataSource = thueDao.DanhSach();
        }
    }
}
