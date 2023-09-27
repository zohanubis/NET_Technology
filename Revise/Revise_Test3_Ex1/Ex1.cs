using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revise_Test3_Ex1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int n, m;
            if(!int.TryParse(txtN.Text, out n))
            {
                errorProvider.SetError(txtN, "Vui lòng nhập số nguyên.");
                MessageBox.Show("Vui lòng nhập số nguyên cho N.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtM.Text, out m))
            {
                // Hiển thị lỗi nếu giá trị không hợp lệ
                errorProvider.SetError(txtM, "Vui lòng nhập số nguyên.");
                MessageBox.Show("Vui lòng nhập số nguyên cho M.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            errorProvider.Clear();
            int tong = n + m;
            txtKetQua.Text = tong.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtN, "");
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtM, "");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
