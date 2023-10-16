using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Advanced
{
    public partial class Advanced : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QL_HangHoa;Integrated Security=True";

        public Advanced()
        {
            InitializeComponent();
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hang";
                dataAdapter = new SqlDataAdapter(query, conn);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView.DataSource = table;
            }
            LoadMaChatLieuComboBox();
        }

        private void LoadMaChatLieuComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaChatLieu, TenChatLieu FROM ChatLieu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Set the ComboBox data source and display member
                comboBoxChatLieu.DataSource = dt;
                comboBoxChatLieu.DisplayMember = "TenChatLieu";
                comboBoxChatLieu.ValueMember = "MaChatLieu";
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells["MaHang"].Value.ToString();
                txtTenHang.Text = row.Cells["TenHang"].Value.ToString();
                comboBoxChatLieu.SelectedValue = row.Cells["MaChatLieu"].Value;
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = row.Cells["DonGiaBan"].Value.ToString();
                txtAnh.Text = row.Cells["Hinh"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtTenHang.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = string.Format("TenHang LIKE '%{0}%'", searchText);
                dataGridView.DataSource = dv.ToTable();
            }
            else
            {
                dataGridView.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string maHang = txtMaHang.Text;
                string tenHang = txtTenHang.Text;
                string maChatLieu = comboBoxChatLieu.SelectedValue.ToString(); // Lấy Mã chất liệu từ ComboBox
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGiaNhap = decimal.Parse(txtDonGiaNhap.Text);
                decimal donGiaBan = decimal.Parse(txtDonGiaBan.Text);
                string hinh = txtAnh.Text;
                string ghiChu = txtGhiChu.Text;

                string query = "INSERT INTO Hang (MaHang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Hinh, GhiChu) " +
                               "VALUES (@MaHang, @TenHang, @MaChatLieu, @SoLuong, @DonGiaNhap, @DonGiaBan, @Hinh, @GhiChu)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaHang", maHang);
                command.Parameters.AddWithValue("@TenHang", tenHang);
                command.Parameters.AddWithValue("@MaChatLieu", maChatLieu);
                command.Parameters.AddWithValue("@SoLuong", soLuong);
                command.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                command.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                command.Parameters.AddWithValue("@Hinh", hinh);
                command.Parameters.AddWithValue("@GhiChu", ghiChu);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Mặt hàng đã được thêm thành công!");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm mặt hàng. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Hang WHERE MaHang = @MaHang";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaHang", maHang);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Mặt hàng đã được xóa thành công!");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể xóa mặt hàng. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string maChatLieu = comboBoxChatLieu.SelectedValue.ToString(); // Lấy Mã chất liệu từ ComboBox
            int soLuong = int.Parse(txtSoLuong.Text);
            decimal donGiaNhap = decimal.Parse(txtDonGiaNhap.Text);
            decimal donGiaBan = decimal.Parse(txtDonGiaBan.Text);
            string hinh = txtAnh.Text;
            string ghiChu = txtGhiChu.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Hang " +
                               "SET TenHang = @TenHang, MaChatLieu = @MaChatLieu, SoLuong = @SoLuong, " +
                               "DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, Hinh = @Hinh, GhiChu = @GhiChu " +
                               "WHERE MaHang = @MaHang";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaHang", maHang);
                command.Parameters.AddWithValue("@TenHang", tenHang);
                command.Parameters.AddWithValue("@MaChatLieu", maChatLieu);
                command.Parameters.AddWithValue("@SoLuong", soLuong);
                command.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                command.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                command.Parameters.AddWithValue("@Hinh", hinh);
                command.Parameters.AddWithValue("@GhiChu", ghiChu);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thông tin mặt hàng đã được cập nhật thành công!");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin mặt hàng. Vui lòng kiểm tra lại dữ liệu.");
                }
            }
        }

        private void RefreshDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hang";
                dataAdapter = new SqlDataAdapter(query, conn);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView.DataSource = table;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
