using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_QLPB
{
    public partial class QLPB : Form
    {
        public QLPB()
        {
            InitializeComponent();
            AddInitialDepartments();
        }

        private void AddInitialDepartments()
        {
            // Thêm các phòng ban vào TreeView
            TreeNode rootNode = treeView1.Nodes.Add("Phòng ban");
            string[] departments = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };
            foreach (string department in departments)
            {
                TreeNode departmentNode = rootNode.Nodes.Add(department);
                departmentNode.Tag = department; // Lưu thông tin phòng ban vào Tag
            }

            // Thêm các phòng ban vào ComboBox
            foreach (string department in departments)
            {
                comboBox1.Items.Add(department);
            }
        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            string newDepartment = txtPhongBan.Text.Trim();

            if (string.IsNullOrEmpty(newDepartment))
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban.", "Lỗi");
                return;
            }

            // Kiểm tra xem phòng ban đã tồn tại trong TreeView chưa
            bool departmentExists = false;
            foreach (TreeNode node in treeView1.Nodes[0].Nodes)
            {
                if (node.Text == newDepartment)
                {
                    departmentExists = true;
                    break;
                }
            }

            if (departmentExists)
            {
                MessageBox.Show("Phòng ban đã tồn tại.", "Lỗi");
            }
            else
            {
                // Thêm phòng ban mới vào TreeView
                TreeNode departmentNode = treeView1.Nodes[0].Nodes.Add(newDepartment);
                departmentNode.Tag = newDepartment;

                // Thêm phòng ban mới vào ComboBox
                comboBox1.Items.Add(newDepartment);
                comboBox1.SelectedItem = newDepartment;
            }
        }

        private void btnXoaPhongBan_Click(object sender, EventArgs e)
        {
            string selectedDepartment = comboBox1.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedDepartment))
            {
                MessageBox.Show("Vui lòng chọn phòng ban cần xóa.", "Lỗi");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng ban này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Xóa phòng ban khỏi TreeView
                TreeNode nodeToRemove = null;
                foreach (TreeNode node in treeView1.Nodes[0].Nodes)
                {
                    if (node.Text == selectedDepartment)
                    {
                        nodeToRemove = node;
                        break;
                    }
                }

                if (nodeToRemove != null)
                {
                    treeView1.Nodes[0].Nodes.Remove(nodeToRemove);
                }

                // Xóa phòng ban khỏi ComboBox
                comboBox1.Items.Remove(selectedDepartment);
                comboBox1.SelectedIndex = -1;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string address = txtAddress.Text.Trim();
            string selectedDepartment = comboBox1.SelectedItem as string;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(selectedDepartment))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên và chọn phòng ban.", "Lỗi");
                return;
            }

            TreeNode departmentNode = FindNodeByText(treeView1.Nodes[0], selectedDepartment);

            if (departmentNode != null)
            {
                // Tạo một TreeNode mới cho nhân viên và lưu thông tin vào Tag
                TreeNode employeeNode = new TreeNode(name);
                employeeNode.Tag = new { Name = name, ID = id, Address = address };

                departmentNode.Nodes.Add(employeeNode);

                txtName.Clear();
                txtID.Clear();
                txtAddress.Clear();
            }
            else
            {
                MessageBox.Show("Phòng ban không tồn tại.", "Lỗi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi phòng ban trong ComboBox thay đổi, hiển thị phòng ban tương ứng trên TreeView
            string selectedDepartment = comboBox1.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedDepartment))
            {
                treeView1.SelectedNode = FindNodeByText(treeView1.Nodes[0], selectedDepartment);
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
    }
}
