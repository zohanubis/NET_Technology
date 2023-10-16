using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Class_Ex2
{
    public partial class Class_Ex2 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";
        public Class_Ex2()
        {
            InitializeComponent();
        }

        private void Class_Ex2_Load(object sender, EventArgs e)
        {
            LoadDataToComboBoxKhoa();
        }
        private void LoadDataToComboBoxKhoa()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tạo một DataTable mới
                    DataTable khoaTable = new DataTable();

                    // Truy vấn lấy danh sách khoa
                    string query = "SELECT MaKhoa, TenKhoa FROM Khoa";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(khoaTable);

                    // Thêm "Tất cả khoa" vào đầu danh sách
                    DataRow allKhoaRow = khoaTable.NewRow();
                    allKhoaRow["MaKhoa"] = "";
                    allKhoaRow["TenKhoa"] = "Tất cả khoa";
                    khoaTable.Rows.InsertAt(allKhoaRow, 0);

                    // Gán danh sách khoa làm nguồn dữ liệu cho ComboBox
                    comboBoxKhoa.DataSource = khoaTable;
                    comboBoxKhoa.DisplayMember = "TenKhoa";
                    comboBoxKhoa.ValueMember = "MaKhoa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadDataToDataGridView(string maKhoa = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn lấy danh sách lớp
                    string query = "";
                    if (maKhoa == "")
                    {
                        query = "SELECT * FROM Lop";
                    }
                    else
                    {
                        query = "SELECT * FROM Lop WHERE MaKhoa = @MaKhoa";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    if (maKhoa != "")
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    }

                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaKhoa = comboBoxKhoa.SelectedValue.ToString();

            if (selectedMaKhoa == "")
            {
                // Nếu chọn "Tất cả khoa", hiển thị toàn bộ danh sách lớp
                LoadDataToDataGridView();
            }
            else
            {
                // Nếu chọn một khoa cụ thể, hiển thị danh sách lớp của khoa đó
                LoadDataToDataGridView(selectedMaKhoa);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                string maLop = row.Cells["MaLop"].Value.ToString();
                string tenLop = row.Cells["TenLop"].Value.ToString();

                txtMaLop.Text = maLop;
                txtTenLop.Text = tenLop;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            string maKhoa = comboBoxKhoa.SelectedValue.ToString();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra khóa chính
                string checkExistQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
                SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, conn);
                checkExistCommand.Parameters.AddWithValue("@MaLop", maLop);

                int count = Convert.ToInt32(checkExistCommand.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Vui lòng chọn mã lớp khác.");
                    return;
                }

                // Kiểm tra khóa ngoại
                string checkForeignKeyQuery = "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @MaKhoa";
                SqlCommand checkForeignKeyCommand = new SqlCommand(checkForeignKeyQuery, conn);
                checkForeignKeyCommand.Parameters.AddWithValue("@MaKhoa", maKhoa);

                int foreignKeyCount = Convert.ToInt32(checkForeignKeyCommand.ExecuteScalar());
                if (foreignKeyCount == 0)
                {
                    MessageBox.Show("Mã khoa không tồn tại. Vui lòng chọn mã khoa khác.");
                    return;
                }

                // Thêm lớp
                string query = "INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES (@MaLop, @TenLop, @MaKhoa)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaLop", maLop);
                command.Parameters.AddWithValue("@TenLop", tenLop);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Lớp đã được thêm thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm lớp. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;

            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn lớp để xóa.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkExistQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
                SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, conn);
                checkExistCommand.Parameters.AddWithValue("@MaLop", maLop);

                int count = Convert.ToInt32(checkExistCommand.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Mã lớp không tồn tại. Vui lòng chọn mã lớp khác.");
                    return;
                }
                string query = "DELETE FROM Lop WHERE MaLop = @MaLop";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaLop", maLop);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Lớp đã được xóa thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể xóa lớp. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            string maKhoa = comboBoxKhoa.SelectedValue.ToString();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkExistQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
                SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, conn);
                checkExistCommand.Parameters.AddWithValue("@MaLop", maLop);

                int count = Convert.ToInt32(checkExistCommand.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Mã lớp không tồn tại. Vui lòng chọn mã lớp khác.");
                    return;
                }

                // Kiểm tra khóa ngoại
                string checkForeignKeyQuery = "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @MaKhoa";
                SqlCommand checkForeignKeyCommand = new SqlCommand(checkForeignKeyQuery, conn);
                checkForeignKeyCommand.Parameters.AddWithValue("@MaKhoa", maKhoa);

                int foreignKeyCount = Convert.ToInt32(checkForeignKeyCommand.ExecuteScalar());
                if (foreignKeyCount == 0)
                {
                    MessageBox.Show("Mã khoa không tồn tại. Vui lòng chọn mã khoa khác.");
                    return;
                }

                // Cập nhật lớp
                string query = "UPDATE Lop SET TenLop = @TenLop, MaKhoa = @MaKhoa WHERE MaLop = @MaLop";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaLop", maLop);
                command.Parameters.AddWithValue("@TenLop", tenLop);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thông tin lớp đã được cập nhật thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin lớp. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void TenSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void TenKhoa_Click(object sender, EventArgs e)
        {

        }

        private void MaSinhVien_Click(object sender, EventArgs e)
        {

        }
    }
}
