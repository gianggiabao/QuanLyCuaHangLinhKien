using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKien.Entities
{
   public class Linhkien
    {
        private DateTime ngaygio;
        private string tenlk;
        private string malk;
        private int gia;
        private int soluong;  
        public DateTime Ngaygio
        {
            get { return ngaygio; }
        }
        public string Tenlk
        {
            get { return tenlk; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tenlk = value;
            }
        }
        public string Malk
        {
            get { return malk; }
            set
            {
                if (!string.IsNullOrEmpty(value)&& value.Length<=4)
                    malk = value;
            }
        }
        public int Gia
        {
            get { return gia; }
            set
            {
                if (value > 0)
                    gia = value;
            }
        }  
        public int Soluong
        {
            get { return soluong; }
            set
            {
                if (value > 0)
                    soluong = value;
            }
        }
        public Linhkien()
        {
            ngaygio = DateTime.Now;
        }
        //Phương thức thiết lập sao chép
        public Linhkien(Linhkien sp)
        {
            this.ngaygio = sp.ngaygio;
            this.malk = sp.malk;
            this.tenlk = sp.tenlk;
            this.gia = sp.gia;
            this.soluong = sp.soluong;
        }
        public Linhkien(DateTime ngaygio,string malk, string tenlk, int gia,int soluong)
        {
            this.ngaygio = ngaygio;
            this.malk= malk;
            this.tenlk = tenlk;
            this.gia = gia;
            this.soluong = soluong;
        }
    }
}
