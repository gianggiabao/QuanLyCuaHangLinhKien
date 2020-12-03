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
        private double gia;
        private int soluong;
        private double tinhtien;
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
        public double Gia
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
        public double Tinhtien
        {
            get { return Gia * Soluong; }
        }
        public Linhkien()
        {
            ngaygio = DateTime.Now;
        }
        //Phương thức thiết lập sao chép
        public Linhkien(Linhkien lk)
        {
            this.ngaygio = lk.ngaygio;
            this.malk = lk.malk;
            this.tenlk = lk.tenlk;
            this.gia = lk.gia;
            this.soluong = lk.soluong;
            this.tinhtien = lk.tinhtien;
        }
        public Linhkien(DateTime ngaygio,string malk, string tenlk, double gia,int soluong,double tinhtien)
        {
            this.ngaygio = ngaygio;
            this.malk= malk;
            this.tenlk = tenlk;
            this.gia = gia;
            this.soluong = soluong;
            this.tinhtien = tinhtien;
        }
    }
}
