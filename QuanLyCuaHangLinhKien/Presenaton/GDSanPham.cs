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
        private ISanPhamBLL spDLL = new SanPhamBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(45, 2); Console.WriteLine("NHẬP THÔNG TIN SẢN PHẨM");
            SanPham sp = new SanPham();           
            Console.SetCursorPosition(25, 4); Console.Write("Nhập Mã Sản Phẩm: ");
            sp.Masp = Console.ReadLine();
            Console.SetCursorPosition(25, 5); Console.Write("Nhập Tên Sản Phẩm: ");
            sp.Tensp = Console.ReadLine();
            Console.SetCursorPosition(25, 6); Console.Write("Nhập Giá Sản Phẩm: ");
            sp.Dongia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(25, 7); Console.Write("Nhập Số Lượng Sản Phẩm: ");
            sp.Soluong = int.Parse(Console.ReadLine());
            spDLL.ThemSanPham(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.SetCursorPosition(45, 2); Console.WriteLine("HIỆN THÔNG TIN SẢN PHẨM");
            List<SanPham> List = spDLL.GetAllSanPham();
            foreach (var sp in List)
                Console.WriteLine(sp.Ngaygio+"\t"+sp.Masp + "\t" + sp.Tensp + "\t" + sp.Dongia + "\t" + sp.Soluong);
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(45, 2); Console.WriteLine("SỬA THÔNG TIN SẢN PHẨM");
            List<SanPham> list = spDLL.GetAllSanPham();
            string Masua;
            Console.SetCursorPosition(25, 4);  Console.Write("Nhập Mã Sản Phẩm Cần Sửa:");
            Masua = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Masp == Masua)
                {
                    if (i < list.Count)
                    {
                        SanPham sp = new SanPham(list[i]);
                        Console.SetCursorPosition(25, 5); Console.Write("Nhập Tên  Mới :");
                        string ten = Console.ReadLine();
                        if (!string.IsNullOrEmpty(ten)) sp.Tensp = ten;
                        Console.SetCursorPosition(25, 6); Console.Write("Nhập Giá Mới:");
                        int gia = int.Parse(Console.ReadLine());
                        if (gia > 0) sp.Dongia = gia;
                        Console.SetCursorPosition(25, 7); Console.Write("Nhập Số Lượng Mới:");
                        int soluong = int.Parse(Console.ReadLine());
                        if (soluong > 0) sp.Soluong = soluong;
                        spDLL.SuaSanPham(sp);
                    }
                }
                else
                {
                    Console.WriteLine("Không tồn tại mã sản phẩm này");
                }
            }
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.SetCursorPosition(45, 2); Console.WriteLine("TÌM KIẾM THÔNG TIN SẢN PHẨM");
        }
        public void menusp()
        {
            do
            {
                
                Console.Clear();
                Console.Beep();
                Console.SetCursorPosition(20, 8);  Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 9);  Console.Write("║                         CHƯƠNG TRÌNH QUẢN LÝ CỦA HÀNG                     ║");
                Console.SetCursorPosition(20, 10); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 11); Console.Write("║                           QUẢN LÝ THÔNG TIN SẢN PHẨM                      ║");
                Console.SetCursorPosition(20, 12); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 13); Console.Write("║    F1    ║            Nhập thông tin sản phẩm                             ║");
                Console.SetCursorPosition(20, 14); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 15); Console.Write("║    F2    ║            Sửa thông tin sản phẩm                              ║");
                Console.SetCursorPosition(20, 16); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 17); Console.Write("║    F3    ║            Xóa thông tin sản phẩm                              ║");
                Console.SetCursorPosition(20, 18); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 19); Console.Write("║    F4    ║            Hiện thông tin sản phẩm                             ║");
                Console.SetCursorPosition(20, 20); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 21); Console.Write("║    F5    ║            Tìm Kiếm thông tin sản phẩm                         ║");
                Console.SetCursorPosition(20, 22); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 23); Console.Write("║    F6    ║            Quay lại MENU                                       ║");
                Console.SetCursorPosition(20, 24); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 25); Console.Write("║  Mời bạn chọn chức năng :                                                 ║");
                Console.SetCursorPosition(20, 26); Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(48, 25);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch(kt.Key)
                {
                    case ConsoleKey.F1:
                        Console.Beep();
                        Nhap();
                        Hien();
                        Console.SetCursorPosition(25, 10); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F2:
                        Console.Beep();
                        Sua();
                        Hien();
                        Console.SetCursorPosition(25, 10); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F4:
                        Console.Beep(); 
                        Hien();
                        Console.SetCursorPosition(25, 10); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F5:
                        Console.Beep();
                        TimKiem();
                        Hien();
                        Console.SetCursorPosition(25, 10); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
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
