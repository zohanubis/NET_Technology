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

namespace Sample_Ex1
{
    public partial class Sample_Ex1 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Sample_Ex1()
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

                    string insertString = "INSERT INTO Khoa VALUES (@MaKhoa, @TenKhoa)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                    cmd.ExecuteNonQuery();

                    //insertString = "insert into Khoa values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                    //SqlCommand cmd = new SqlCommand(insertString, conStr);
                    //cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();

                    string deleteString = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";
                    SqlCommand cmd = new SqlCommand(deleteString, conStr);
                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
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

                    string updateString = "UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";
                    SqlCommand cmd = new SqlCommand(updateString, conStr);
                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
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
