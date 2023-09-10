using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Ex1_Calculate
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            this.FormClosing += Ex1_Calculator_FormClosing;
            InitializeComponent();
        }
        private class Calculator
        {
            public double Add(double a, double b) => a + b;
            public double Substract(double a, double b) => a - b;
            public double Multiply(double a, double b) => a * b;

            public double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
        }
        private void Ex1_Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textA.Text, out double a) && double.TryParse(textB.Text, out double b))
            {
                Calculator calculator = new Calculator();

                if (radioAdd.Checked)
                {
                    textResult.Text = calculator.Add(a, b).ToString();
                }
                else if (radioSubtract.Checked)
                {
                    textResult.Text = calculator.Substract(a, b).ToString();
                }
                else if (radioMultiplication.Checked)
                {
                    textResult.Text = calculator.Multiply(a, b).ToString();
                }
                else if (radioDivide.Checked)
                {
                    textResult.Text = calculator.Divide(a, b).ToString();
                }
            }
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textA.Text))
            {
                textA.Focus();
                errorProvider1.SetError(textA, "Nhập vào số A");
            }
            else
            {

                errorProvider1.SetError(textA, null);
            }
        }

        private void textB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textB.Text))
            {
                textB.Focus();
                errorProvider1.SetError(textB, "Nhập vào số B");
            }
            else
            {

                errorProvider1.SetError(textB, null);
            }
        }
    }
}
