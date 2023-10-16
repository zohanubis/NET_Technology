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

namespace Home
{
    public partial class HomeEx : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QL_HangHoa;Integrated Security=True";
        public HomeEx()
        {
            InitializeComponent();
            
        }
        
        private void HomeEx_Load(object sender, EventArgs e)
        {
            LoadSinhVienComboBox();
        }



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void comboBoxSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void LoadSinhVienComboBox()
        {
           using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MaSinhVien, HoTen FROM SinhVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxSinhVien.DataSource = dt;
                comboBoxSinhVien.DisplayMember = "HoTen";
                comboBoxSinhVien.ValueMember = "MaSinhVien";

            }
        }

      

    }
}
