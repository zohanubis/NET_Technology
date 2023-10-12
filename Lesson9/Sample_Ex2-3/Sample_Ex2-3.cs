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

namespace Sample_Ex2_3
{
    public partial class SampleEx23 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public SampleEx23()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            string tenKhoa = txtTenKhoa.Text;

            // Thêm dữ liệu vào DataTable
            DataRow newRow = table.NewRow();
            newRow["MaKhoa"] = maKhoa;
            newRow["TenKhoa"] = tenKhoa;
            table.Rows.Add(newRow);

            try
            {
                connection.Open();
                dataAdapter.Update(table);
                MessageBox.Show("Thêm dữ liệu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string selectedMaKhoa = dataGridView1.SelectedRows[0].Cells["MaKhoa"].Value.ToString();

                // Xóa dòng đang chọn trong DataTable
                DataRow[] rows = table.Select($"MaKhoa = '{selectedMaKhoa}'");
                if (rows.Length > 0)
                    rows[0].Delete();

                try
                {
                    connection.Open();
                    dataAdapter.Update(table);
                    MessageBox.Show("Xóa dữ liệu thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Lấy mã khoa của dòng đang chọn
                string selectedMaKhoa = dataGridView1.SelectedRows[0].Cells["MaKhoa"].Value.ToString();

                // Lấy thông tin mới từ TextBoxes
                string newMaKhoa = txtMaKhoa.Text;
                string newTenKhoa = txtTenKhoa.Text;

                // Cập nhật thông tin trong DataTable
                DataRow[] rows = table.Select($"MaKhoa = '{selectedMaKhoa}'");
                if (rows.Length > 0)
                {
                    rows[0]["MaKhoa"] = newMaKhoa;
                    rows[0]["TenKhoa"] = newTenKhoa;
                }

                try
                {
                    connection.Open();
                    dataAdapter.Update(table);
                    MessageBox.Show("Cập nhật dữ liệu thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SampleEx23_Load(object sender, EventArgs e)
        {
            // Khởi tạo kết nối
            connection = new SqlConnection(connectionString);

            // Khởi tạo DataAdapter và DataTable
            dataAdapter = new SqlDataAdapter("SELECT * FROM Khoa", connection);

            table = new DataTable();

            // Tự động tạo lệnh Insert, Update, Delete từ DataAdapter
            new SqlCommandBuilder(dataAdapter);

            // Đổ dữ liệu từ DB vào DataTable
            dataAdapter.Fill(table);

            // Hiển thị dữ liệu trên DataGridView
            dataGridView1.DataSource = table;
        }
    }
}
