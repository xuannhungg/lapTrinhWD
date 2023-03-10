using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{

    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        CongDanDAO congdandao = new CongDanDAO();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CCCD form2 = new CCCD();
            form2.Show();
        }

 
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DangNhap form3 = new DangNhap();
            form3.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM CongDan");
                SqlCommand command = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet set = new DataSet();
                adapter.Fill(set);
                dGVDanhSach.DataSource = set.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap formdn = new DangNhap();
            formdn.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKi formdk = new DangKi();
            formdk.ShowDialog();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CongDan WHERE hoTen LIKE N'%" + txtCCCD.Text + "%'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "hoTen");
            if (ds.Tables["hoTen"].Rows.Count > 0)
            {
                dGVDanhSach.DataSource = ds.Tables["hoTen"];
            }
            else
            {
                MessageBox.Show("Không tìm thấy ai có họ tên này!");
                txtCCCD.Text = "";
            }
            conn.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CCCD form1 = new CCCD();
            form1.ShowDialog();
        }

        public void LoadData()
        {
            congdandao.DanhSach(dGVDanhSach);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            CCCD formCCCD = new CCCD();
            formCCCD.Show();
        }

    }
}
