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
        SqlDataAdapter da_Khoa;
        SqlConnection connection;
        DataSet ds_QLSV = new DataSet();
        public Sample_Ex1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ZOHANUBIS;Initial Catalog=QLSinhVien;Integrated Security=True");
        }

        private void Sample_Ex1_Load(object sender, EventArgs e)
        {
            LoadDuLieuKhoa();
            LoadDuLieuDataGridView();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            foreach (Control item in tableLayoutPanel.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox) || item.GetType() == typeof(MaskedTextBox))
                {
                    item.Enabled = false;
                }
            }
            btnEdit.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            Databingding(ds_QLSV.Tables["SinhVien"]);
        }
        void LoadDuLieuKhoa()
        {
            try
            {
                // Mở kết nối đến database
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                // Tạo câu truy vấn SQL để lấy dữ liệu từ bảng "Lop"
                string strsel = "SELECT * FROM Lop";

                // Tạo một SqlDataAdapter để lấy dữ liệu từ SQL Server vào DataSet
                da_Khoa = new SqlDataAdapter(strsel, connection);

                // Đổ dữ liệu từ SqlDataAdapter vào DataSet
                da_Khoa.Fill(ds_QLSV, "Lop");

                // Đặt DataSource của ComboBox bằng DataTable trong DataSet
                comboBoxLop.DataSource = ds_QLSV.Tables["Lop"];

                // Thiết lập DisplayMember và ValueMember
                comboBoxLop.DisplayMember = "TenLop";
                comboBoxLop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (nếu có)
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi hoàn tất công việc
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        void LoadDuLieuDataGridView()
        {
            string strsel = "SELECT * FROM SinhVien";
            SqlDataAdapter da_SinhVien = new SqlDataAdapter(strsel, connection);
            da_SinhVien.Fill(ds_QLSV, "SinhVien");
            dataGridView.DataSource = ds_QLSV.Tables["SinhVien"];
        }
        void Databingding(DataTable pDT)
        {
            comboBoxLop.DataBindings.Clear();
            txtTenSV.DataBindings.Clear();
            txtMaSV.DataBindings.Clear();
            maskedTextBoxDate.DataBindings.Clear();
            comboBoxLop.DataBindings.Add("Text", pDT, "MaLop");
            txtTenSV.DataBindings.Add("Text", pDT, "HoTen");
            txtMaSV.DataBindings.Add("Text", pDT, "MaSinhVien");
            maskedTextBoxDate.DataBindings.Add("Text", pDT, "NgaySinh");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            //+ Cho phép thêm các dòng tiếp theo trên datagridview
            dataGridView.AllowUserToAddRows = true;
            dataGridView.ReadOnly = false;
            //Không được sửa các dòng trên datagridview đã có dữ liệu
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                dataGridView.Rows[i].ReadOnly = true;
            }
            dataGridView.FirstDisplayedScrollingRowIndex =
            dataGridView.Rows.Count - 1;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                maskedTextBoxDate.Text = DateTime.Parse(dataGridView.CurrentRow.Cells[2].Value.ToString())
                .ToString("dd/MM/yyyy");
            }
            catch
            {
                maskedTextBoxDate.Text = string.Empty;
            }
            //+Button Sửa và Xóa có hiệu lực
            btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            SqlDataAdapter da_Khoa = new SqlDataAdapter("SELECT * FROM SinhVien", connection);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da_Khoa);
            da_Khoa.Update(ds_QLSV, "SinhVien");
            Databingding(ds_QLSV.Tables["SinhVien"]);
            MessageBox.Show("Lưu thành công.");
            btnSave.Enabled = false;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //+Button Lưu có hiệu lực
            btnSave.Enabled = true;
            //+Cho phép sửa các thông tin trên Datagrid
            dataGridView.ReadOnly = false;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                dataGridView.Rows[i].ReadOnly = false;
            dataGridView.Columns[0].ReadOnly = true;
            //+Lưu ý: không cho phép gõ thêm các dòng mới
            dataGridView.AllowUserToAddRows = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Lấy mã số sinh viên đang chọn
                string maSinhVien = dataGridView.SelectedRows[0].Cells["MaSinhVien"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Kiểm tra dữ liệu trong bảng Diem
                    SqlDataAdapter da_Diem = new SqlDataAdapter("SELECT * FROM Diem WHERE MaSinhVien = '" + maSinhVien + "'", connection);
                    DataTable dt_Diem = new DataTable();
                    da_Diem.Fill(dt_Diem);

                    if (dt_Diem.Rows.Count > 0)
                    {
                        // Dữ liệu đang sử dụng, không thể xóa
                        MessageBox.Show("Dữ liệu đang sử dụng, không thể xóa.");
                    }
                    else
                    {
                        // Xóa dữ liệu trong bảng SinhVien
                        DataRow rowToDelete = ds_QLSV.Tables["SinhVien"].Rows.Find(maSinhVien);
                        if (rowToDelete != null)
                        {
                            rowToDelete.Delete();
                        }

                        SqlCommandBuilder cmb = new SqlCommandBuilder(da_Khoa);
                        da_Khoa.Update(ds_QLSV, "SinhVien");
                        Databingding(ds_QLSV.Tables["SinhVien"]);
                        MessageBox.Show("Xóa thành công.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }



    }
}
