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

namespace Class_Ex1
{
    public partial class Class_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";
        public Class_Ex1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO MonHoc VALUES (@MaMonHoc, @TenMonHoc)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMaMH.Text);
                    cmd.Parameters.AddWithValue("@TenMonHoc", txtTenMH.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();

                    string deleteString = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMH";
                    SqlCommand cmd = new SqlCommand(deleteString, conStr);
                    cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();

                    string updateString = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc WHERE MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(updateString, conStr);
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMaMH.Text);
                    cmd.Parameters.AddWithValue("@TenMonHoc", txtTenMH.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }
    }
}
