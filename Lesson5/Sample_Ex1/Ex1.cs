using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Ex1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }
        private void TraiCay()
        {
            listBox1.Items.Add("Kinh");
            listBox1.Items.Add("Hoa");
            listBox1.Items.Add("K'Me");
            listBox1.Items.Add("H'Mong");
            listBox1.Items.Add("Khác");
        }
        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            TraiCay();
        }

        private void btnChuyenTatCaPhai_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnChuyenTatCaTrai_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
