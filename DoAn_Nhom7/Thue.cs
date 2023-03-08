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
        private string thueSuat;
        private string tinhTrang;
        private string soNo;

        public string LoaiThue
        {
            get { return this.loaiThue; }
            set { this.loaiThue = value; }
        }
        public string ThueSuat
        {
            get { return this.thueSuat; }
            set { this.thueSuat = value; }
        }
        public string TinhTrang
        {
            get { return this.tinhTrang; }
            set { this.tinhTrang = value; }
        }
        public string SoNo
        {
            get { return this.soNo; }
            set { this.soNo = value; }
        }
        public Thue()
        {

        }
        public Thue(string LoaiThue, string ThueSuat,string TinhTrang,string SoNo)
        {
            this.loaiThue = LoaiThue;
            this.thueSuat = ThueSuat;
            this.tinhTrang = TinhTrang;
            this.soNo = SoNo;
        }
        ~Thue()
        {

        }
    }
}
