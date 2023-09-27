using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Home_Ex2
{
    public partial class Home_Ex2 : Form
    {
        private List<int> numbersList;

        public Home_Ex2()
        {
            InitializeComponent();
            numbersList = new List<int>();
        }

        private void BtnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNhap.Text))
                {
                    int number = int.Parse(txtNhap.Text);
                    numbersList.Add(number);
                    RefreshListBox();
                    txtNhap.Clear();
                    txtNhap.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá trị vào ô nhập.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }

        private void BtnChonSoLe_Click(object sender, EventArgs e)
        {
            //listBox.ClearSelected();

            //foreach (int number in numbersList)
            //{
            //    if (number % 2 != 0)
            //        listBox.SetSelected(listBox.Items.IndexOf(number.ToString()), true);
            //}
            listBox.ClearSelected();

            foreach (var item in listBox.Items)
            {
                if (int.TryParse(item.ToString(), out int number) && number % 2 != 0)
                    listBox.SetSelected(listBox.Items.IndexOf(item), true);
            }
        }

        private void BtnChonSoChan_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();

            foreach (int number in numbersList)
            {
                if (number % 2 != 0)
                    listBox.SetSelected(listBox.Items.IndexOf(number.ToString()), true);
            }
        }

        private void BtnThayBangBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbersList.Count; i++)
            {
                numbersList[i] = numbersList[i] * numbersList[i];
            }

            RefreshListBox();
        }

        private void BtnTangPhanTuLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbersList.Count; i++)
            {
                numbersList[i] += 2;
            }

            RefreshListBox();
        }

        private void BtnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            foreach (var selectedValue in listBox.SelectedItems)
            {
                numbersList.Remove(int.Parse(selectedValue.ToString()));
            }

            RefreshListBox();
        }

        private void BtnXoaPhanTuDauVaCuoi_Click(object sender, EventArgs e)
        {
            if (numbersList.Count > 0)
            {
                numbersList.RemoveAt(0); // Xóa phần tử đầu tiên
                if (numbersList.Count > 0)
                    numbersList.RemoveAt(numbersList.Count - 1); // Xóa phần tử cuối cùng
            }

            RefreshListBox();
        }

        private void BtnTongCacPhanTuList_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int number in numbersList)
            {
                sum += number;
            }

            MessageBox.Show("Tổng các phần tử: " + sum.ToString());
        }

        private void RefreshListBox()
        {
            listBox.DataSource = null; 
            listBox.DataSource = numbersList;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
