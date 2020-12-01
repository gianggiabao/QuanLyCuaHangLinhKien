using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;

namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
   public interface IKhachHangDAL
    {
        List<Khachhang> GetAllKhachHang();
        void ThemKhachHang(Khachhang kh);
        void UpdateKh(List<Khachhang> list);
    }
}
