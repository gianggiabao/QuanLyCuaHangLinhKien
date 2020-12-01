using QuanLyCuaHangLinhKien.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.DataAccessLayer;
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
    public class SanPhamBLL : ISanPhamBLL
    {
        private ISanPhamDAL sp = new SanphamDAL();
        public List<SanPham> GetAllSanPham()
        {
            return sp.GetAllSanPham();
        }
        public void ThemSanPham(SanPham sp)
        {
            if (!string.IsNullOrEmpty(sp.Tensp))
            {
                this.sp.ThemSanPham(sp);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void XoaSanPham(string Masp)
        {
            int i;
            List<SanPham> list = GetAllSanPham();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masp == Masp) break;
            if (i < list.Count)
            {
               
                list.RemoveAt(i);
                sp.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");

        }
        public void SuaSanPham(SanPham sp)
        {
            int i;
            List<SanPham> list = GetAllSanPham();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masp == sp.Masp) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(sp);
                this.sp.Update(list);
            }
            else
                throw new Exception("Khong ton tai san pham  nay");
        }
        public List<SanPham> TimSanPham(SanPham sp)
        {
            List<SanPham> list = GetAllSanPham();
            List<SanPham> kq = new List<SanPham>();
            if (string.IsNullOrEmpty(sp.Masp) &&
                string.IsNullOrEmpty(sp.Tensp) &&
                sp.Gia == 0)
            {
                kq = list;
            }
            //Tim theo ten sp
            if (!string.IsNullOrEmpty(sp.Tensp))
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Tensp.IndexOf(sp.Tensp) >= 0)
                    {
                        kq.Add(new SanPham(list[i]));
                    }
            }

            //Tim theo gia
            else if (sp.Gia > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Gia == sp.Gia)
                    {
                        kq.Add(new SanPham(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
