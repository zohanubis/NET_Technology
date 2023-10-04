using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Start();
            BtnBatDau.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int a = Int32.Parse(label2.Text);
            int b = Int32.Parse(label1.Text);
            int c = Int32.Parse(label3.Text);
            a--;
            if (a < 0)
            {
                a = 59;
                b--;
                if (b < 0)
                {
                    b = 59;
                    c--;
                }
            }


            if (a < 10)
            {
                label2.Text = "0" + a;
            }
            else
                label2.Text = a + "";
            if (b < 10)
            {
                label1.Text = "0" + b;
            }
            else
                label1.Text = b + "";
            if (c < 10)
            {
                label3.Text = "0" + c;
            }
            else
                label3.Text = c + "";

            if (a == 0 && b == 0 && c == 0)
            {
                timer1.Stop();
                MessageBox.Show("you Lose");

            }
        }
    }
}
