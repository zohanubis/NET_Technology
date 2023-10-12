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


namespace Advanced_Ex1
{
    public partial class Advanced_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Advanced_Ex1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listViewLop.Items.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT MaLop, TenLop, MaKhoa FROM Lop";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int stt = 1;

                    while (reader.Read())
                    {
                        string maLop = reader["MaLop"].ToString();
                        string tenLop = reader["TenLop"].ToString();
                        string maKhoa = reader["MaKhoa"].ToString();

                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(maLop);
                        item.SubItems.Add(tenLop);
                        item.SubItems.Add(maKhoa);

                        listViewLop.Items.Add(item);
                        stt++;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
