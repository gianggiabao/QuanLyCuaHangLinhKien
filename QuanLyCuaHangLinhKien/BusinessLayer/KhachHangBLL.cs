﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;
using QuanLyCuaHangLinhKien.DataAccessLayer;
namespace QuanLyCuaHangLinhKien.BusinessLayer
{
   public class KhachHangBLL:IKhachHangBLL
    {
        private IKhachHangDAL kh = new KhachHangDAL();
        public List<Khachhang> GetAllKhachHang()
        {
            return kh.GetAllKhachHang();
        }
        public void ThemKhachHang(Khachhang kh)
        {
            if (!string.IsNullOrEmpty(kh.Tenkh))
            {
                this.kh.ThemKhachHang(kh);
            }
            else
                throw new Exception("du lieu sai");
        }
        public void XoaKhachHang(string Makh)
        {
            int i;
            List<Khachhang> list = GetAllKhachHang();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Makh == Makh) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                kh.UpdateKh(list);
            }
            else
                throw new Exception("khong ton tai ma n");
        }
        public void SuaKhachHang(Khachhang kh)
        {
            int i;
            List<Khachhang> list = GetAllKhachHang();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Makh == kh.Makh) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(kh);
                this.kh.UpdateKh(list);
            }
            else
                throw new Exception("khong ton tai ma nay");
        }
        public List<Khachhang> TimKhachHang(Khachhang kh)
        {
            List<Khachhang> list = GetAllKhachHang();
            List<Khachhang> kq = new List<Khachhang>();
            if (string.IsNullOrEmpty(kh.Makh) && string.IsNullOrEmpty(kh.Tenkh) && string.IsNullOrEmpty(kh.Diachi) && string.IsNullOrEmpty(kh.SDT))
            {
                kq = list;
            }
            //Tim theo mã
            else if (kh.Makh != "")
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Makh == kh.Makh)
                    {
                        kq.Add(new Khachhang(list[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
