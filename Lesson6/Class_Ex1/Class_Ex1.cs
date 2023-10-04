using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex1
{
    public partial class Class_Ex1 : Form
    {
        private List<string> danTocList;
        public Class_Ex1()
        {
            InitializeComponent();
            InitializeData();
            this.FormClosing += Ex1_FormClosing;
        }
        private void InitializeData()
        {
            danTocList = new List<string> { "Kinh", "Tày", "Mường", "Hoa", "Khác" };
            foreach (string danToc in danTocList)
            {
                comboBoxDanToc.Items.Add(danToc);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm thông tin vào ListView
            string gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
            string danToc = comboBoxDanToc.SelectedItem?.ToString() ?? "Không xác định";
            string ngoaiNgu = "";
            if (checkAnh.Checked)
                ngoaiNgu += "Anh, ";
            if (checkPhap.Checked)
                ngoaiNgu += "Pháp, ";
            if (checkTrung.Checked)
                ngoaiNgu += "Trung, ";
            ngoaiNgu = ngoaiNgu.TrimEnd(' ', ',');

            string[] row = { txtName.Text, txtMa.Text, danToc,gioiTinh, ngoaiNgu };
            var listViewItem = new ListViewItem(row);
            listViewLiLich.Items.Add(listViewItem);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            listViewLiLich.SelectedItems[0].SubItems[0].Text = txtName.Text;
            listViewLiLich.SelectedItems[0].SubItems[1].Text = txtMa.Text;

            string gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
            listViewLiLich.SelectedItems[0].SubItems[3].Text = gioiTinh;

            string danToc = comboBoxDanToc.SelectedItem?.ToString() ?? "Không xác định";
            listViewLiLich.SelectedItems[0].SubItems[2].Text = danToc;

            string ngoaiNgu = "";
            if (checkAnh.Checked)
                ngoaiNgu += "Anh, ";
            if (checkPhap.Checked)
                ngoaiNgu += "Pháp, ";
            if (checkTrung.Checked)
                ngoaiNgu += "Trung, ";
            ngoaiNgu = ngoaiNgu.TrimEnd(' ', ',');
            listViewLiLich.SelectedItems[0].SubItems[4].Text = ngoaiNgu;
        }

        private void listViewLiLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLiLich.SelectedItems.Count > 0)
            {
                txtName.Text = listViewLiLich.SelectedItems[0].SubItems[0].Text;
                txtMa.Text = listViewLiLich.SelectedItems[0].SubItems[1].Text;
                ClearSelections();

                string gioiTinh = listViewLiLich.SelectedItems[0].SubItems[3].Text;
                if (gioiTinh == "Nam")
                    radioNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    radioNu.Checked = true;

                string ngoaiNgu = listViewLiLich.SelectedItems[0].SubItems[4].Text;
                if (ngoaiNgu.Contains("Anh"))
                    checkAnh.Checked = true;
                if (ngoaiNgu.Contains("Pháp"))
                    checkPhap.Checked = true;
                if (ngoaiNgu.Contains("Trung"))
                    checkTrung.Checked = true;
            }
        }
        private void ClearSelections()
        {
            radioNam.Checked = false;
            radioNu.Checked = false;

            checkAnh.Checked = false;
            checkPhap.Checked = false;
            checkTrung.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listViewLiLich.Items.Remove(listViewLiLich.SelectedItems[0]);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "deleteToolStripMenuItem")
            {
                if (listViewLiLich.SelectedItems.Count > 0)
                {
                    listViewLiLich.SelectedItems[0].Remove();
                }
            }
        }
        private void Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xác nhận trước khi đóng Form
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy việc đóng Form
            }
        }
    }
}

