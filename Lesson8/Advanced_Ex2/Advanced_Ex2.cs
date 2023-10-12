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
namespace Advanced_Ex2
{
    public partial class Advanced_Ex2 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";
        public Advanced_Ex2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            string selectedMonHoc = comboBoxMonHoc.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(selectedMonHoc))
            {
                LoadDataToListView();
            }
            else
            {
                LoadDataToListViewByMonHoc(selectedMonHoc);
            }
        }

        private void Advanced_Ex2_Load(object sender, EventArgs e)
        {
            LoadMonHocComboBox();

            LoadDataToListView();
        }
        private void LoadMonHocComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT DISTINCT MaMonHoc FROM MonHoc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBoxMonHoc.Items.Clear();

                    comboBoxMonHoc.Items.Add("");

                    while (reader.Read())
                    {
                        string maMonHoc = reader["MaMonHoc"].ToString();
                        comboBoxMonHoc.Items.Add(maMonHoc);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadDataToListView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT SinhVien.TenSinhVien, SinhVien.NgaySinh, MonHoc.TenMonHoc, Diem.Diem FROM Diem " +
                                   "JOIN SinhVien ON Diem.MaSinhVien = SinhVien.MaSinhVien " +
                                   "JOIN MonHoc ON Diem.MaMonHoc = MonHoc.MaMonHoc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int stt = 1;
                    double totalScore = 0;

                    while (reader.Read())
                    {
                        string tenSV = reader["TenSinhVien"].ToString();
                        string ngaySinh = DateTime.Parse(reader["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                        string tenMonHoc = reader["TenMonHoc"].ToString();
                        double diem = Convert.ToDouble(reader["Diem"]);

                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(tenSV);
                        item.SubItems.Add(ngaySinh);
                        item.SubItems.Add(tenMonHoc);
                        item.SubItems.Add(diem.ToString());

                        listViewData.Items.Add(item);
                        stt++;
                        totalScore += diem;
                    }

                    reader.Close();

                    txtTongDiem.Text = totalScore.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadDataToListViewByMonHoc(string maMonHoc)
        {
            listViewData.Items.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT SinhVien.TenSV, SinhVien.NgaySinh, MonHoc.TenMonHoc, Diem.Diem FROM Diem " +
                                   "JOIN SinhVien ON Diem.MaSV = SinhVien.MaSV " +
                                   "JOIN MonHoc ON Diem.MaMonHoc = MonHoc.MaMonHoc " +
                                   "WHERE MonHoc.MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int stt = 1;
                    double totalScore = 0;

                    while (reader.Read())
                    {
                        string tenSV = reader["TenSV"].ToString();
                        string ngaySinh = DateTime.Parse(reader["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                        string tenMonHoc = reader["TenMonHoc"].ToString();
                        double diem = Convert.ToDouble(reader["Diem"]);

                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(tenSV);
                        item.SubItems.Add(ngaySinh);
                        item.SubItems.Add(tenMonHoc);
                        item.SubItems.Add(diem.ToString());

                        listViewData.Items.Add(item);
                        stt++;
                        totalScore += diem;
                    }

                    reader.Close();

                    txtTongDiem.Text = totalScore.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
