using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;

namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
    public interface ISanPhamDAL
    {
        List<SanPham> GetAllSanPham();
        void ThemSanPham(SanPham hs);
        void Update(List<SanPham> list);
    }
      
}
