using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Theater
{
    public partial class Theater : Form
    {
        public Theater()
        {
            InitializeComponent();
            //this.FormClosing += Theater_FormClosing;

        }
        List<Button> DanhSachChon = new List<Button>();
        int tinhThanhTien = 0;
        private string phepToan;
        private void Theater_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void buttonChon_Click(object sender, EventArgs e)
        {
            foreach (Button b in DanhSachChon)
            {
                int a = int.Parse(b.Text);
                if (a <= 5)
                {
                    b.BackColor = Color.Yellow;
                    tinhThanhTien += 1000;
                }
                if (5 < a && a <= 10)
                {
                    b.BackColor = Color.Yellow;
                    tinhThanhTien += 1500;
                }
                if (10 < a && a <= 15)
                {
                    b.BackColor = Color.Yellow;
                    tinhThanhTien += 2000;
                }
            }
            khungThanhTien.Text = tinhThanhTien.ToString();
            tinhThanhTien = 0;
            DanhSachChon = new List<Button>();
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế này đã được chọn !!!");
            }
        }
    }
}
