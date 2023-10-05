using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Advanced_Ex1
{
    public partial class Advanced_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";
        public Advanced_Ex1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Advanced_Ex1_FormClosing);
        }
        private void Advanced_Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string maSinhVien = txtMaSV.Text;
            string hoTenSV = txtHoTen.Text;
            string ngaySinhStr = txtNgaySinh.Text;

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(hoTenSV) || string.IsNullOrEmpty(ngaySinhStr))
            {
                MessageBox.Show("Mã lớp, mã sinh viên, họ tên và ngày sinh của sinh viên không được bỏ trống.");
                return;
            }

            if (!DateTime.TryParse(ngaySinhStr, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng yyyy/MM/dd.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO SinhVien (MaLop, MaSinhVien, HoTen, NgaySinh) VALUES (@MaLop, @MaSinhVien, @HoTen, @NgaySinh)";

                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@HoTen", hoTenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSV.Text;

            if (string.IsNullOrEmpty(maSinhVien))
            {
                MessageBox.Show("Mã sinh viên không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();

                    string deleteString = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                    SqlCommand cmd = new SqlCommand(deleteString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa thành công");
            }catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công" +ex.Message );
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string maSinhVien = txtMaSV.Text;
            string hoTenSV = txtHoTen.Text;
            string ngaySinhStr = txtNgaySinh.Text;

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(hoTenSV) || string.IsNullOrEmpty(ngaySinhStr))
            {
                MessageBox.Show("Mã lớp, mã sinh viên, họ tên và ngày sinh của sinh viên không được bỏ trống.");
                return;
            }
            if (!DateTime.TryParse(ngaySinhStr, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng yyyy/MM/dd.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();

                    string updateString = "UPDATE SinhVien SET MaLop = @MaLop, HoTen = @HoTen, NgaySinh = @NgaySinh WHERE MaSinhVien = @MaSinhVien";
                    SqlCommand cmd = new SqlCommand(updateString, conStr);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@HoTen", hoTenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }
    }
}
