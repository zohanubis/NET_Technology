using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex5_ReadWord
{
    public partial class ReadWord : Form
    {
        private readonly string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        private readonly string[] tens = { "", "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };
        private readonly string[] teens = { "Mười", "Mười Một", "Mười Hai", "Mười Ba", "Mười Bốn", "Mười Lăm", "Mười Sáu", "Mười Bảy", "Mười Tám", "Mười Chín" };
        private readonly string[] hundreds = { "", "Một Trăm", "Hai Trăm", "Ba Trăm", "Bốn Trăm", "Năm Trăm", "Sáu Trăm", "Bảy Trăm", "Tám Trăm", "Chín Trăm" };
        public ReadWord()
        {
            InitializeComponent();
            this.FormClosing += ReadWord_FormClosing;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtJoin.Text, out int number))
            {
                if (number < 1 || number > 999)
                {
                    MessageBox.Show("Invalid input. Please enter a number from 1 to 999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtResult.Text = ConvertNumberToWords(number);
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ConvertNumberToWords(int number)
        {
            if (number == 0)
            {
                return "không";
            }

            if (number < 10)
            {
                return ones[number];
            }

            if (number < 20)
            {
                return teens[number - 10];
            }

            if (number < 100)
            {
                int ten = number / 10;
                int one = number % 10;
                return tens[ten] + " " + ones[one];
            }

            if (number < 1000)
            {
                int hundred = number / 100;
                int ten = (number % 100) / 10;
                int one = number % 10;

                if (ten == 0 && one == 0)
                {
                    return hundreds[hundred];
                }

                if (ten == 0)
                {
                    return hundreds[hundred] + " Linh " + ones[one];
                }

                if (ten == 1)
                {
                    return hundreds[hundred] + " Mười " + ones[one];
                }

                return hundreds[hundred] + " " + tens[ten] + " " + ones[one];
            }

            return "out of range";
        }
        private void ReadWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtJoin.Clear();
            txtResult.Clear();
        }
    }
}
