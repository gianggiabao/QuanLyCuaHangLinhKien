using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
   public interface INhanvienBLL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemNhanvien(Nhanvien nv);
        void XoaNhanvien(string Manv);
        void SuaNhanvien(Nhanvien nv);
        List<Nhanvien> TimNhanvien(Nhanvien nv);
    }
}
