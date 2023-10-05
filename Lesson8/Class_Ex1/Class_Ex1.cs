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
    
namespace Class_Ex1
{
    public partial class Class_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Class_Ex1()
        {
            InitializeComponent();
        }
        private void LoadLopComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT MaLop FROM Lop";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maLop = reader["MaLop"].ToString();
                        comboBoxLop.Items.Add(maLop);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSV.Text;
            string hoTenSV = txtHoTen.Text;
            string ngaySinhStr = txtNgaySinh.Text;
            string maLop = comboBoxLop.SelectedItem.ToString();

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(hoTenSV) || string.IsNullOrEmpty(ngaySinhStr) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Thông tin không được để trống.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                    SqlCommand cmd = new SqlCommand(checkQuery, con);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }

            DateTime ngaySinh;
            if (!DateTime.TryParse(ngaySinhStr, out ngaySinh) || CalculateAge(ngaySinh) < 17)
            {
                MessageBox.Show("Tuổi phải từ 17 tuổi trở lên.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string insertString = "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @MaLop)";
                    SqlCommand cmd = new SqlCommand(insertString, con);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@HoTen", hoTenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string deleteString = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                    SqlCommand cmd   = new SqlCommand(deleteString, con);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSV.Text;
            string hoTenSV = txtHoTen.Text;
            string ngaySinhStr = txtNgaySinh.Text;
            string maLop = comboBoxLop.SelectedItem.ToString();

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(hoTenSV) || string.IsNullOrEmpty(ngaySinhStr) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Thông tin không được để trống.");
                return;
            }

            // Kiểm tra tuổi
            DateTime ngaySinh;
            if (!DateTime.TryParse(ngaySinhStr, out ngaySinh) || CalculateAge(ngaySinh) < 17)
            {
                MessageBox.Show("Tuổi phải từ 17 tuổi trở lên.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string updateString = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, MaLop = @MaLop WHERE MaSinhVien = @MaSinhVien";
                    SqlCommand cmd = new SqlCommand(updateString, con);
                    cmd.Parameters.AddWithValue("@HoTen", hoTenSV);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Class_Ex1_Load(object sender, EventArgs e)
        {
            LoadLopComboBox();
        }
        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                age--;

            return age;
        }
    }
}
