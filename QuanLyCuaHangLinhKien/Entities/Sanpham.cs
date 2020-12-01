using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKien.Entities
{
   public class SanPham
    {
        private DateTime ngaygio;
        private string tensp;
        private string masp;
        private int gia;
        private int soluong;  
        public DateTime Ngaygio
        {
            get { return ngaygio; }
        }
        public string Tensp
        {
            get { return tensp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tensp = value;
            }
        }
        public string Masp
        {
            get { return masp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    masp = value;
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
        public SanPham()
        {
            ngaygio = DateTime.Now;
        }
        //Phương thức thiết lập sao chép
        public SanPham(SanPham sp)
        {
            this.ngaygio = sp.ngaygio;
            this.masp = sp.masp;
            this.tensp = sp.tensp;
            this.gia = sp.gia;
            this.soluong = sp.soluong;
        }
        public SanPham(DateTime ngaygio,string masp, string tensp, int gia,int soluong)
        {
            this.ngaygio = ngaygio;
            this.masp= masp;
            this.tensp = tensp;
            this.gia = gia;
            this.soluong = soluong;
        }
    }
}
