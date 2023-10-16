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
using System.Data;

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
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }
        private void LoadDataToComboBoxLop()
        {

            DataTable comboBoxDataTable = new DataTable();
            comboBoxDataTable.Columns.Add("MaLop", typeof(string));
            comboBoxDataTable.Columns.Add("TenLop", typeof(string));
            comboBoxDataTable.Rows.Add("All", "Tất cả lớp");

            string selectQuery = "SELECT MaLop, TenLop FROM Lop";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                adapter.Fill(comboBoxDataTable);
            }

            comboBoxLop.DataSource = comboBoxDataTable;
            comboBoxLop.DisplayMember = "TenLop";
            comboBoxLop.ValueMember = "MaLop";
        }
        private void Class_Ex1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            LoadDataToComboBoxLop();

            dataAdapter = new SqlDataAdapter("SELECT * FROM SinhVien", connection);
            table = new DataTable();
            new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(table);
            dataGridView.DataSource = table;


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SinhVien (MaSinhVien, TenSinhVien, NgaySinh, MaLop) VALUES (@MaSinhVien, @TenSinhVien, @NgaySinh, @MaLop)";

            string maLop = comboBoxLop.SelectedValue.ToString();
            string checkLopQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
            SqlCommand checkLopCommand = new SqlCommand(checkLopQuery, connection);
            checkLopCommand.Parameters.AddWithValue("@MaLop", maLop);
            connection.Open();
            int lopCount = (int)checkLopCommand.ExecuteScalar();
            connection.Close();

            if (lopCount == 0)
            {
                MessageBox.Show("Mã lớp không hợp lệ.");
                return;
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaSinhVien", txtMaSinhVien.Text);
            command.Parameters.AddWithValue("@TenSinhVien", txtTenSinhVien.Text);
            command.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value);
            command.Parameters.AddWithValue("@MaLop", maLop);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công.");
                dataAdapter.Fill(table);
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
        private bool isAllSelected = false;
        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedMaLop = comboBoxLop.SelectedValue.ToString();

            if (table != null)
            {
                if (selectedMaLop == "Tất cả lớp")
                {
                    dataGridView.DataSource = table;
                }
                else
                {
                    table.DefaultView.RowFilter = $"MaLop = '{selectedMaLop}'";
                    // Cập nhật lại DataGridView
                    dataGridView.DataSource = table;
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                txtMaSinhVien.Text = selectedRow.Cells["MaSinhVien"].Value.ToString();
                txtTenSinhVien.Text = selectedRow.Cells["TenSinhVien"].Value.ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                comboBoxLop.SelectedValue = selectedRow.Cells["MaLop"].Value;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                txtMaSinhVien.Text = selectedRow.Cells["MaSinhVien"].Value.ToString();
                txtTenSinhVien.Text = selectedRow.Cells["TenSinhVien"].Value.ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                comboBoxLop.SelectedValue = selectedRow.Cells["MaLop"].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SinhVien (MaSinhVien, TenSinhVien, NgaySinh, MaLop) VALUES (@MaSinhVien, @TenSinhVien, @NgaySinh, @MaLop)";

            // Check if MaLop exists in Lop table
            string maLop = comboBoxLop.SelectedValue.ToString();
            string checkLopQuery = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
            SqlCommand checkLopCommand = new SqlCommand(checkLopQuery, connection);
            checkLopCommand.Parameters.AddWithValue("@MaLop", maLop);
            connection.Open();
            int lopCount = (int)checkLopCommand.ExecuteScalar();
            connection.Close();

            if (lopCount == 0)
            {
                MessageBox.Show("Mã lớp không hợp lệ.");
                return;
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaSinhVien", txtMaSinhVien.Text);
            command.Parameters.AddWithValue("@TenSinhVien", txtTenSinhVien.Text);
            command.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value);
            command.Parameters.AddWithValue("@MaLop", maLop);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công.");
                dataAdapter.Fill(table);
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
    }
}

