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
        private string quequan;
        private string manv;
        private string sdt;
       
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
        public string Quequan
        {
            get { return quequan; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    quequan = value;
            }
        }
        public string Manv
        {
            get { return manv; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    manv = value;
            }
        }
        public string SDT
        {
            get { return sdt; }
            set
            {
                if (!string.IsNullOrEmpty(value)&&value.Length==10)
                    sdt = value;
            }
        }
        public Nhanvien()
        {
            ngaygio = DateTime.Now;
        }
        public Nhanvien(Nhanvien NV)
        {
            this.ngaygio = NV.ngaygio;
            this.tennv = NV.tennv;
            this.manv = NV.manv;
            this.quequan = NV.quequan;
            this.sdt =NV.sdt;
        }
        public Nhanvien(string tennv,string manv,string quequan,string sdt,DateTime ngaygio)
        {
            this.ngaygio = ngaygio;
            this.tennv = tennv;
            this.manv = manv;
            this.quequan = quequan;
            this.sdt = sdt;
        }
    }
}
