using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.BusinessLayer;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.Presenaton
{
   public  class GDNhanvien
    {
        private INhanvienBLL NV = new NhanvienBLL();
        public void Nhap()
        {
            Console.Clear();
            Nhanvien nv = new Nhanvien();
            Console.Write("Nhập Mã Nhân Viên: ");
            nv.Manv = Console.ReadLine();
            Console.Write("Nhập Tên Nhân Viên: ");
            nv.Tennv = Console.ReadLine();
            Console.Write("Nhập Địa Chỉ: ");
            nv.Diachi = Console.ReadLine();
            Console.Write("Nhập Số Điện Thoại: ");
            nv.SDT = Console.ReadLine();
            Console.Write("Nhập Số Ngày Làm Việc: ");
            nv.SNLV = int.Parse(Console.ReadLine());
            Console.Write("Nhập Hệ Số Lương: ");
            nv.HSL = double.Parse(Console.ReadLine());
            NV.ThemNhanvien(nv);
        }
        public void Hien()
        {
            Console.Clear();
            List<Nhanvien> list = NV.GetAllNhanvien();
            foreach(var nv in list)
            {
                Console.WriteLine(nv.Manv + "\t" + nv.Tennv + "\t" + nv.Diachi + "\t" + nv.SDT + "\t" + nv.SNLV + "\t" + nv.HSL+"\t"+nv.Tinhluong);
            }    
        }
        public void Menunv()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5);  Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 6);  Console.Write("║                         CHƯƠNG TRÌNH QUẢN LÝ CỦA HÀNG                     ║");
                Console.SetCursorPosition(20, 7);  Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 8);  Console.Write("║                          QUẢN LÝ THÔNG TIN NHÂN VIÊN                      ║");
                Console.SetCursorPosition(20, 9);  Console.Write("╠══════════╦════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 10); Console.Write("║     1    ║            Thêm thông tin nhân viên                            ║");
                Console.SetCursorPosition(20, 11); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 12); Console.Write("║     2    ║            Sửa thông tin nhân viên                             ║");
                Console.SetCursorPosition(20, 13); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 14); Console.Write("║     3    ║            Xóa thông tin nhân viên                             ║");
                Console.SetCursorPosition(20, 15); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 16); Console.Write("║     4    ║            Tìm kiếm thông tin nhân viên                        ║");
                Console.SetCursorPosition(20, 17); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 18); Console.Write("║     5    ║            Hiện thông tin nhân viên                            ║");
                Console.SetCursorPosition(20, 19); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 20); Console.Write("║     6    ║            Quay lại MENU                                       ║");
                Console.SetCursorPosition(20, 21); Console.Write("╠══════════╩════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 22); Console.Write("║  Mời bạn chọn chức năng :                                                 ║");
                Console.SetCursorPosition(20, 23); Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(48, 22);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.KeyChar)
                {
                    case '1':
                        Nhap();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '5':
                        Hien();
                        Console.ReadKey();
                        break;
                }
             } while (true);
        }
    }
}
