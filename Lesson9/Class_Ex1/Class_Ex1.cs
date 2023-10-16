using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Class_Ex1
{
    public partial class Class_Ex1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Class_Ex1()
        {
            InitializeComponent();
        }

        private void Class_Ex1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();
            LoadDataToComboBoxLop();

            LoadDataToDataGridView();
        }

        private void LoadDataToComboBoxLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Tạo một DataTable mới
                DataTable lopTable = new DataTable();

                // Truy vấn lấy danh sách lớp
                string query = "SELECT MaLop, TenLop FROM Lop";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(lopTable);

                // Thêm "Tất cả lớp" vào đầu danh sách
                DataRow allLopRow = lopTable.NewRow();
                allLopRow["MaLop"] = "";
                allLopRow["TenLop"] = "Tất cả lớp";
                lopTable.Rows.InsertAt(allLopRow, 0);

                // Gán danh sách lớp làm nguồn dữ liệu cho ComboBox
                comboBoxLop.DataSource = lopTable;
                comboBoxLop.DisplayMember = "TenLop";
                comboBoxLop.ValueMember = "MaLop";
            }
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien", connection);
                dataAdapter.SelectCommand = cmd;
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLop.SelectedValue == null) return;

            string selectedLop = comboBoxLop.SelectedValue.ToString();


            DataView dv = new DataView(table);

            if (selectedLop == "")
            {

                dataGridView.DataSource = table;
            }
            else // Chọn một lớp cụ thể
            {
                dv.RowFilter = $"MaLop = '{selectedLop}'";
                dataGridView.DataSource = dv;
            }
        }



        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string tenSinhVien = txtTenSinhVien.Text;
            string maLop = comboBoxLop.SelectedValue.ToString();

            // Kiểm tra mã sinh viên đã tồn tại
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemTraTonTai = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                SqlCommand kiemTraTonTaiCMD = new SqlCommand(kiemTraTonTai, connection);
                kiemTraTonTaiCMD.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                int existingCount = (int)kiemTraTonTaiCMD.ExecuteScalar();

                if (existingCount > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng chọn mã sinh viên khác.");
                    return;
                }
            }

            // Kiểm tra khóa ngoại
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkLopExistQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
                SqlCommand checkLopExistCommand = new SqlCommand(checkLopExistQuery, connection);
                checkLopExistCommand.Parameters.AddWithValue("@MaLop", maLop);
                int lopExistingCount = (int)checkLopExistCommand.ExecuteScalar();

                if (lopExistingCount == 0)
                {
                    MessageBox.Show("Mã lớp không tồn tại. Vui lòng chọn mã lớp khác.");
                    return;
                }
            }

            // Thực hiện thêm sinh viên
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO SinhVien (MaSinhVien, HoTen, MaLop) " +
                               "VALUES (@MaSinhVien, @TenSinhVien, @MaLop)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                command.Parameters.AddWithValue("@MaLop", maLop);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sinh viên đã được thêm thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sinh viên. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string tenSinhVien = txtTenSinhVien.Text;
            string maLop = comboBoxLop.SelectedValue.ToString(); // Lấy Mã lớp từ ComboBox

            // Kiểm tra xem sinh viên có tồn tại không
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string ktTonTaiQuery = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                SqlCommand kiemTraTonTaiCMD = new SqlCommand(ktTonTaiQuery, connection);
                kiemTraTonTaiCMD.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                int existingCount = (int)kiemTraTonTaiCMD.ExecuteScalar();

                if (existingCount == 0)
                {
                    MessageBox.Show("Sinh viên không tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }
            }

            // Kiểm tra mã lớp (khóa ngoại) tồn tại
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkLopExistQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
                SqlCommand checkLopExistCommand = new SqlCommand(checkLopExistQuery, connection);
                checkLopExistCommand.Parameters.AddWithValue("@MaLop", maLop);
                int lopExistingCount = (int)checkLopExistCommand.ExecuteScalar();

                if (lopExistingCount == 0)
                {
                    MessageBox.Show("Mã lớp không tồn tại. Vui lòng chọn mã lớp khác.");
                    return;
                }
            }

            // Thực hiện cập nhật thông tin sinh viên
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string editQuery = "UPDATE SinhVien " +
                               "SET HoTen = @TenSinhVien, MaLop = @MaLop " +
                               "WHERE MaSinhVien = @MaSinhVien";

                SqlCommand command = new SqlCommand(editQuery, connection);
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                command.Parameters.AddWithValue("@MaLop", maLop);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thông tin sinh viên đã được cập nhật thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin sinh viên. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;

            // Kiểm tra xem sinh viên có tồn tại không
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string ktTonTaiQuery = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                SqlCommand kiemTraTonTaiCMD = new SqlCommand(ktTonTaiQuery, connection);
                kiemTraTonTaiCMD.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                int existingCount = (int)kiemTraTonTaiCMD.ExecuteScalar();

                if (existingCount == 0)
                {
                    MessageBox.Show("Sinh viên không tồn tại. Vui lòng kiểm tra lại.");
                    return;
                }
            }

            // Thực hiện xóa sinh viên
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sinh viên đã được xóa thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể xóa sinh viên. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtMaSinhVien.Text = row.Cells["MaSinhVien"].Value.ToString();
                txtTenSinhVien.Text = row.Cells["HoTen"].Value.ToString();
                comboBoxLop.SelectedValue = row.Cells["MaLop"].Value;

                //txtNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }

    }
}
