using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DoAn_Nhom7
{
    internal class SoHoKhau
    {
        private string maKV;
        private string xaPhuong;
        private string quanHuyen;
        private string tinhTP;
        private string ghiChu;
        private string maSoHoKhau;
        private string hoTenChuHo;
        private string diaChi;
        private string ngayLap;

        public string MaKV
        { get { return maKV; } set {  maKV = value; } }
        public string XaPhuong
        { get { return xaPhuong; } set { xaPhuong = value; } }
        public string QuanHuyen
        { get { return quanHuyen; } set { quanHuyen = value; } }
        public string TinhThanhPho
        { get { return tinhTP; } set { tinhTP = value; } }
        public string GhiChu
        { get { return ghiChu; }set { ghiChu = value; } }
        public string MaSoHoKhau
        { get { return maSoHoKhau; } set { maSoHoKhau = value; } }
        public string HoTenChuHo
        { get { return hoTenChuHo; } set {  hoTenChuHo = value; } }
        public string DiaChi
        { get { return diaChi; } set { diaChi = value; } }
        public string NgayLap
        { get { return ngayLap; } set { ngayLap = value; } }
        public SoHoKhau()
        {

        }
        public SoHoKhau(string maKV, string xaPhuong, string quanHuyen, string tinhTP, string ghiChu, string maSoHoKhau, string hoTenChuHo, string diaChi, string ngayLap)
        {
            MaKV = maKV;
            XaPhuong = xaPhuong;
            QuanHuyen = quanHuyen;
            TinhThanhPho = tinhTP;
            GhiChu = ghiChu;
            MaSoHoKhau = maSoHoKhau;
            HoTenChuHo = hoTenChuHo;
            DiaChi = diaChi;
            NgayLap = ngayLap;
           
        }
    }
}
