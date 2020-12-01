using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;
using System.IO;
namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
    class KhachHangDAL : IKhachHangDAL
    {
        private string Txtfile = "Data/Khachhang.txt";
        public List<Khachhang> GetAllKhachHang()
        {
            List<Khachhang> list = new List<Khachhang>();
            StreamReader fread = File.OpenText(Txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Khachhang(DateTime.Parse(a[0]), a[1], a[2], a[3], a[4]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void ThemKhachHang(Khachhang kh)
        {
            StreamWriter fwrite = File.AppendText(Txtfile);
            fwrite.WriteLine();
            fwrite.Write(kh.Ngaygiokh + "#" + kh.Makh + "#" + kh.Tenkh + "#" + kh.Diachi + "#" + kh.SDT);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void UpdateKh(List<Khachhang> list)
        {
            StreamWriter fwrite = File.CreateText(Txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Ngaygiokh + "#" + list[i].Makh + "#" + list[i].Tenkh + "#" + list[i].Diachi + "#" + list[i].SDT);
            fwrite.Close();
        }
    }
}
