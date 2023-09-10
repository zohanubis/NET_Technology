using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex3_CafeSV
{
    public partial class CafeSV : Form
    {
        public CafeSV()
        {
            InitializeComponent();
            this.FormClosing += Ex3_Cafe_FormClosing;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string tenKH = txtNameKH.Text;
            bool isSinhVien = checkSV.Checked;

            decimal giaCafe = 0;
            decimal giaThucAn = 0;

            if (radioCafeDen.Checked)
            {
                giaCafe = 20000;
            }
            else if (radioCafeDa.Checked)
            {
                giaCafe = 25000;
            }

            if (checkBanhMyTrung.Checked)
            {
                giaThucAn += 15000;
            }
            if (checkBanhMyCa.Checked)
            {
                giaThucAn += 15000;
            }


            decimal tongTien = giaCafe + giaThucAn;


            if (isSinhVien)
            {
                tongTien *= 0.8m;
            }

            MessageBox.Show($"Tên khách hàng: {tenKH}\nTổng tiền thanh toán: {tongTien:C}");

            btnReset.Enabled = true;
            btnThanhToan.Enabled = true;
            txtTongKH.Text = (int.Parse(txtTongKH.Text) + 1).ToString();
            txtTongThanhToan.Text = (decimal.Parse(txtTongThanhToan.Text) + tongTien).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNameKH.Clear();
            txtIDKH.Clear();
            groupDrink.Enabled = false;
            groupFood.Enabled = false;
            checkSV.Checked = false;
            btnTinhTien.Enabled = false;
            btnReset.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tổng số khách hàng: {txtTongKH.Text}\nTổng tiền thanh toán: {txtTongThanhToan.Text:C}");

            txtTongKH.Text = "";
            txtTongThanhToan.Text = "";

            txtNameKH.Clear();
            txtIDKH.Clear();
            checkSV.Checked = false;
            radioCafeDen.Checked = false;
            radioCafeDa.Checked = false;

            btnTinhTien.Enabled = false;
            btnReset.Enabled = false;
            btnThanhToan.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CafeSV_Load(object sender, EventArgs e)
        {
            txtNameKH.Focus();
            btnTinhTien.Enabled = false;
            btnReset.Enabled = false;
            btnThanhToan.Enabled = false;
            txtTongKH.Text = "0";
            txtTongThanhToan.Text = "0.00";
        }
        private void Ex3_Cafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textKH_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập tên khách hàng");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox, "");
                btnTinhTien.Enabled = true;
            }
        }

        private void textID_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập số khách hàng");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }
    }
}
