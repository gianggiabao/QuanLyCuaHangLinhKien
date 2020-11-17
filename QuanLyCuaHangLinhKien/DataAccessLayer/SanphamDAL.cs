using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Entities;
using System.IO;
namespace QuanLyCuaHangLinhKien.DataAccessLayer
{
    class SanphamDAL : ISanPhamDAL
    {
        private string Txtfile = "Data/Sanpham.txt";
        public List<SanPham> GetAllSanPham()
        {
            List<SanPham> list = new List<SanPham>();
            StreamReader fread = File.OpenText(Txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new SanPham(DateTime.Parse(a[0]),a[1], a[2], int.Parse(a[3]), int.Parse(a[4]))); 
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void ThemSanPham(SanPham sp)
        {           
            StreamWriter fwrite = File.AppendText(Txtfile);
            fwrite.WriteLine();
            fwrite.Write(sp.Ngaygio+"#"+sp.Masp+ "#" + sp.Tensp + "#" + sp.Dongia+"#"+sp.Soluong);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<SanPham> list)
        {
            StreamWriter fwrite = File.CreateText(Txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Ngaygio+"#"+ list[i].Masp + "#" + list[i].Tensp + "#" + list[i].Dongia+"#"+list[i].Soluong );
            fwrite.Close();
        }
        // Xóa một sản phẩm khi biết mã      
      
    }
}
