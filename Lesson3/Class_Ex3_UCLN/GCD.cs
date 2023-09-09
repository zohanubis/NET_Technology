using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex3_UCLN
{
    public partial class GCD : Form
    {
        public GCD()
        {
            InitializeComponent();
            this.FormClosing += GCDForm_FormClosing;

        }
        private void GCDForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form  ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int CalculateLCM(int a, int b)
        {
            int gcd = CalculateGCD(a, b);
            int lcm = (a * b) / gcd;
            return lcm;
        }
        private bool ValidateInputs()
        {
            if (!int.TryParse(textBox1.Text, out int a))
            {
                MessageBox.Show("Invalid input for number A. Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textBox2.Text, out int b))
            {
                MessageBox.Show("Invalid input for number B. Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int gcd = CalculateGCD(a, b);
                int lcm = CalculateLCM(a, b);

                textBox3.Text = gcd.ToString();
                textBox4.Text = lcm.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
