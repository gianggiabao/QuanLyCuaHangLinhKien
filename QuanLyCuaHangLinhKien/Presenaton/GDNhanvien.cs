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
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                         Thêm Thông Tin Linh Kiện                          ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 19); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            Nhanvien nv = new Nhanvien();
            Console.SetCursorPosition(27, 8); Console.Write("Nhập Mã Nhân Viên: ");
            nv.Manv = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhập Tên Nhân Viên: ");
            nv.Tennv = Console.ReadLine();
            Console.SetCursorPosition(27, 12); Console.Write("Nhập Địa Chỉ: ");
            nv.Diachi = Console.ReadLine();
            Console.SetCursorPosition(27, 14); Console.Write("Nhập Số Điện Thoại: ");
            nv.SDT = Console.ReadLine();
            Console.SetCursorPosition(27, 16); Console.Write("Nhập Số Ngày Làm Việc: ");
            nv.SNLV = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(27, 18); Console.Write("Nhập Hệ Số Lương: ");
            nv.HSL = double.Parse(Console.ReadLine());
            NV.ThemNhanvien(nv);
        }
        public void Hien()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(9, 6); Console.WriteLine("║                                        Hiện Thông Tin Nhân Viên                                       ║");
            Console.SetCursorPosition(9, 7); Console.WriteLine("╠═══════╦═══════════════════════╦═══════════════╦═══════════════╦═══════════╦═══════════╦═══════════════╣");
            Console.SetCursorPosition(9, 8); Console.WriteLine("║ Mã NV ║    Tên nhân viên      ║    Địa chỉ    ║      SĐT      ║Số Ngày Làm║   Hệ Số   ║  Tiền Lương   ║");
            Console.SetCursorPosition(9, 9); Console.WriteLine("╠═══════╬═══════════════════════╬═══════════════╬═══════════════╬═══════════╬═══════════╬═══════════════╣");
            List<Nhanvien> list = NV.GetAllNhanvien();
            foreach(var nv in list)
            Console.WriteLine("\t ║ " + nv.Manv + "\t ║   " + nv.Tennv + "\t ║    " + nv.Diachi + "\t ║   " + nv.SDT + "\t ║   " + nv.SNLV + "\t     ║  " + nv.HSL+ "\t ║  " + nv.Tinhluong+ "\t ║ ");
            Console.WriteLine("         ╚═══════╩═══════════════════════╩═══════════════╩═══════════════╩═══════════╩═══════════╩═══════════════╝");
            Console.Write("          Nhập Phím Bất Kỳ Để Tiếp Tục...");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                          Sửa Thông Tin Nhân viên                          ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 20); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<Nhanvien> list = NV.GetAllNhanvien();
            string Masua;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Nhân Viên Cần Sửa:");
            Masua = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == Masua) break;
            if (i < list.Count)
            {
                Nhanvien nv = new Nhanvien(list[i]);
                Console.SetCursorPosition(27, 11); Console.Write("Nhập Tên Nhân Viên Mới :");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) nv.Tennv = ten;
                Console.SetCursorPosition(27, 13); Console.Write("Nhập Địa Chỉ Nhân Viên Mới :");
                string diachi = Console.ReadLine();
                if (!string.IsNullOrEmpty(diachi)) nv.Diachi = diachi;
                Console.SetCursorPosition(27, 15); Console.Write("Nhập Số Điện Thoại Mới :");
                string sdt = Console.ReadLine();
                if (!string.IsNullOrEmpty(sdt)) nv.SDT = sdt;
                Console.SetCursorPosition(27, 17); Console.Write("Nhập Số Ngày Làm Việc Mới :");
                int songay = int.Parse(Console.ReadLine());
                if (songay > 0 && songay <= 30)  nv.SNLV= songay;
                Console.SetCursorPosition(27, 19); Console.Write("Nhập Hệ Số Lương Mới :");
                double heso =double.Parse( Console.ReadLine());
                if (heso>0) nv.HSL = heso;
                NV.SuaNhanvien(nv);
            }
            else
            {
                Console.SetCursorPosition(27, 11); Console.Write("Không tồn tại mã khách hàng này.....");
                Console.ReadKey();
            }
        }
        public void Xoa()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                            Xóa Thông Tin Nhân Viên                        ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<Nhanvien> list = NV.GetAllNhanvien();
            string Maxoa;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Nhân Viên Cần Xóa:");
            Maxoa = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Manv == Maxoa) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(27, 11); Console.Write("Xóa Thành Công.....");
                NV.XoaNhanvien(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 11); Console.Write("Không Tồn Tại Mã Nhân Viên Nay.....");
                Console.ReadKey();
            }        
        }
        public void Timkiem()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(9, 6); Console.WriteLine("║                                      Tìm Kiếm Thông Tin Nhân Viên                                     ║");
            Console.SetCursorPosition(9, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            INhanvienBLL sp = new NhanvienBLL(); 
            List<Nhanvien> list = sp.TimNhanvien(new Nhanvien());
            string matim;
            Console.SetCursorPosition(9, 8);     Console.Write("║ Nhập mã nhân viên cần tìm:                                                                            ║");
            Console.SetCursorPosition(39, 8);
            matim = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (matim == list[i].Manv) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(9, 9);  Console.WriteLine("║                                      Thông tin nhân viên                                              ║");
                Console.SetCursorPosition(9, 10); Console.WriteLine("╠═══════╦═══════════════════════╦═══════════════╦═══════════════╦═══════════╦═══════════╦═══════════════╣");
                Console.SetCursorPosition(9, 11); Console.WriteLine("║ Mã NV ║    Tên nhân viên      ║    Địa chỉ    ║      SĐT      ║Số Ngày Làm║   Hệ Số   ║  Tiền Lương   ║");
                Console.SetCursorPosition(9, 12); Console.WriteLine("╠═══════╬═══════════════════════╬═══════════════╬═══════════════╬═══════════╬═══════════╬═══════════════╣");
                Console.SetCursorPosition(9, 13); Console.WriteLine("║ " + list[i].Manv + "\t ║   " + list[i].Tennv + "\t ║    " + list[i].Diachi + "\t ║   " + list[i].SDT + "\t ║   " + list[i].SNLV + "\t     ║  " + list[i].HSL + "\t ║  " + list[i].Tinhluong + "\t ║ ");
                Console.SetCursorPosition(9, 14); Console.WriteLine("╚═══════╩═══════════════════════╩═══════════════╩═══════════════╩═══════════╩═══════════╩═══════════════╝");
                Console.SetCursorPosition(9, 15); Console.Write(" Nhập Phím Bất Kỳ Để Tiếp Tục...");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(9, 11); Console.Write("  Không tồn tại mã nhân viên nay....");
                Console.SetCursorPosition(9, 15); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(47, 11);
                Console.ReadKey();
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
                Console.SetCursorPosition(20, 16); Console.Write("║     4    ║            Hiện thông tin nhân viên                            ║");
                Console.SetCursorPosition(20, 17); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 18); Console.Write("║     5    ║            Tìm kiếm thông tin nhân viên                        ║");
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
                    case '2':
                        Sua();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '3':
                        Xoa();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '4':
                        Hien();
                        Console.ReadKey();
                        break;
                    case '5':
                        Timkiem();
                        Hien();
                        Console.ReadKey();
                        break;
                    case '6':
                        GiaoDien t = new GiaoDien();
                        t.Menu();
                        break;
                }
             } while (true);
        }
    }
}
