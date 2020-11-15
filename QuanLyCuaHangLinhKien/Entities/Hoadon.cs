using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKien.Entities
{
   public class Hoadon
    {
        private string makhachhang;
        private string mahoadon;
        private string ngayban;
        public string Makhanghang
        {
            get { return makhachhang; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    makhachhang = value;
            }
        }
        public string Mahoadon
        {
            get { return mahoadon; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    mahoadon = value;
            }
        }
        public string Ngayban
        {
            get { return ngayban; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngayban = value;
            }
        }
        public Hoadon() { }
        public Hoadon(Hoadon hd)        {
            this.mahoadon = hd.mahoadon;
            this.makhachhang= hd.makhachhang;
            this.ngayban =hd.ngayban;
        }
        public Hoadon(string mahoadon, string makhachhang, string ngayban)
        {
            this.mahoadon = mahoadon;
            this.makhachhang = makhachhang;
            this.ngayban = ngayban;
        }
    }
    
}
