using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;

namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
    public interface ILinhkienDAL
    {
        List<Linhkien> GetAllLinhkien();
        void ThemLinhkien(Linhkien sp);
        void Update(List<Linhkien> list);
     
    }
      
}
