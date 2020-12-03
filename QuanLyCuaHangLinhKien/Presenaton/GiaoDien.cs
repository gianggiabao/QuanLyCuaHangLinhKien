using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.BusinessLayer;
using QuanLyCuaHangLinhKien.Entities;

namespace QuanLyCuaHangLinhKien.Presenaton
{
   public class GiaoDien
    { 
        public void Menu()
        {
            do
            {
                Console.Clear();               
                Console.SetCursorPosition(20, 6);  Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 7);  Console.Write("║                         CHƯƠNG TRÌNH QUẢN LÝ CỦA HÀNG                     ║");
                Console.SetCursorPosition(20, 8);  Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 9);  Console.Write("║                                 MENU LỰA CHỌN                             ║");
                Console.SetCursorPosition(20, 10); Console.Write("╠══════════╦════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 11); Console.Write("║    1     ║            Quản lý Sản Phẩm                                    ║");
                Console.SetCursorPosition(20, 12); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 13); Console.Write("║    2     ║            Quản Lý Khách Hàng                                  ║");
                Console.SetCursorPosition(20, 14); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 15); Console.Write("║    3     ║            Quản Lý Nhân Viên                                   ║");
                Console.SetCursorPosition(20, 16); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 17); Console.Write("║    4     ║            Quản Lý Hóa Đơn                                     ║");
                Console.SetCursorPosition(20, 18); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 19); Console.Write("║    5     ║            Thoát Khỏi Chương Trình                             ║");
                Console.SetCursorPosition(20, 20); Console.Write("╠══════════╩════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 21); Console.Write("║  Mời Bạn Chọn Chức Năng :                                                 ║");
                Console.SetCursorPosition(20, 22); Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(48, 21);
                ConsoleKeyInfo kt = Console.ReadKey();
                
                switch (kt.KeyChar)
                {
                    case '1':
                        GDLinhkien GDSP = new GDLinhkien();
                        GDSP.Menusp();
                        break;
                    case '2':
                        GDKhachHang GDKH = new GDKhachHang();
                        GDKH.Menukh();
                        break;
                    case '5':                       
                        Program.Modau(); 
                        break;
                }
            } while (true);
        }
    }
}
