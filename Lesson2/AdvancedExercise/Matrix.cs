using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExercise
{
    class Matrix
    {
        private int[,] matrix;
        private int m;
        private int n;

        public Matrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            matrix = new int[m, n];
        }

        public void NhapMaTran()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhập phần tử ở hàng {i + 1}, cột {j + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int phanTu))
                    {
                        matrix[i, j] = phanTu;
                    }
                    else
                    {
                        Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập một số nguyên.");
                        j--; // Lặp lại cột này
                    }
                }
            }
        }

        public void InMaTran()
        {
            Console.WriteLine("Ma trận:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void TimMinMaxMatrix(out int min, out int max, out int[] minIndex, out int[] maxIndex)
        {
            min = int.MaxValue;
            max = int.MinValue;
            minIndex = new int[2];
            maxIndex = new int[2];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }
        }

        public void TimMinMaxHang(out int[] minValues, out int[] maxValues, out int[] minIndices, out int[] maxIndices)
        {
            minValues = new int[m];
            maxValues = new int[m];
            minIndices = new int[m];
            maxIndices = new int[m];

            for (int i = 0; i < m; i++)
            {
                minValues[i] = int.MaxValue;
                maxValues[i] = int.MinValue;
                minIndices[i] = -1;
                maxIndices[i] = -1;

                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minValues[i])
                    {
                        minValues[i] = matrix[i, j];
                        minIndices[i] = j;
                    }
                    if (matrix[i, j] > maxValues[i])
                    {
                        maxValues[i] = matrix[i, j];
                        maxIndices[i] = j;
                    }
                }
            }
        }

        public void TimMinMaxDuongCheoChinh(out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < Math.Min(m, n); i++)
            {
                if (matrix[i, i] < min)
                    min = matrix[i, i];
                if (matrix[i, i] > max)
                    max = matrix[i, i];
            }
        }

        public int TimPhanTuXuatHienNhieuNhatTrongDong(int rowIndex)
        {
            int[] counts = new int[n];
            int maxCount = 0;
            int mostFrequentElement = matrix[rowIndex, 0];

            for (int j = 0; j < n; j++)
            {
                int currentElement = matrix[rowIndex, j];
                counts[currentElement]++;

                if (counts[currentElement] > maxCount)
                {
                    maxCount = counts[currentElement];
                    mostFrequentElement = currentElement;
                }
            }

            return mostFrequentElement;
        }
    }
}
//class Program
//{
//    static void Main()
//    {
//        Matrix maTran = null;

//        do
//        {
//            Console.WriteLine("---------------------------");
//            Console.WriteLine("1. Nhập ma trận");
//            Console.WriteLine("2. In ma trận");
//            Console.WriteLine("3. Tìm min, max trong ma trận");
//            Console.WriteLine("4. Tìm min, max trong từng hàng");
//            Console.WriteLine("5. Tìm min, max trong đường chéo chính");
//            Console.WriteLine("6. Tìm giá trị xuất hiện nhiều nhất trong dòng");
//            Console.WriteLine("0. Thoát");
//            Console.WriteLine("---------------------------");
//            Console.Write("Nhập lựa chọn của bạn: ");

//            int choice;
//            if (int.TryParse(Console.ReadLine(), out choice))
//            {
//                switch (choice)
//                {
//                    case 0:
//                        {
//                            Console.WriteLine("Tạm biệt!");
//                            Environment.Exit(0);
//                            break;
//                        }
//                    case 1:
//                        {
//                            Console.Write("Nhập số hàng (m): ");
//                            if (int.TryParse(Console.ReadLine(), out int m) && m > 0)
//                            {
//                                Console.Write("Nhập số cột (n): ");
//                                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//                                {
//                                    maTran = new MaTran(m, n);
//                                    maTran.NhapMaTran();
//                                    Console.WriteLine("Nhập ma trận thành công!");
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Số cột không hợp lệ.");
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("Số hàng không hợp lệ.");
//                            }
//                            break;
//                        }
//                    case 2:
//                        {
//                            if (maTran != null)
//                            {
//                                maTran.InMaTran();
//                            }
//                            else
//                            {
//                                Console.WriteLine("Bạn chưa nhập ma trận.");
//                            }
//                            break;
//                        }
//                    case 3:
//                        {
//                            if (maTran != null)
//                            {
//                                int min, max;
//                                int[] minIndex, maxIndex;
//                                maTran.TimMinMaxMatrix(out min, out max, out minIndex, out maxIndex);

//                                Console.WriteLine("Số nhỏ nhất trong ma trận: " + min + " (tại vị trí " + minIndex[0] + ", " + minIndex[1] + ")");
//                                Console.WriteLine("Số lớn nhất trong ma trận: " + max + " (tại vị trí " + maxIndex[0] + ", " + maxIndex[1] + ")");
//                            }
//                            else
//                            {
//                                Console.WriteLine("Bạn chưa nhập ma trận.");
//                            }
//                            break;
//                        }
//                    case 4:
//                        {
//                            if (maTran != null)
//                            {
//                                int[] minValues, maxValues, minIndices, maxIndices;
//                                maTran.TimMinMaxHang(out minValues, out maxValues, out minIndices, out maxIndices);

//                                for (int i = 0; i < maTran.M; i++)
//                                {
//                                    Console.WriteLine("Số nhỏ nhất trong hàng " + i + ": " + minValues[i] + " (tại vị trí " + i + ", " + minIndices[i] + ")");
//                                    Console.WriteLine("Số lớn nhất trong hàng " + i + ": " + maxValues[i] + " (tại vị trí " + i + ", " + maxIndices[i] + ")");
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("Bạn chưa nhập ma trận.");
//                            }
//                            break;
//                        }
//                    case 5:
//                        {
//                            if (maTran != null)
//                            {
//                                int minDuongCheoChinh, maxDuongCheoChinh;
//                                maTran.TimMinMaxDuongCheoChinh(out minDuongCheoChinh, out maxDuongCheoChinh);

//                                Console.WriteLine("Số nhỏ nhất trong đường chéo chính: " + minDuongCheoChinh);
//                                Console.WriteLine("Số lớn nhất trong đường chéo chính: " + maxDuongCheoChinh);
//                            }
//                            else
//                            {
//                                Console.WriteLine("Bạn chưa nhập ma trận.");
//                            }
//                            break;
//                        }
//                    case 6:
//                        {
//                            if (maTran != null)
//                            {
//                                Console.Write("Nhập dòng (0-" + (maTran.M - 1) + ") để tìm giá trị xuất hiện nhiều nhất: ");
//                                if (int.TryParse(Console.ReadLine(), out int dong) && dong >= 0 && dong < maTran.M)
//                                {
//                                    int phanTuXuatHienNhieuNhat = maTran.TimPhanTuXuatHienNhieuNhatTrongDong(dong);
//                                    Console.WriteLine("Giá trị xuất hiện nhiều nhất trong dòng " + dong + ": " + phanTuXuatHienNhieuNhat);
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Dòng không hợp lệ.");
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("Bạn chưa nhập ma trận.");
//                            }
//                            break;
//                        }
//                    default:
//                        {
//                            Console.WriteLine("Lựa chọn không hợp lệ. Hãy thử lại!");
//                            break;
//                        }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Lựa chọn không hợp lệ. Hãy thử lại!");
//            }

//            Console.WriteLine("Nhấn Enter để tiếp tục...");
//            Console.ReadLine();
//            Console.Clear(); // Xóa màn hình để hiển thị lại menu
//        } while (true);
//    }
//}