using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities; 
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
  public interface  ISanPhamBLL
    {
        List<SanPham> GetAllSanPham();
        void ThemSanPham(SanPham sp);
        void XoaSanPham(string Masp);
        void SuaSanPham(SanPham sp);
        List<SanPham> TimSanPham(SanPham sp);
    }
}
