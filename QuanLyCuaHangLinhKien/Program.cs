using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.Presenaton;
namespace QuanLyCuaHangLinhKien
{
   public  class Program
    {
        public static void Modau()
        {
            do
            {                
                Console.SetCursorPosition(20, 8); Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 9); Console.Write("║                     ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN                     ║");
                Console.SetCursorPosition(20, 10);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 11);Console.Write("║                                  ĐỒ ÁN 1                                  ║");
                Console.SetCursorPosition(20, 12);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 13);Console.Write("║     XÂY DỰNG CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG BÁN LINH KIỆN MÁY TÍNH         ║");
                Console.SetCursorPosition(20, 14);Console.Write("╠═════════════════════════════════════╦═════════════════════════════════════╣");
                Console.SetCursorPosition(20, 15);Console.Write("║         Giảng viên hướng dẫn        ║          Nguyễn Hữu Đông            ║");
                Console.SetCursorPosition(20, 16);Console.Write("╠═════════════════════════════════════╬═════════════════════════════════════╣");
                Console.SetCursorPosition(20, 17);Console.Write("║         Sinh viên thực hiện         ║          Giang Gia Bảo              ║");
                Console.SetCursorPosition(20, 18);Console.Write("╠═════════════════════════════════════╩═════════════════════════════════════╣");
                Console.SetCursorPosition(20, 19);Console.Write("║                      Nhấn phím Enter để bắt đầu                           ║");
                Console.SetCursorPosition(20, 20);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 21);Console.Write("║                      Nhấn phím Backspace để thoát                         ║");
                Console.SetCursorPosition(20, 22);Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(72, 19);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        GiaoDien h = new GiaoDien();
                        h.Menu();
                        break;
                    case ConsoleKey.Backspace:                      
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
        static void Main()
        {           
            Console.OutputEncoding = Encoding.UTF8;
            Modau();
        }
    }
}
