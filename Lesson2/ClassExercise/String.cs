using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class String
    {
        public static bool LaChuoiDoiXung(string chuoi)
        {
            int left = 0;
            int right = chuoi.Length - 1;

            while (left < right)
            {
                if (chuoi[left] != chuoi[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public static string VietHoaChuCaiDau(string chuoi)
        {
            if (string.IsNullOrEmpty(chuoi))
            {
                return chuoi;
            }

            string chuCaiDau = char.ToUpper(chuoi[0]).ToString();
            string phanConLaiCuaChuoi = chuoi.Substring(1);

            return chuCaiDau + phanConLaiCuaChuoi;
        }

        public static string DoiChuHoaChuThuong(string chuoi)
        {
            char[] mangKiTu = chuoi.ToCharArray();

            for (int i = 0; i < mangKiTu.Length; i++)
            {
                if (char.IsUpper(mangKiTu[i]))
                {
                    mangKiTu[i] = char.ToLower(mangKiTu[i]);
                }
                else if (char.IsLower(mangKiTu[i]))
                {
                    mangKiTu[i] = char.ToUpper(mangKiTu[i]);
                }
            }

            return new string(mangKiTu);
        }

        public static void DemNguyenAmPhuAmKhoangTrang(string chuoi, out int soLuongNguyenAm, out int soLuongPhuAm, out int soLuongKhoangTrang)
        {
            soLuongNguyenAm = 0;
            soLuongPhuAm = 0;
            soLuongKhoangTrang = 0;

            foreach (char kiTu in chuoi)
            {
                if (char.IsLetter(kiTu))
                {
                    if (LaNguyenAm(kiTu))
                    {
                        soLuongNguyenAm++;
                    }
                    else
                    {
                        soLuongPhuAm++;
                    }
                }
                else if (char.IsWhiteSpace(kiTu))
                {
                    soLuongKhoangTrang++;
                }
            }
        }

        private static bool LaNguyenAm(char kiTu)
        {
            char kiTuThuong = char.ToLower(kiTu);

            return kiTuThuong == 'a' || kiTuThuong == 'e' || kiTuThuong == 'i' || kiTuThuong == 'o' || kiTuThuong == 'u';
        }
    }
}
