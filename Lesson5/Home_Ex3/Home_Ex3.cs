using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Ex3
{
    public partial class Home_Ex3 : Form
    {
        private Dictionary<char, TreeNode> contactDictionary;
        public Home_Ex3()
        {
            InitializeComponent(); contactDictionary = new Dictionary<char, TreeNode>();
        }
        private void LoadContactsToTreeView()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode node = new TreeNode(c.ToString());
                treeView.Nodes.Add(node);
                contactDictionary.Add(c, node);
            }
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                char firstChar = char.ToUpper(firstName[0]);

                if (char.IsLetter(firstChar) && contactDictionary.ContainsKey(firstChar))
                {
                    TreeNode parentNode = contactDictionary[firstChar];
                    TreeNode newNode = new TreeNode($"{firstName} {lastName}");
                    parentNode.Nodes.Add(newNode);
                    treeView.ExpandAll(); 
                }
                else
                {
                    MessageBox.Show("Tên không hợp lệ hoặc không có ký tự đầu là chữ cái.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên và họ.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Ex3_Load(object sender, EventArgs e)
        {
            LoadContactsToTreeView();
        }
    }
}
