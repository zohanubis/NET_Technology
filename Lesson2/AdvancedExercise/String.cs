using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Ex
{
    public class String
    {
        public static string XoaKhoangTrangThua(string chuoi)
        {
            // Xóa khoảng trắng thừa ở đầu và cuối chuỗi
            chuoi = chuoi.Trim();

            // Xóa khoảng trắng thừa giữa các từ trong chuỗi
            while (chuoi.Contains("  "))
            {
                chuoi = chuoi.Replace("  ", " ");
            }

            return chuoi;
        }

        public static int DemSoTu(string chuoi)
        {
            // Xóa khoảng trắng thừa trong chuỗi
            chuoi = XoaKhoangTrangThua(chuoi);

            // Nếu chuỗi rỗng, không có từ
            if (string.IsNullOrEmpty(chuoi))
            {
                return 0;
            }

            // Sử dụng phương thức Split để tách các từ trong chuỗi
            string[] tu = chuoi.Split(' ');

            return tu.Length;
        }

        public static string LayHo(string hoTen)
        {
            // Xóa khoảng trắng thừa trong chuỗi
            hoTen = XoaKhoangTrangThua(hoTen);

            // Tìm vị trí khoảng trắng đầu tiên
            int viTriKhoangTrang = hoTen.IndexOf(' ');

            if (viTriKhoangTrang != -1)
            {
                // Trả về phần tử từ đầu chuỗi cho đến vị trí khoảng trắng đầu tiên
                return hoTen.Substring(0, viTriKhoangTrang);
            }

            // Nếu không có khoảng trắng, trả về chuỗi hoàn chỉnh
            return hoTen;
        }

        public static string LayTen(string hoTen)
        {
            // Xóa khoảng trắng thừa trong chuỗi
            hoTen = XoaKhoangTrangThua(hoTen);

            // Tìm vị trí khoảng trắng cuối cùng
            int viTriKhoangTrangCuoiCung = hoTen.LastIndexOf(' ');

            if (viTriKhoangTrangCuoiCung != -1)
            {
                // Trả về phần tử từ vị trí khoảng trắng cuối cùng cho đến cuối chuỗi
                return hoTen.Substring(viTriKhoangTrangCuoiCung + 1);
            }

            // Nếu không có khoảng trắng, trả về chuỗi hoàn chỉnh
            return hoTen;
        }

        public static string LayHoLot(string hoTen)
        {
            // Xóa khoảng trắng thừa trong chuỗi
            hoTen = XoaKhoangTrangThua(hoTen);

            // Tìm vị trí khoảng trắng đầu tiên và cuối cùng
            int viTriKhoangTrangDauTien = hoTen.IndexOf(' ');
            int viTriKhoangTrangCuoiCung = hoTen.LastIndexOf(' ');

            if (viTriKhoangTrangDauTien != -1 && viTriKhoangTrangCuoiCung != -1 && viTriKhoangTrangDauTien != viTriKhoangTrangCuoiCung)
            {
                // Trả về phần tử từ vị trí khoảng trắng đầu tiên cho đến vị trí khoảng trắng cuối cùng
                return hoTen.Substring(viTriKhoangTrangDauTien + 1, viTriKhoangTrangCuoiCung - viTriKhoangTrangDauTien - 1);
            }

            // Nếu không có khoảng trắng hoặc chỉ có một khoảng trắng, trả về chuỗi rỗng
            return string.Empty;
        }
    }
}
