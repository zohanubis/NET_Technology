using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            do {
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Xóa khoảng trắng thừa");
                Console.WriteLine("2. Số lượng từ trong chuỗi");
                Console.WriteLine("3. Họ");
                Console.WriteLine("4. Tên");
                Console.WriteLine("5. Họ lót");
                Console.WriteLine("---------------------------");
                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Goodbye!");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            string chuoiDaXoaKhoangTrangThua = String.XoaKhoangTrangThua(hoTen);
                            Console.WriteLine("Chuỗi sau khi xóa khoảng trắng thừa: {0}", chuoiDaXoaKhoangTrangThua);
                            break;
                        }
                    case 2:
                        {
                            int soLuongTu = String.DemSoTu(hoTen);
                            Console.WriteLine("Số lượng từ trong chuỗi: {0}", soLuongTu);
                            break;
                        }
                    case 3:
                        {
                            string ho = String.LayHo(hoTen);
                            Console.WriteLine("Họ: {0}", ho);
                            break;
                        }
                    case 4:
                        {
                            string ten = String.LayTen(hoTen);
                            Console.WriteLine("Tên: {0}", ten);
                            break;
                        }
                    case 5:
                        {
                            string hoLot = String.LayHoLot(hoTen);
                            if (!string.IsNullOrEmpty(hoLot))
                            {
                                Console.WriteLine("Họ lót: {0}", hoLot);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again!");
                            break;
                        }
                }
            } while (true);
        }
    }
}
