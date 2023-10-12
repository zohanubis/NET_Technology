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
        }
        private void LoadDataToComboBoxLop()
        {
            string selectQuery = "SELECT MaLop, TenLop FROM Lop";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            comboBoxLop.DataSource = dataTable;
            comboBoxLop.DisplayMember = "TenLop";
            comboBoxLop.ValueMember = "MaLop";
        }
        private void Class_Ex1_Load(object sender, EventArgs e)
        {
            // Khởi tạo kết nối
            connection = new SqlConnection(connectionString);

            // Load dữ liệu lớp vào ComboBox
            LoadDataToComboBoxLop();

            // Khởi tạo DataAdapter và DataTable
            dataAdapter = new SqlDataAdapter("SELECT * FROM SinhVien", connection);
            table = new DataTable();

            // Tự động tạo lệnh Insert, Update, Delete từ DataAdapter
            new SqlCommandBuilder(dataAdapter);

            // Đổ dữ liệu từ DB vào DataTable
            dataAdapter.Fill(table);

            // Hiển thị dữ liệu trên DataGridView
            dataGridView.DataSource = table;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void LoadLopComboBox()
        {
            comboBoxLop.Items.Clear();
            comboBoxLop.Items.Add("Tất cả lớp");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaLop, TenLop FROM Lop";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maLop = reader["MaLop"].ToString();
                    string tenLop = reader["TenLop"].ToString();
                    comboBoxLop.Items.Add($"{maLop} - {tenLop}");
                }

                reader.Close();
            }

            comboBoxLop.SelectedIndex = 0;
        }


        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
