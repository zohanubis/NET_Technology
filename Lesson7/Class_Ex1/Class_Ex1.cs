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
            string maMonHoc = txtMaMH.Text;
            string tenMonHoc = txtTenMH.Text;

            if (string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(tenMonHoc))
            {
                MessageBox.Show("Mã môn học và tên môn học không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@MaMonHoc, @TenMonHoc)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@TenMonHoc", tenMonHoc);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maMonHoc = txtMaMH.Text;
            string tenMonHoc = txtTenMH.Text;

            if (string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(tenMonHoc))
            {
                MessageBox.Show("Mã môn học và tên môn học không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@MaMonHoc, @TenMonHoc)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@TenMonHoc", tenMonHoc);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maMonHoc = txtMaMH.Text;
            string tenMonHoc = txtTenMH.Text;

            if (string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(tenMonHoc))
            {
                MessageBox.Show("Mã môn học và tên môn học không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@MaMonHoc, @TenMonHoc)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@TenMonHoc", tenMonHoc);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }
    }
}
