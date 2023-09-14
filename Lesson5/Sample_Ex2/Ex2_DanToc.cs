using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Ex2
{
    public partial class Form_DanToc : Form
    {
        public Form_DanToc()
        {
            InitializeComponent();
        }
        private void LoadDanToc()
        {
            comboBoxList.Items.Add("Kinh");
            comboBoxList.Items.Add("Hoa");
            comboBoxList.Items.Add("K'Me");
            comboBoxList.Items.Add("H'Mong");
            comboBoxList.Items.Add("Khác");
        }
        private void Form_DanToc_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDanToc();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (comboBoxList.SelectedItem != null)
            {
                string selectedDanToc = comboBoxList.SelectedItem.ToString();
                labelDanToc.Text = selectedDanToc;


                MessageBox.Show("Dân tộc đã chọn: " + selectedDanToc, "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dân tộc trước.", "Thông báo");
            }
        }

        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxList.SelectedItem != null)
            {
                string selectedDanToc = comboBoxList.SelectedItem.ToString();
                labelDanToc.Text = selectedDanToc;
            }
        }
    }
}
