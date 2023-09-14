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
    public partial class Sample_Ex1 : Form
    {
        public Sample_Ex1()
        {
            InitializeComponent();
            this.FormClosing += Sample_Ex1_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e) // Btn Tất cả qua phải
        {
            MoveItems(listBox, listBox1, true);
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(listBox, listBox1);
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(listBox1, listBox);
        }

        private void MoveSelectedItems(ListBox source, ListBox destination)
        {
            List<object> itemsToMove = new List<object>();

            foreach (var item in source.SelectedItems)
            {
                itemsToMove.Add(item);
            }

            foreach (var item in itemsToMove)
            {
                source.Items.Remove(item);
                destination.Items.Add(item);
            }
        }


        private void BtnTatCaQuaTrai_Click(object sender, EventArgs e)
        {
            MoveItems(listBox1, listBox, true);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnChuyenTuyChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void MoveItems(ListBox source, ListBox destination, bool moveAll)
        {
            List<object> itemsToMove = new List<object>();

            if (moveAll)
            {
                foreach (var item in source.Items)
                {
                    itemsToMove.Add(item);
                }
            }
            else if (source.SelectedItems.Count > 0)
            {
                foreach (var item in source.SelectedItems)
                {
                    itemsToMove.Add(item);
                }
            }

            foreach (var item in itemsToMove)
            {
                source.Items.Remove(item);
                destination.Items.Add(item);
            }
        }

        private void Sample_Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Sample_Ex1_Load(object sender, EventArgs e)
        {
            listBox.Items.Add("Đào");
            listBox.Items.Add("Ổi");
            listBox.Items.Add("Xoài");
            listBox.Items.Add("Me");
            listBox.Items.Add("Bưởi");
            listBox.Items.Add("Cam");
        }
    }
}
