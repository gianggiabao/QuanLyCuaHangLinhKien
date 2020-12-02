using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.BusinessLayer;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.Presenaton
{
    public class GDKhachHang
    {
        private IKhachHangBLL KH = new KhachHangBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                          Thêm Thông Tin Khách Hàng                        ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            Khachhang kh = new Khachhang();
            Console.SetCursorPosition(27, 8); Console.Write("Nhập Mã Khách Hàng: ");
            kh.Makh = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhập Tên Khách Hàng: ");
            kh.Tenkh = Console.ReadLine();
            Console.SetCursorPosition(27, 12); Console.Write("Nhập Địa Chỉ Khách Hàng: ");
            kh.Diachi = Console.ReadLine();
            Console.SetCursorPosition(27, 14); Console.Write("Nhập Số Điện Thoại Khách Hàng: ");
            kh.SDT = Console.ReadLine();
            KH.ThemKhachHang(kh);
        }
        public void Hien()
        {
            Console.Clear();
            Console.SetCursorPosition(13, 5); Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(13, 6); Console.WriteLine("║                                 Hiện Thông Tin Khách Hàng                               ║");
            Console.SetCursorPosition(13, 7); Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(13, 8); Console.WriteLine("║       Ngày Giờ     ║Mã Khách Hàng║    Tên Khách Hàng     ║    Địa Chỉ    ║     SĐT      ║");
            Console.SetCursorPosition(13, 9); Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════════════════╣");
            List<Khachhang> List = KH.GetAllKhachHang();
            foreach (var kh in List)
            Console.WriteLine("\t      " + kh.Ngaygiokh + " ║   " + kh.Makh + "\t║    " + kh.Tenkh + "\t║    " + kh.Diachi + "\t║    " + kh.SDT);
            Console.SetCursorPosition(13, 18); Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(15, 20); Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                          Sửa Thông Tin Khách Hàng                         ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 16); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<Khachhang> list = KH.GetAllKhachHang();
            string Masua;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Khách Hàng Cần Sửa:");
            Masua = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Makh == Masua) break;
            if (i < list.Count)
            {
                Khachhang kh = new Khachhang(list[i]);
                Console.SetCursorPosition(27, 11); Console.Write("Nhập Tên Khách Hàng Mới :");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) kh.Tenkh = ten;
                Console.SetCursorPosition(27, 13); Console.Write("Nhập Địa Chỉ Khách Hàng Mới :");
                string diachi = Console.ReadLine();
                if (!string.IsNullOrEmpty(diachi)) kh.Diachi = diachi;
                Console.SetCursorPosition(27, 15); Console.Write("Nhập Số Điện Thoại Mới :");
                string sdt = Console.ReadLine();
                if (!string.IsNullOrEmpty(sdt)) kh.SDT = sdt;
                KH.SuaKhachHang(kh);
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
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                            Xóa Thông Tin Khách Hàng                       ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15); Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<Khachhang> list = KH.GetAllKhachHang();
            string Maxoa;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Khách Hàng Cần Xóa:");
            Maxoa = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Makh == Maxoa) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(27, 11); Console.Write("Xóa Thành Công.....");
                KH.XoaKhachHang(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 11); Console.Write("Không Tồn Tại Mã Khách Hàng Nay.....");
                Console.ReadKey();
            }
        }
        public void Menukh()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5); Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 6); Console.Write("║                         CHƯƠNG TRÌNH QUẢN LÝ CỦA HÀNG                     ║");
                Console.SetCursorPosition(20, 7); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 8); Console.Write("║                          QUẢN LÝ THÔNG TIN KHÁCH HÀNG                     ║");
                Console.SetCursorPosition(20, 9); Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 10);Console.Write("║    F1    ║            Thêm thông tin khách hàng                           ║");
                Console.SetCursorPosition(20, 11);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 12);Console.Write("║    F2    ║            Sửa thông tin khách hàng                            ║");
                Console.SetCursorPosition(20, 13);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 14);Console.Write("║    F3    ║            Xóa thông tin khách hàng                            ║");
                Console.SetCursorPosition(20, 15);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 16);Console.Write("║    F4    ║            Hiện thông tin khách hàng                           ║");
                Console.SetCursorPosition(20, 17);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 18);Console.Write("║    F5    ║            Quay lại MENU                                       ║");
                Console.SetCursorPosition(20, 19);Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 20);Console.Write("║  Mời bạn chọn chức năng :                                                 ║");
                Console.SetCursorPosition(20, 21);Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(48, 20);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Nhap();
                        Hien();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F2:
                        Sua();
                        Hien();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F3:
                        Xoa();
                        Hien();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F4:
                        Hien();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F5:
                        GiaoDien t = new GiaoDien();
                        t.Menu();
                        break;
                }
            } while (true);
        }
    }
}