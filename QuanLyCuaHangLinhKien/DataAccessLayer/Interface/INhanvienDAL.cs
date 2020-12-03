using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;

namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
   public interface  INhanvienDAL
    {
        List<Nhanvien> GetAllNhanvien();
        void ThemNhanvien(Nhanvien nv);
        void Update(List<Nhanvien> list);
    }
}
