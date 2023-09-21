using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revise_Test3_Ex2
{
    public partial class Ex2 : Form
    {
        private int[] arr;
        public Ex2()
        {
            InitializeComponent();
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            string input = txtJoin.Text;
            string[] values = input.Split(' ');
            arr = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            txtResult.Text = input;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { this.Close(); }
        }

        private void BtnTong_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để tính tổng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int tong = CalculateSum(arr);
            int tongChan = CalculateSumEven(arr);
            int tongLe = CalculateSumOdd(arr);

            txtTongMang.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
        }
        private int CalculateSum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        private int CalculateSumEven(int[] array)
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

        private int CalculateSumOdd(int[] array)
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

        private void btnSapXepMang_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Array.Sort(arr);
            UpdateResultTextBox();
        }
        private void UpdateResultTextBox()
        {
            if (arr != null)
                txtResult.Text = string.Join(" ", arr);
        }
    }
}
