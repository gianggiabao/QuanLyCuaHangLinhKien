using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKien.Entities
{
   public class Khachhang
    {
        private DateTime ngaygiokh;
        private string makh;
        private string tenkh;
        private string diachi;
        private string sdt;
        public DateTime Ngaygiokh
        {
            get { return ngaygiokh; }
        }
        public string Makh
        {
            get { return makh; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    makh = value;
            }
        }
        public string Tenkh
        {
            get { return tenkh; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenkh = value;
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
                if (!string.IsNullOrEmpty(value)) 
                    sdt = value;
            }
        }
        public Khachhang()
        {
            ngaygiokh = DateTime.Now;
        }
        public Khachhang(Khachhang kh)
        {
            this.ngaygiokh = kh.ngaygiokh;
            this.makh = kh.makh;
            this.tenkh = kh.tenkh;
            this.diachi = kh.diachi;
            this.sdt = kh.sdt;
        }
        public Khachhang(DateTime ngaygiokh, string makh, string tenkh, string diachi,string sdt)
        {
            this.ngaygiokh = ngaygiokh;
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi  = diachi;
            this.sdt = sdt;
        }
    }
}
