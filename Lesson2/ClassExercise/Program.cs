using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Array");
                Console.WriteLine("2. Matrix");
                Console.WriteLine("3. String");
                Console.WriteLine("-----------------------------");
                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter the size of the array: ");
                            int size = int.Parse(Console.ReadLine());

                            int[] arr = new int[size];
                            do {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("1. Input Array / Print Array");
                                Console.WriteLine("2. Enumerate (print) the odd elements at even positions.");
                                Console.WriteLine("3. Enumerate the prime numbers in the array");
                                Console.WriteLine("4. Find the first negative element in the array");
                                Console.WriteLine("5. Find max/min int the array");
                                Console.WriteLine("6. Calculate the sum of all elements in the array.");
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.Write("Enter your choice : ");
                                int choice1 = int.Parse(Console.ReadLine());
                                switch (choice1) 
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
                                            Array.InputArray(arr);
                                            Console.WriteLine();

                                            Array.PrintArray(arr);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Array.PrintEvenElements(arr);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Array.PrintPrimeElements(arr);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            int firstNegative = Array.FindFirstNegativeElement(arr);
                                            if (firstNegative != 0)
                                                Console.WriteLine("First negative element : {0}", firstNegative);
                                            else
                                            {
                                                Console.WriteLine("No negative element found.");
                                            }
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 5:
                                        {
                                            int max = Array.FindMaxElement(arr);
                                            int min = Array.FindMinElement(arr);

                                            Console.WriteLine("Maximum element: {0}", max);
                                            Console.WriteLine("Minimum element: {0}", min);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 6:
                                        {
                                            int sum = Array.CalculateSum(arr);
                                            Console.WriteLine("Sum of elements: {0}", sum);
                                            Console.ReadLine();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid choice. Please try again!");
                                            break;
                                        }
                                } 
                            } while (true);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the number of rows (m) in the matrix: ");
                            int m = int.Parse(Console.ReadLine());

                            Console.Write("Enter the number of columns (n) in the matrix: ");
                            int n = int.Parse(Console.ReadLine());

                            int[,] matrix = new int[m, n];
                            do
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("1. Input Matrix / Print Matrix");
                                Console.WriteLine("2. Sum of all positive elements in the matrix");
                                Console.WriteLine("3. Sum of elements on the main diagonal.");
                                Console.WriteLine("4. Sum of elements in the upper triangle");
                                Console.WriteLine("5. Sum of all even elements in the matrix");
                                Console.WriteLine("6. Calculate the sum of elements in row i");
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.Write("Enter your choice : ");
                                int choice2 = int.Parse(Console.ReadLine());
                                switch (choice2)
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
                                            Matrix.InputMatrix(matrix);
                                            Console.WriteLine();
                                            Matrix.PrintMatrix(matrix);
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            int sumOfPositive = Matrix.SumOfPositiveElements(matrix);
                                            Console.WriteLine("Sum of positive elements in the matrix: {0}", sumOfPositive);
                                            break;
                                        }
                                    case 3:
                                        {
                                            int sumOfMainDiagonal = Matrix.SumOfMainDiagonalElements(matrix);
                                            Console.WriteLine("Sum of elements on the main diagonal: {0}", sumOfMainDiagonal);
                                            break;
                                        }
                                    case 4:
                                        {
                                            int sumOfUpperTriangle = Matrix.SumOfUpperTriangleElements(matrix);
                                            Console.WriteLine("Sum of elements in the upper triangle: {0}", sumOfUpperTriangle);
                                            break;

                                        }
                                    case 5:
                                        {
                                            int sumOfEven = Matrix.SumOfEvenElements(matrix);
                                            Console.WriteLine("Sum of even elements in the matrix: {0}", sumOfEven);
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Write("Enter the row index (i) to calculate the sum of elements: ");
                                            int row = int.Parse(Console.ReadLine());

                                            int sumOfRow = Matrix.SumOfRowElements(matrix, row);
                                            Console.WriteLine("Sum of elements in row {0}: {1}", row, sumOfRow);
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid choice. Please try again!");
                                            break;
                                        }
                                }
                            } while (true);
                            break;
                        }
                    case 3:
                        {
                            int choice3;
                            Console.Write("Nhập một chuỗi: ");
                            string chuoi = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("1. Kiểm tra chuỗi đối xứng");
                                Console.WriteLine("2. Đổi ký tự đầu thành chữ in hoa");
                                Console.WriteLine("3. Đối ký tự thưởng thành chuỗi hoa và ngược lại");
                                Console.WriteLine("4. Có bao nhiêu nguyên âm, phụ âm, khoảng trắng trong chuỗi s");
                                Console.Write("Nhập lựa chọn : ");
                                choice3 = int.Parse(Console.ReadLine());
                                switch (choice3)
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
                                            bool laChuoiDoiXung = String.LaChuoiDoiXung(chuoi);
                                            Console.WriteLine("Chuỗi có phải là chuỗi đối xứng? {0}", laChuoiDoiXung);
                                            
                                            break;
                                        }
                                    case 2:
                                        {
                                            string chuoiVietHoaChuCaiDau = String.VietHoaChuCaiDau(chuoi);
                                            Console.WriteLine("Chuỗi với chữ cái đầu viết hoa: {0}", chuoiVietHoaChuCaiDau);
                                            break;
                                        }
                                    case 3:
                                        {
                                            string chuoiDoiChuHoaChuThuong = String.DoiChuHoaChuThuong(chuoi);
                                            Console.WriteLine("Chuỗi với chữ hoa và chữ thường đổi vị trí: {0}", chuoiDoiChuHoaChuThuong);
                                            break;
                                        }
                                    case 4:
                                        {
                                            int soLuongNguyenAm, soLuongPhuAm, soLuongKhoangTrang;
                                            String.DemNguyenAmPhuAmKhoangTrang(chuoi, out soLuongNguyenAm, out soLuongPhuAm, out soLuongKhoangTrang);
                                            Console.WriteLine("Số lượng nguyên âm: {0}", soLuongNguyenAm);
                                            Console.WriteLine("Số lượng phụ âm: {0}", soLuongPhuAm);
                                            Console.WriteLine("Số lượng khoảng trắng: {0}", soLuongKhoangTrang);
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid choice. Please try again!");
                                            break;
                                        }
                                }
                            } while (true);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Goodbye!");
                            Console.ReadLine();
                            Environment.Exit(0);
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
