using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex1_CalculateForm
{
    public partial class Ex1_CalculateForm : Form
    {
        private ErrorProvider errorProvider;

        public Ex1_CalculateForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

            this.FormClosing += CalculateForm_FormClosing;

        }
        private void CalculateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumberA.Text);
            double b = double.Parse(txtNumberB.Text);
            double result = a + b;
            txtResult.Text = result.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumberA.Text);
            double b = double.Parse(txtNumberB.Text);
            double result = a - b;
            txtResult.Text = result.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumberA.Text);
            double b = double.Parse(txtNumberB.Text);
            double result = a * b;
            txtResult.Text = result.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double a = double.Parse(txtNumberA.Text);
                double b = double.Parse(txtNumberB.Text);
                if (b == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double result = a / b;
                txtResult.Text = result.ToString();

            }
        }
        private bool ValidateInputs()
        {
            errorProvider.Clear();

            if (!double.TryParse(txtNumberA.Text, out _))
            {
                errorProvider.SetError(txtNumberA, "Invalid input");
                return false;
            }

            if (!double.TryParse(txtNumberB.Text, out _))
            {
                errorProvider.SetError(txtNumberB, "Invalid input");
                return false;
            }

            return true;
        }
    }
}
