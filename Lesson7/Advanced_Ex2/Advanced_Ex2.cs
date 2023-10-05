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

namespace Advanced_Ex2
{
    public partial class Advanced_Ex2 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Advanced_Ex2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Advanced_Ex2_FormClosing);

        }
        private void Advanced_Ex2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string maMonHoc = txtMaMH.Text;
            string diemStr = txtDiem.Text;

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Mã sinh viên, mã môn học và điểm không được để trống.");
                return;
            }

            if (!float.TryParse(diemStr, out float diem))
            {
                MessageBox.Show("Điểm không hợp lệ. Vui lòng nhập số.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES (@MaSinhVien, @MaMonHoc, @Diem)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm điểm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm điểm thất bại: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string maMonHoc = txtMaMH.Text;

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc))
            {
                MessageBox.Show("Mã sinh viên và mã môn học không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string deleteString = "DELETE FROM Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(deleteString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Xóa điểm thành công");
                    else
                        MessageBox.Show("Không tìm thấy dữ liệu để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa điểm thất bại: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string maMonHoc = txtMaMH.Text;
            string diemStr = txtDiem.Text;

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Mã sinh viên, mã môn học và điểm không được để trống.");
                return;
            }

            if (!float.TryParse(diemStr, out float diem))
            {
                MessageBox.Show("Điểm không hợp lệ. Vui lòng nhập số.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string updateString = "UPDATE Diem SET Diem = @Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(updateString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Cập nhật điểm thành công");
                    else
                        MessageBox.Show("Không tìm thấy dữ liệu để cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật điểm thất bại: " + ex.Message);
            }
        }
    }
}
