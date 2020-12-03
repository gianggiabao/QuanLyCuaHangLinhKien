using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKien.Entities
{
   public class Nhanvien
    {
        private DateTime ngaygio;
        private string tennv;
        private string diachi;
        private string manv;
        private string sdt;
        private int songaylamviec;
        private double hesoluong;
        private double tinhluong;
        public DateTime Ngaygio
        {
            get { return ngaygio; }
        }
        public string Tennv
        {
            get { return tennv; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tennv = value;
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
        public string Manv
        {
            get { return manv; }
            set
            {
                if (!string.IsNullOrEmpty(value)&& value.Length<=4)
                    manv = value;
            }
        }
        public string SDT
        {
            get { return sdt; }
            set
            {
                if (!string.IsNullOrEmpty(value)&&value.Length<=10)
                    sdt = value;
            }
        }
        public int SNLV
        {
            get { return songaylamviec; }
            set
            {
                if (value > 0 && value <= 30)
                    songaylamviec = value;
            }
        }
        public double HSL
        {
            get { return hesoluong; }
            set
            {
                if (value > 0)
                    hesoluong = value;
            }
        }
        public double Tinhluong
        {
            get { return SNLV * HSL; }
        }
        public Nhanvien()
        {
            ngaygio = DateTime.Now;
        }
        public Nhanvien(Nhanvien nv)
        {
            this.ngaygio = nv.ngaygio;
            this.tennv = nv.tennv;
            this.manv = nv.manv;
            this.diachi = nv.diachi;
            this.sdt =nv.sdt;
            this.songaylamviec = nv.songaylamviec;
            this.hesoluong = nv.hesoluong;
            this.tinhluong = nv.tinhluong;
        }
        public Nhanvien(DateTime ngaygio,string manv,string tennv,string diachi,string sdt,int songaylamviec,double hesoluong,double tinhluong)
        {
            this.ngaygio = ngaygio;
            this.manv = manv;
            this.tennv = tennv;
            this.diachi = diachi;
            this.sdt = sdt;
            this.songaylamviec = songaylamviec;
            this.hesoluong = hesoluong;
            this.tinhluong = tinhluong;
        }
    }
}
