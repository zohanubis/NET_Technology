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

namespace Sample_Ex1
{
    public partial class Sample_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Sample_Ex1()
        {
            InitializeComponent();
        }

        private void Sample_Ex1_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }
        private void LoadDataToComboBox()
        {
            string selectQuery = "SELECT MaKhoa, TenKhoa FROM Khoa";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            comboBoxKhoa.DataSource = dataTable;
            comboBoxKhoa.DisplayMember = "TenKhoa";
            comboBoxKhoa.ValueMember = "MaKhoa";
        }
        private bool CheckMaLopUnique(string maLop)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            string maKhoa = comboBoxKhoa.SelectedValue.ToString();

            bool isMaLopValid = CheckMaLopUnique(maLop);

            if (!isMaLopValid)
            {
                MessageBox.Show("Mã lớp đã tồn tại. Vui lòng chọn mã lớp khác.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES (@MaLop, @TenLop, @MaKhoa)";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lớp đã được thêm thành công.");
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm lớp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        private bool CheckForeignKeyConstraint(string maLop)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM SinhVien WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                int count = (int)cmd.ExecuteScalar();

                return count == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;

            if (string.IsNullOrWhiteSpace(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa.");
                return;
            }

            bool isForeignKeyValid = CheckForeignKeyConstraint(maLop);

            if (!isForeignKeyValid)
            {
                MessageBox.Show("Khóa đã được sử dụng trong lớp. Không thể xóa.");
                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Lop WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lớp đã được xóa thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            string maKhoa = comboBoxKhoa.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp để sửa.");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string updateQuery = "UPDATE Lop SET TenLop = @TenLop, MaKhoa = @MaKhoa WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin lớp đã được cập nhật.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
