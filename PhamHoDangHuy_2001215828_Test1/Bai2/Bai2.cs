using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2 : Form
    {
        private int[] arr;
        public Bai2()
        {
            InitializeComponent();
        }
        

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            string input = txtJoin.Text;
            string[] values = input.Split(' ');
            if (!KiemTraNhap(values))
                return;

            arr = values.Select(int.Parse).ToArray();

            CapNhatTextBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { this.Close(); }
        }

        private void btnSapXepMang_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));
            CapNhatTextBox();
        }
        private void CapNhatTextBox()
        {
            if (arr != null)
                txtResult.Text = string.Join(" ", arr);
        }
        private void BtnTong_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để tính tổng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int tong = TinhTong(arr);
            int tongChan = TinhTongChan(arr);
            int tongLe = TinhTongLe(arr);

            txtTongMang.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
        }
        private int TinhTong(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        private int TinhTongChan(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        private int TinhTongLe(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        private bool KiemTraNhap(string[] values)
        {
            if (values.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int num;
            foreach (string value in values)
            {
                if (!int.TryParse(value, out num))
                {
                    MessageBox.Show("Vui lòng chỉ nhập số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
    }
}
