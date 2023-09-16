using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revise_Test1_Ex1
{
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object syer, EventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y))
            {
                if (x > y)
                {
                    int primeCount = CountPrimes(x, y);

                    int evenSum = SumEvenNumbers(x, y);

                    txtResultPrime.Text = $"Số lượng số nguyên tố: {primeCount}";
                    txtResultEven.Text = $"Tổng các số chẵn: {evenSum}";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập x > y");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ.", "Lỗi");
            }
        }

        private int CountPrimes(int x, int y)
        {
            int count = 0;
            for (int i = y; i <= x; i++)
            {
                if (IsPrime(i))
                    count++;
            }
            return count;
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private int SumEvenNumbers(int x, int y)
        {
            int sum = 0;

            for (int i = y; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        private void btnExit_Click(object syer, EventArgs e)
        {
            this.Close();
        }

        private void txtX_TextChanged(object syer, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out int result) || result <= 0)
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên dương.", "Lỗi");
                txtX.Text = string.Empty;
            }
        }

        private void txtY_TextChanged(object syer, EventArgs e)
        {
            if (!int.TryParse(txtY.Text, out int result) || result <= 0)
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên dương.", "Lỗi");
                txtY.Text = string.Empty;
            }
        }

        private void txtResultEven_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtResultPrime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
