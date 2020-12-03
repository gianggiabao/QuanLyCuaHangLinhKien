using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities; 
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
  public interface  ILinhkienBLL
    {
        List<Linhkien> GetAllLinhkien();
        void ThemLinhkien(Linhkien lk);
        void XoaLinhkien(string Malk);
        void SuaLinhkien(Linhkien lk);
        List<Linhkien> TimLinhkien(Linhkien lk);
    }
}
