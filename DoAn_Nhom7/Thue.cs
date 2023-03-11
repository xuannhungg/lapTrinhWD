using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Nhom7
{
    public class Thue
    {
        private string loaiThue;
        private double mucThue;
        private string tinhTrang;
        public string LoaiThue
        {
            get { return this.loaiThue; }
            set { this.loaiThue = value; }
        }
        public double MucThue
        {
            get { return this.mucThue; }
            set { this.mucThue = value; }
        }
        public string TinhTrang
        {
            get { return this.tinhTrang; }
            set { this.tinhTrang = value; }
        }
        public Thue()
        {

        }
        public Thue(string loaiThue, double mucThue, string tinhTrang)
        {
            this.LoaiThue = loaiThue;
            this.MucThue = mucThue;
            this.TinhTrang = tinhTrang;
        }
        ~Thue()
        {

        }
    }
}
