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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
        }

        private void DisableButtons()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }
        private void EnableTextBoxes()
        {
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
        }

        private void EnableButtons()
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
