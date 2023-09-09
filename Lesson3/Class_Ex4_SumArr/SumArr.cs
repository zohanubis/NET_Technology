using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex4_SumArr
{
    public partial class SumArr : Form
    {
        private List<int> numbers;

        public SumArr()
        {
            InitializeComponent();

            numbers = new List<int>();
            this.FormClosing += SumArray_FormClosing;
        }
        private void SumArray_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtJoin.Text, out int number))
            {
                numbers.Add(number);
                txtResult.Text += number + " ";
                txtJoin.Clear();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("No numbers entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sum = numbers.Sum();
            txtTong.Text = sum.ToString();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("No numbers entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sumEven = numbers.Where(n => n % 2 == 0).Sum();
            txtEven.Text = sumEven.ToString();
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("No numbers entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sumOdd = numbers.Where(n => n % 2 != 0).Sum();
            txtOdd.Text = sumOdd.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtTong.Clear();
            txtEven.Clear();
            txtOdd.Clear();
            txtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
