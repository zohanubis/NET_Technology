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

namespace Sample_Ex1
{
    public partial class Sample_Ex1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";
        public Sample_Ex1()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter("SELECT * FROM Khoa", connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            table = new DataTable();
            dataAdapter.Fill(table);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Bật các TextBox và nút "Lưu"
            EnableTextBoxes();
            btnSave.Enabled = true;

            // Đặt dấu nháy ở TextBox Mã khoa
            txtMaKhoa.Focus();
            txtMaKhoa.SelectAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Bật nút "Lưu"
            btnSave.Enabled = true;

            txtTenKhoa.Enabled = txtMaKhoa.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Chưa nhập Mã Khoa");
                txtMaKhoa.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Chưa nhập Tên Khoa");
                txtTenKhoa.Focus();
                return;
            }

            if (txtMaKhoa.Enabled) // Thêm
            {
                DataRow insertRow = table.NewRow();
                insertRow["MaKhoa"] = txtMaKhoa.Text;
                insertRow["TenKhoa"] = txtTenKhoa.Text;
                table.Rows.Add(insertRow);
            }
            else // Sửa
            {
                DataRow updateRow = table.Rows.Find(txtMaKhoa.Text);
                if (updateRow != null)
                {
                    updateRow["TenKhoa"] = txtTenKhoa.Text;
                }
            }

            // Cập nhật cơ sở dữ liệu
            dataAdapter.Update(table);

            // Hiển thị thông báo thành công
            MessageBox.Show("Thành công");

            btnSave.Enabled = txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
        }

        private void Sample_Ex1_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = table;
            dataGridView.ReadOnly = true;
            DisableTextBoxes();
            DisableButtons();
        }
        private void DisableTextBoxes()
        {
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
        }

        private void DisableButtons()
        {
            btnEdit.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
        }
        private void EnableTextBoxes()
        {
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = true;
        }

        private void EnableButtons()
        {
            btnEdit.Enabled = btnDelete.Enabled = btnSave.Enabled = true;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin tương ứng với hàng đã chọn
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();

                // Bật nút "Sửa" và "Xóa"
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
