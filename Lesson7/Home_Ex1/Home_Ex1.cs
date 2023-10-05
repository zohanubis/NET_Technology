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

namespace Home_Ex1
{
    public partial class Home_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Home_Ex1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Home_FormClosing);

        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã khoa, mã lớp và tên lớp không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES (@MaKhoa, @MaLop, @TenLop)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@TenLop", tenLop);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm lớp thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lớp thất bại: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;

            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Mã lớp không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string deleteString = "DELETE FROM Lop WHERE MaLop = @MaLop";
                    SqlCommand cmd = new SqlCommand(deleteString, conStr);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Xóa lớp thành công");
                    else
                        MessageBox.Show("Không tìm thấy dữ liệu để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lớp thất bại: " + ex.Message);
            }
        }

        private void Home_Ex1_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string maKhoa = txtMaKhoa.Text;
            string tenLop = txtTenLop.Text;

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã lớp, mã khoa và tên lớp không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();

                    string updateString = "UPDATE Lop SET MaKhoa = @MaKhoa, TenLop = @TenLop WHERE MaLop = @MaLop";
                    SqlCommand cmd = new SqlCommand(updateString, conStr);
                    cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@TenLop", tenLop);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
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
