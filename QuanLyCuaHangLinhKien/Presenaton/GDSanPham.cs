using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.BusinessLayer;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.Presenaton
{
   public class GDSanPham
    {
        private ISanPhamBLL SP = new SanPhamBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                         Thêm Thông Tin Sản Phẩm                           ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15);Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            SanPham sp = new SanPham();           
            Console.SetCursorPosition(27, 8); Console.Write("Nhập Mã Sản Phẩm: ");
            sp.Masp = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhập Tên Sản Phẩm: ");
            sp.Tensp = Console.ReadLine();
            Console.SetCursorPosition(27, 12); Console.Write("Nhập Giá Sản Phẩm: ");
            sp.Dongia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(27, 14); Console.Write("Nhập Số Lượng Sản Phẩm: ");          
            sp.Soluong = int.Parse(Console.ReadLine());           
            SP.ThemSanPham(sp);
            
        }
        public void Hien()
        {
            Console.Clear();
            Console.SetCursorPosition(13, 5); Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(13, 6); Console.WriteLine("║                                  Hiện Thông Tin Sản Phẩm                                ║");
            Console.SetCursorPosition(13, 7); Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(13, 8); Console.WriteLine("║       Ngày Giờ       ║   Mã Sản Phẩm   ║  Tên Sản Phẩm  ║     Giá      ║    Số Lượng    ║");
            Console.SetCursorPosition(13, 9); Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════════════════╣");        
            List<SanPham> List = SP.GetAllSanPham();
            foreach (var sp in List)
            Console.WriteLine("\t      "+sp.Ngaygio+"\t     "+sp.Masp + "\t     " + sp.Tensp + "\t     " + sp.Dongia + "\t      " + sp.Soluong);
            Console.SetCursorPosition(13, 18);Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                        Sửa Thông Tin Sản Phẩm                             ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 16);Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<SanPham> list = SP.GetAllSanPham();
            string Masua;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Sản Phẩm Cần Sửa:");
            Masua = Console.ReadLine();          
            int i = 0;
            for (i = 0; i < list.Count; ++i) 
                if (list[i].Masp == Masua) break;
            if (i < list.Count)
            {
                    SanPham sp = new SanPham(list[i]);
                    Console.SetCursorPosition(27, 11); Console.Write("Nhập Tên Sản Phẩm Mới :");
                    string ten = Console.ReadLine();
                    if (!string.IsNullOrEmpty(ten)) sp.Tensp = ten;
                    Console.SetCursorPosition(27, 13); Console.Write("Nhập Giá Sản Phẩm Mới :");
                    int gia = int.Parse(Console.ReadLine());
                    if (gia > 0) sp.Dongia = gia;
                    Console.SetCursorPosition(27, 15); Console.Write("Nhập Số Lượng Sản Phẩm Mới :");
                    int soluong = int.Parse(Console.ReadLine());
                    if (soluong > 0) sp.Soluong = soluong;
                    SP.SuaSanPham(sp);
            }
            else
            {
                Console.SetCursorPosition(27,11); Console.Write("Không tồn tại mã sản phẩm này.....");
                Console.ReadKey();
            }    
        }
        public void Xoa()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                        Xóa Thông Tin Sản Phẩm                             ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15);Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<SanPham> list = SP.GetAllSanPham();
            string Maxoa;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Sản Phẩm Cần Xóa:");
            Maxoa = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masp == Maxoa) break;
            if(i<list.Count)
            {
                Console.SetCursorPosition(27, 11); Console.Write("Xóa Thành Công....."); 
                SP.XoaSanPham(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 11); Console.Write("Không Tồn Tại Mã Sản Phẩm Nay.....");
                Console.ReadKey();
            }    
        }
        public void Timkiem()
        {
            Console.Clear();

        }
        public void Menusp()
        {
            do
            {
                Console.Clear();               
                Console.SetCursorPosition(20, 5);  Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 6);  Console.Write("║                         CHƯƠNG TRÌNH QUẢN LÝ CỦA HÀNG                     ║");
                Console.SetCursorPosition(20, 7);  Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 8);  Console.Write("║                           QUẢN LÝ THÔNG TIN SẢN PHẨM                      ║");
                Console.SetCursorPosition(20, 9);  Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 10); Console.Write("║    F1    ║            Thêm thông tin sản phẩm                             ║");
                Console.SetCursorPosition(20, 11); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 12); Console.Write("║    F2    ║            Sửa thông tin sản phẩm                              ║");
                Console.SetCursorPosition(20, 13); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 14); Console.Write("║    F3    ║            Xóa thông tin sản phẩm                              ║");
                Console.SetCursorPosition(20, 15); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 16); Console.Write("║    F4    ║            Hiện thông tin sản phẩm                             ║");
                Console.SetCursorPosition(20, 17); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 18); Console.Write("║    F5    ║            Tìm Kiếm thông tin sản phẩm                         ║");
                Console.SetCursorPosition(20, 19); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 20); Console.Write("║    F6    ║            Quay lại MENU                                       ║");
                Console.SetCursorPosition(20, 21); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 22); Console.Write("║  Mời bạn chọn chức năng :                                                 ║");
                Console.SetCursorPosition(20, 23); Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(48, 22);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch(kt.Key)
                {
                    case ConsoleKey.F1:                       
                        Nhap();
                        Hien();
                        Console.SetCursorPosition(13, 19); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F2:                          
                        Sua(); 
                        Hien();
                        Console.SetCursorPosition(13, 19); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F3:
                        Xoa();
                        Hien();
                        Console.SetCursorPosition(13, 19); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F4:                       
                        Hien();
                        Console.SetCursorPosition(13, 19); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F5:                                                
                        Hien();
                        Console.SetCursorPosition(13, 19); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F6:
                        GiaoDien t = new GiaoDien();
                        t.Menu();
                        break;
                }   
            } while (true);
        }
    }
}
