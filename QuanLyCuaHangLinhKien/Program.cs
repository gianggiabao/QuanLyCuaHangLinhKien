﻿using System;
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
                Console.Clear();
                Console.SetCursorPosition(20, 8);  Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 9);  Console.Write("║                                  ĐĂNG NHẬP                                ║");
                Console.SetCursorPosition(20, 10); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 11); Console.Write("║          Tài Khoản :                                                      ║");   
                Console.SetCursorPosition(20, 12); Console.Write("║                                                                           ║");
                Console.SetCursorPosition(20, 13); Console.Write("║          Mật khẩu :                                                       ║");
                Console.SetCursorPosition(20, 14); Console.Write("║                                                                           ║");
                Console.SetCursorPosition(20, 15); Console.Write("║                                                                           ║");
                Console.SetCursorPosition(20, 16); Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                
                Console.SetCursorPosition(43, 11); string tk = Console.ReadLine();
                Console.SetCursorPosition(42, 13); string mk = Console.ReadLine();
                if (tk == "2" && mk == "2")
                {
                    Console.SetCursorPosition(42, 15); Console.Write("Đăng nhập thành công....");
                    Console.ReadKey();
                    Console.Clear();
                    GiaoDien t = new GiaoDien();
                    t.Menu();
                }
                else
                {                  
                    Console.SetCursorPosition(42, 15); Console.Write("Đăng nhập thất bại....");                
                    Console.ReadKey();
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
