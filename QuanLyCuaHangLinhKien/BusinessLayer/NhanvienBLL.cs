using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.DataAccessLayer;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
    class NhanvienBLL:INhanvienBLL
    {
        private INhanvienDAL NV = new NhanvienDAL();
        public List<Nhanvien> GetAllNhanvien()
        {
            return NV.GetAllNhanvien();
        }
        public void ThemNhanvien(Nhanvien nv)
        {
            if (!string.IsNullOrEmpty(nv.Tennv))
            {
                this.NV.ThemNhanvien(nv);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void XoaNhanvien(string Manv)
        {
            int i;
            List<Nhanvien> list = GetAllNhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == Manv) break;
            if (i < list.Count)
            {

                list.RemoveAt(i);
                NV.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");

        }
        public void SuaNhanvien(Nhanvien nv)
        {
            int i;
            List<Nhanvien> list = GetAllNhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == nv.Manv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(nv);
                this.NV.Update(list);
            }
            else
                throw new Exception("Khong ton tai linh kien  nay");
        }
        public List<Nhanvien> TimNhanvien(Nhanvien nv)
        {
            List<Nhanvien> list = GetAllNhanvien();
            List<Nhanvien> kq = new List<Nhanvien>();
            if (string.IsNullOrEmpty(nv.Manv) && string.IsNullOrEmpty(nv.Tennv) && string.IsNullOrEmpty(nv.Diachi) && string.IsNullOrEmpty(nv.SDT)&& nv.SNLV == 0 && nv.HSL == 0)
            {
                kq = list;
            }
            //Tim theo mã
            else if (nv.Manv != "")
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Manv == nv.Manv)
                    {
                        kq.Add(new Nhanvien(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
