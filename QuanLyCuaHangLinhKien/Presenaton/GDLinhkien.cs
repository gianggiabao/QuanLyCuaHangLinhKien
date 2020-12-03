using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangLinhKien.BusinessLayer;
using QuanLyCuaHangLinhKien.Entities;
namespace QuanLyCuaHangLinhKien.Presenaton
{
   public class GDLinhkien
    {
        private ILinhkienBLL LK = new LinhkienBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                         Thêm Thông Tin Linh Kiện                          ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15);Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            Linhkien lk = new Linhkien();           
            Console.SetCursorPosition(27, 8); Console.Write("Nhập Mã Linh Kiện: ");
            lk.Malk = Console.ReadLine();
            Console.SetCursorPosition(27, 10); Console.Write("Nhập Tên Linh Kiện: ");
            lk.Tenlk = Console.ReadLine();
            Console.SetCursorPosition(27, 12); Console.Write("Nhập Giá Linh Kiện: ");
            lk.Gia = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(27, 14); Console.Write("Nhập Số Lượng Linh Kiện: ");
            lk.Soluong = int.Parse(Console.ReadLine());           
            LK.ThemLinhkien(lk); 
        }
        public void Hien()
        {
            Console.Clear();
            Console.SetCursorPosition(13, 5); Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(13, 6); Console.WriteLine("║                                  Hiện Thông Tin Linh Kiện                               ║");
            Console.SetCursorPosition(13, 7); Console.WriteLine("╠═══════════════════════════╦═══════════════╦═══════════════╦═══════════════╦═════════════╣");
            Console.SetCursorPosition(13, 8); Console.WriteLine("║         Ngày Giờ          ║  Mã Linh Kiện ║ Tên Linh Kiện ║    Giá Bán    ║  Số Lượng   ║");
            Console.SetCursorPosition(13, 9); Console.WriteLine("╠═══════════════════════════╬═══════════════╬═══════════════╬═══════════════╬═════════════╣");        
            List<Linhkien> List = LK.GetAllLinhkien();
            foreach (var lk in List)
            Console.WriteLine("\t     ║ " + lk.Ngaygio+ "\t ║      " + lk.Malk + "\t ║     " + lk.Tenlk + "\t ║     " + lk.Gia + "\t ║     " + lk.Soluong);
            Console.SetCursorPosition(13, 18);Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(15, 20);Console.Write("Nhập Phím Bất Kỳ Để Tiếp Tục...");
        }
        public void Sua()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                        Sửa Thông Tin Linh Kiện                            ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 16);Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<Linhkien> list = LK.GetAllLinhkien();
            string Masua;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Linh Kiện Cần Sửa:");
            Masua = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i) 
                if (list[i].Malk == Masua) break;
            if (i < list.Count)
            {
                    Linhkien lk = new Linhkien(list[i]);
                    Console.SetCursorPosition(27, 11); Console.Write("Nhập Tên Linh Kiện Mới :");
                    string ten = Console.ReadLine();
                    if (!string.IsNullOrEmpty(ten)) lk.Tenlk = ten;
                    Console.SetCursorPosition(27, 13); Console.Write("Nhập Giá Linh Kiện Mới :");
                    int gia = int.Parse(Console.ReadLine());
                    if (gia > 0) lk.Gia = gia;
                    Console.SetCursorPosition(27, 15); Console.Write("Nhập Số Lượng Linh Kiện Mới :");
                    int soluong = int.Parse(Console.ReadLine());
                    if (soluong > 0) lk.Soluong = soluong;
                    LK.SuaLinhkien(lk);
            }
            else
            {
                Console.SetCursorPosition(27,11); Console.Write("Không tồn tại mã linh kiện này.....");
                Console.ReadKey();
            }    
        }
        public void Xoa()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(25, 6); Console.WriteLine("║                        Xóa Thông Tin Linh Kiện                            ║");
            Console.SetCursorPosition(25, 7); Console.WriteLine("╠═══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(25, 15);Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            List<Linhkien> list = LK.GetAllLinhkien();
            string Maxoa;
            Console.SetCursorPosition(27, 9); Console.Write("Nhập Mã Linh Kiện Cần Xóa:");
            Maxoa = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Malk == Maxoa) break;
            if(i<list.Count)
            {
                Console.SetCursorPosition(27, 11); Console.Write("Xóa Thành Công....."); 
                LK.XoaLinhkien(Maxoa);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(27, 11); Console.Write("Không Tồn Tại Mã Linh Kiện Nay.....");
                Console.ReadKey();
            }    
        }
        public void Timkiem()
        {
            Console.Clear();         
            Console.SetCursorPosition(20, 5); Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(20, 6); Console.WriteLine("║                                 Tìm Kiếm Linh Kiện                                 ║");
            Console.SetCursorPosition(20, 7); Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════════════╣");
            ILinhkienBLL lk = new LinhkienBLL();
            List<Linhkien> list = lk.TimLinhkien(new Linhkien());
            string matim;
            Console.SetCursorPosition(20, 8); Console.Write("║ Nhập mã Linh Kiện cần tìm:                                                         ║");
            Console.SetCursorPosition(48,8);
            matim = Console.ReadLine();
            int i;
            for ( i=0; i < list.Count; ++i)
                if (matim == list[i].Malk) break;
            if (i < list.Count)
            {
                Console.SetCursorPosition(20, 9);  Console.WriteLine("╠═══════════════════════╦═════════════╦═══════════════╦═══════════════╦══════════════╣");
                Console.SetCursorPosition(20, 10); Console.WriteLine("║        Ngày Giờ       ║ Mã Linh Kiện║ Tên Linh Kiện ║    Giá Bán    ║   Số Lượng   ║");
                Console.SetCursorPosition(20, 11); Console.WriteLine("╠═══════════════════════╬═════════════╬═══════════════╬═══════════════╬══════════════╣");
                Console.SetCursorPosition(20, 12); Console.WriteLine("║ " + list[i].Ngaygio + "  ║   " + list[i].Malk + "\t  ║    " + list[i].Tenlk + "\t  ║    " + list[i].Gia + "\t  ║    " + list[i].Soluong);
                Console.SetCursorPosition(20, 13); Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(22, 15); Console.Write("Nhấn phím bất kỳ để tiếp tục.....");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(22,11); Console.Write("Không tồn tại mã linh kiện nay....");            
                Console.SetCursorPosition(20, 15); Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(55, 11);
                Console.ReadKey();
            }        
        }
        public void Menusp()
        {
            do
            {
                Console.Clear();               
                Console.SetCursorPosition(20, 5);  Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(20, 6);  Console.Write("║                         CHƯƠNG TRÌNH QUẢN LÝ CỦA HÀNG                     ║");
                Console.SetCursorPosition(20, 7);  Console.Write("╠═══════════════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 8);  Console.Write("║                          QUẢN LÝ THÔNG TIN LINH KIỆN                      ║");
                Console.SetCursorPosition(20, 9);  Console.Write("╠══════════╦════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 10); Console.Write("║     1    ║            Thêm thông tin linh kiện                            ║");
                Console.SetCursorPosition(20, 11); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 12); Console.Write("║     2    ║            Sửa thông tin linh kiện                             ║");
                Console.SetCursorPosition(20, 13); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 14); Console.Write("║     3    ║            Xóa thông tin linh kiện                             ║");
                Console.SetCursorPosition(20, 15); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 16); Console.Write("║     4    ║            Hiện thông tin linh kiện                            ║");
                Console.SetCursorPosition(20, 17); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 18); Console.Write("║     5    ║            Tìm Kiếm thông tin linh kiện                        ║");
                Console.SetCursorPosition(20, 19); Console.Write("╠══════════╬════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 20); Console.Write("║     6    ║            Quay lại MENU                                       ║");
                Console.SetCursorPosition(20, 21); Console.Write("╠══════════╩════════════════════════════════════════════════════════════════╣");
                Console.SetCursorPosition(20, 22); Console.Write("║  Mời bạn chọn chức năng :                                                 ║");
                Console.SetCursorPosition(20, 23); Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(48, 22);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch(kt.KeyChar)
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
