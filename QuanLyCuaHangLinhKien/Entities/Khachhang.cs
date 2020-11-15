using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKien.Entities
{
   public class Khachhang
    {
        private string makh;
        private string tenkhachhang;
        private string diachi;
        private string sdt;
        public string Makhachhang
        {
            get { return makh; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    makh = value;
            }
        }
        public string Tennkhachhang
        {
            get { return tenkhachhang; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenkhachhang = value;
            }
        }
        public string Diachi
        {
            get { return diachi; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    diachi = value;
            }
        }
        public string SDT
        {
            get { return sdt; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 10)
                    sdt = value;
            }
        }
    }
}
