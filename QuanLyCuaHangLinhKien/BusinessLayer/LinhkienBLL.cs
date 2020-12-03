using QuanLyCuaHangLinhKien.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.DataAccessLayer;
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
    public class LinhkienBLL : ILinhkienBLL
    {
        private ILinhkienDAL LK = new LinhkienDAL();
        public List<Linhkien> GetAllLinhkien()
        {
            return LK.GetAllLinhkien();
        }
        public void ThemLinhkien(Linhkien lk)
        {
            if (!string.IsNullOrEmpty(lk.Tenlk))
            {
                this.LK.ThemLinhkien(lk);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void XoaLinhkien(string Malk)
        {
            int i;
            List<Linhkien> list = GetAllLinhkien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Malk == Malk) break;
            if (i < list.Count)
            {
               
                list.RemoveAt(i);
                LK.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");

        }
        public void SuaLinhkien(Linhkien lk)
        {
            int i;
            List<Linhkien> list = GetAllLinhkien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Malk == lk.Malk) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(lk);
                this.LK.Update(list);
            }
            else
                throw new Exception("Khong ton tai linh kien  nay");
        }
        public List<Linhkien> TimLinhkien(Linhkien sp)
        {
            List<Linhkien> list = GetAllLinhkien();
            List<Linhkien> kq = new List<Linhkien>();
            if (string.IsNullOrEmpty(sp.Malk) && string.IsNullOrEmpty(sp.Tenlk) && sp.Gia == 0 && sp.Soluong == 0) 
            {
                kq = list;
            }        
            //Tim theo mã
            else if (sp.Malk!="")
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Malk == sp.Malk)
                    {
                        kq.Add(new Linhkien(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
