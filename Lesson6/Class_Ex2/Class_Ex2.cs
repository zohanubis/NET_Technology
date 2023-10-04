using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex2
{
    public partial class Class_Ex2 : Form
    {
        private int sttCounter = 1;
        private double totalAmount = 0;
        public Class_Ex2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;

                txtSTK.Text = "";
                txtTenKH.Text = "";
                txtDC.Text = "";
                txtSoTien.Text = "";
                txtSTK.Focus();


            }
            else
            {

                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;

                txtSTK.Text = "";
                txtTenKH.Text = "";
                txtDC.Text = "";
                txtSoTien.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {

                double amountToRemove = 0;
                if (double.TryParse(listView.SelectedItems[0].SubItems[4].Text, out amountToRemove))
                {
                    totalAmount -= amountToRemove;
                }

                listView.Items.Remove(listView.SelectedItems[0]);

                UpdateSTT();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mẫu tin để xóa.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSTK.Text) && !string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSoTien.Text))
            {
                if (double.TryParse(txtSoTien.Text, out double amount))
                {
                    ListViewItem item = new ListViewItem(sttCounter.ToString());
                    item.SubItems.Add(txtSTK.Text);
                    item.SubItems.Add(txtTenKH.Text);
                    item.SubItems.Add(txtDC.Text);
                    item.SubItems.Add(amount.ToString());

                    totalAmount += amount;

                    listView.Items.Add(item);

                    sttCounter++;

                    txtSTK.Text = "";
                    txtTenKH.Text = "";
                    txtDC.Text = "";
                    txtSoTien.Text = "";
                    txtSTK.Focus();

                    txtTongTien.Text = totalAmount.ToString("C");

                    btnXoa.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
        }
        private void UpdateSTT()
        {
            // Cập nhật lại STT
            int newSTT = 1;
            foreach (ListViewItem item in listView.Items)
            {
                item.Text = newSTT.ToString();
                newSTT++;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                txtSTK.Text = selectedItem.SubItems[1].Text;
                txtTenKH.Text = selectedItem.SubItems[2].Text;
                txtDC.Text = selectedItem.SubItems[3].Text;
                txtSoTien.Text = selectedItem.SubItems[4].Text;
            }
        }

        private void Class_Ex2_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
