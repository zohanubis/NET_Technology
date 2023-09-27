using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex2_QLSV
{
    public partial class QLSV : Form
    {
        private Dictionary<string, List<string>> danhSachLop = new Dictionary<string, List<string>>();
        public class SinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string DiaChi { get; set; }
        }

        public QLSV()
        {
            InitializeComponent();
            InitializeTreeView();
            AddInitialClass();

        }
        private void AddInitialClass()
        {
            TreeNode rootNode = treeView1.Nodes.Add("Lớp");
            string[] lopHoc = { "12DHTH10", "12DHTH11", "12DHTH12" };
            foreach (string lop in lopHoc)
            {
                TreeNode lopNode = rootNode.Nodes.Add(lop);
                lopNode.Tag = lop;
            }
            foreach (string lop in lopHoc)
            {
                comboBoxLop.Items.Add(lop);
            }
        }
        private void InitializeTreeView()
        {

            UpdateComboBox();
        }
        private void ShowGroupBox(bool isVisible)
        {
            groupBoxThongTinLop.Visible = isVisible;
            txtThemLop.Clear();
        }

        private void UpdateComboBox()
        {
            comboBoxLop.Items.Clear();
            comboBoxLop.Items.AddRange(danhSachLop.Keys.ToArray());
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string tenLop = comboBoxLop.SelectedItem as string;
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp trước.");
                return;
            }

            string maSV = txtID.Text.Trim();
            string tenSV = txtName.Text.Trim();
            string diaChiSV = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(diaChiSV))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên.");
                return;
            }

            SinhVien sinhVien = new SinhVien
            {
                MaSV = maSV,
                TenSV = tenSV,
                DiaChi = diaChiSV
            };

            TreeNode classNode = FindNodeByText(treeView1.Nodes[0], tenLop);
            if (classNode != null)
            {
                TreeNode svNode = new TreeNode($"{maSV} - {tenSV} - {diaChiSV}");
                svNode.Tag = sinhVien; // Lưu đối tượng SinhVien vào Tag của node
                classNode.Nodes.Add(svNode);

                txtName.Clear();
                txtID.Clear();
                txtAddress.Clear();
            }
            else
            {
                MessageBox.Show("Lớp đã tồn tại.");
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            //TreeNode selectedNode = treeView1.SelectedNode;
            //if (selectedNode != null && selectedNode.Parent != null)
            //{
            //    string tenLop = selectedNode.Parent.Text;
            //    string maSV = (string)selectedNode.Tag; // Lấy mã sinh viên từ Tag của node 

            //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        danhSachLop[tenLop].Remove(maSV);
            //        selectedNode.Remove();
            //    }
            //}

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                treeView1.SelectedNode.Remove();
            }

        }



        private void checkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            ShowGroupBox(checkThemLop.Checked);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string newClass = txtThemLop.Text.Trim();
            if (string.IsNullOrEmpty(newClass))
            {
                MessageBox.Show("Vui lòng nhập tên lớp học", "Lỗi");
                return;
            }
            bool classExists = false;
            foreach (TreeNode node in treeView1.Nodes[0].Nodes)
            {
                if (node.Text == newClass)
                {
                    classExists = true;
                    break;
                }
            }
            if (classExists)
            {
                MessageBox.Show("Lớp đã tồn tại.", "Lỗi");
            }
            else
            {
                TreeNode classNode = treeView1.Nodes[0].Nodes.Add(newClass);
                classNode.Tag = newClass;

                comboBoxLop.Items.Add(newClass);
                comboBoxLop.SelectedItem = newClass;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi phòng ban trong ComboBox thay đổi, hiển thị phòng ban tương ứng trên TreeView
            string selectedClass = comboBoxLop.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedClass))
            {
                treeView1.SelectedNode = FindNodeByText(treeView1.Nodes[0], selectedClass);
            }
        }
        private TreeNode FindNodeByText(TreeNode rootNode, string text)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (node.Text == text)
                {
                    return node;
                }
            }
            return null;
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
            groupBoxThongTinLop.Visible = true;
        }
    }
}
