﻿using DoAn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    public class CongDanDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        DBConnection dbconnection = new DBConnection();
        public void Them(CongDan cd)
        {
            string sqlStr = string.Format("INSERT INTO CongDan( hoTen , ngayThangNamSinh , gioiTinh , cmnd , danToc , tinhTrangHonNhan , noiDangKiKhaiSinh,queQuan,noiThuongTru,trinhDoHocVan,ngheNghiep)  VALUES ('{0}', '{1}','{2}', '{3}','{4}', '{5}','{6}','{7}','{8}','{9}','{10}')",cd.hoTen,cd.ngayThangNamSinh,cd.gioiTinh,cd.cmnd,cd.danToc,cd.tinhTrangHonNhan,cd.noiDangKiKhaiSinh,cd.queQuan,cd.noiThuongTru,cd.trinhDoHocVan,cd.ngheNghiep);
            dbconnection.XuLy(sqlStr);
        }
        public void Sua(CongDan cd)
        {
            string sqlStr = string.Format("UPDATE CongDan SET  ngayThangNamSinh = '{0}', gioiTinh= '{1}' , cmnd = '{2}', danToc= '{3}', tinhTrangHonNhan='{4}', noiDangKiKhaiSinh= '{5}', queQuan='{6}', noiThuongTru= '{7}', trinhDoHocVan= '{8}', ngheNghiep='{9}' WHERE MaHS = '{10}'",  cd.ngayThangNamSinh, cd.gioiTinh, cd.cmnd, cd.danToc, cd.tinhTrangHonNhan, cd.noiDangKiKhaiSinh, cd.queQuan, cd.noiThuongTru, cd.trinhDoHocVan, cd.ngheNghiep,cd.hoTen);
            dbconnection.XuLy(sqlStr);
        }
        public void Xoa(CongDan cd)
        {
            string sqlStr = string.Format("DELETE FROM CongDan WHERE hoTen = '{0}'", cd.hoTen);
            dbconnection.XuLy(sqlStr);
        }
        public void DanhSach(DataGridView a)
        {
            string sqlStr = string.Format("SELECT *FROM CongDan");
            dbconnection.DanhSach(sqlStr, a);
        }

        public void hihi()
        {
            MessageBox.Show("ok");
        }
    }
}
