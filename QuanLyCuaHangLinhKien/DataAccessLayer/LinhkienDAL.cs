using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;
using System.IO;
namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
    class LinhkienDAL : ILinhkienDAL
    {
        private string Txtfile = "Data/Linhkien.txt";
        public List<Linhkien> GetAllLinhkien()
        {
            List<Linhkien> list = new List<Linhkien>();
            StreamReader fread = File.OpenText(Txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Linhkien(DateTime.Parse(a[0]),a[1], a[2], double.Parse(a[3]), int.Parse(a[4]), double.Parse(a[5]))); 
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void ThemLinhkien(Linhkien lk)
        {   StreamWriter fwrite = File.AppendText(Txtfile);
            fwrite.WriteLine();
            fwrite.Write(lk.Ngaygio+"#"+lk.Malk+ "#" + lk.Tenlk + "#" + lk.Gia+"#"+lk.Soluong+"#"+lk.Tinhtien);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Linhkien> list)
        {
            StreamWriter fwrite = File.CreateText(Txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Ngaygio+"#"+ list[i].Malk + "#" + list[i].Tenlk + "#" + list[i].Gia+"#"+list[i].Soluong+ "#" + list[i].Tinhtien);
            fwrite.Close();
        }    
    }
}
