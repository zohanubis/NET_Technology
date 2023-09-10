using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex1_PT
{
    public partial class PT : Form
    {
        public PT()
        {
            InitializeComponent();
            this.FormClosing += Ex1_PT_FormClosing;

        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            if (radioB1.Checked)
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double x = -b / a;
                textResult.Text = $"Phương trình có nghiệm x = {x}";
            }
            else if (radioB2.Checked)
            {

                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    textResult.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {

                    double x = -b / (2 * a);
                    textResult.Text = $"Phương trình có nghiệm kép x1 = x2 = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    textResult.Text = $"Phương trình có 2 nghiệm phân biệt : x1 = {x1} và x2 = {x2}";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { this.Close(); }
        }
        private void Ex1_PT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void PT_Load(object sender, EventArgs e)
        {
            BtnClick.Enabled = false;

        }

        private void radioB1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;

        }

        private void radioB2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
            BtnClick.Enabled = true;
        }
    }
}
