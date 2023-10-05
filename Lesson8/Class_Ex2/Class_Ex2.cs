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

namespace Class_Ex2
{
    public partial class Class_Ex2 : Form
    {
        private string connectionString = "Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True";
        public Class_Ex2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSinhVien = comboBoxSinhVien.SelectedItem.ToString();
            string maMonHoc = comboBoxMonHoc.SelectedItem.ToString();
            string diemStr = txtDiem.Text;

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Thông tin không được để trống.");
                return;
            }

            if (!double.TryParse(diemStr, out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string checkString = "SELECT COUNT(*) FROM Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(checkString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Điểm cho sinh viên và môn học đã tồn tại.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string insertString = "INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES (@MaSinhVien, @MaMonHoc, @Diem)";
                    SqlCommand cmd = new SqlCommand(insertString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm điểm thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công: " + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSinhVien = comboBoxSinhVien.SelectedItem.ToString();
            string maMonHoc = comboBoxMonHoc.SelectedItem.ToString();

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc))
            {
                MessageBox.Show("Thông tin không được để trống.");
                return;
            }

            try
            {
                using (SqlConnection conStr = new SqlConnection(connectionString))
                {
                    conStr.Open();
                    string deleteString = "DELETE FROM Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(deleteString, conStr);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa điểm thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công: " + ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maSinhVien = comboBoxSinhVien.SelectedItem.ToString();
            string maMonHoc = comboBoxMonHoc.SelectedItem.ToString();
            string diemStr = txtDiem.Text;

            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Thông tin không được để trống.");
                return;
            }

            if (!double.TryParse(diemStr, out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string updateString = "UPDATE Diem SET Diem = @Diem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc";
                    SqlCommand cmd= new SqlCommand(updateString, con);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật điểm thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công: " + ex.Message);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string maSVString = "SELECT MaSinhVien FROM SinhVien";
                    SqlCommand maSVCmd = new SqlCommand(maSVString, con);
                    SqlDataReader maSVReader = maSVCmd.ExecuteReader();

                    while (maSVReader.Read())
                    {
                        string maSV = maSVReader["MaSinhVien"].ToString();
                        comboBoxSinhVien.Items.Add(maSV);
                    }

                    maSVReader.Close();

                    string maMHString = "SELECT MaMonHoc FROM MonHoc";
                    SqlCommand maMHCmd = new SqlCommand(maMHString, con);
                    SqlDataReader maMHReader = maMHCmd.ExecuteReader();

                    while (maMHReader.Read())
                    {
                        string maMH = maMHReader["MaMonHoc"].ToString();
                        comboBoxMonHoc.Items.Add(maMH);
                    }

                    maMHReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thành Công: " + ex.Message);
            }
        }

        private void Class_Ex2_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }
    }
}
