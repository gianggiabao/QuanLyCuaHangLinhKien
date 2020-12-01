using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
     public interface IKhachHangBLL
    {
        List<Khachhang> GetAllKhachHang();
        void ThemKhachHang(Khachhang kh);
        void XoaKhachHang(string Makh);
        void SuaKhachHang(Khachhang kh);
    }
}
