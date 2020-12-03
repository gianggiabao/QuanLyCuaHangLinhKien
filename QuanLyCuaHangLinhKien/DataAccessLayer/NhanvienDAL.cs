using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
    class NhanvienDAL:INhanvienDAL
    {
        private string Tfile = "Data/Nhanvien.txt";
        public List<Nhanvien> GetAllNhanvien()
        {
            List<Nhanvien> list = new List<Nhanvien>();
            StreamReader f = File.OpenText(Tfile);
            string s = f.ReadLine();
            while(s!=null)
            {
                if(s!="")
                {
                    string[] a = s.Split('#');
                    list.Add(new Nhanvien(DateTime.Parse(a[0]), a[1], a[2], a[3], a[4], int.Parse(a[5]), double.Parse(a[6])));
                }
                s = f.ReadLine();
            }
            f.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void ThemNhanvien(Nhanvien nv)
        {
            StreamWriter fwrite = File.AppendText(Tfile);
            fwrite.WriteLine();
            fwrite.Write(nv.Ngaygio + "#" + nv.Manv + "#" + nv.Tennv + "#" + nv.Diachi + "#" + nv.SDT + "#" + nv.SNLV + "#" + nv.HSL);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Nhanvien> list)
        {
            StreamWriter fwrite = File.CreateText(Tfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Ngaygio + "#" + list[i].Manv + "#" + list[i].Tennv + "#" + list[i].Diachi + "#" + list[i].SDT + "#" + list[i].SNLV + "#" + list[i].HSL);
            fwrite.Close();
        }
    }
}
