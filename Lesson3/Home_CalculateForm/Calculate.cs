using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_CalculateForm
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EvaluateExpression();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PerformOperation('+');

        }

        private void button14_Click(object sender, EventArgs e)
        {
            PerformOperation('-');

        }

        private void button15_Click(object sender, EventArgs e)
        {
            PerformOperation('*');

        }

        private void button16_Click(object sender, EventArgs e)
        {
            PerformOperation('/');

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

        }
        private void PerformOperation(char operation)
        {
            txtResult.Text += operation;
        }

        private void EvaluateExpression()
        {
            string expression = txtResult.Text;
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid expression!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddDigitToExpression(string digit)
        {
            txtResult.Text += digit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("5");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("6");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("7");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("8");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("9");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddDigitToExpression("0");

        }
    }
}
