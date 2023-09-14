using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex1_ComboBox
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
            // Đăng ký sự kiện khi Form khởi động
            btnCapNhat.Click += btnCapNhat_Click;
            comboBoxList.SelectedIndexChanged += comboBoxList_SelectedIndexChanged;
            btnTongUocSo.Click += btnTongUocSo_Click;
            btnSoLuongUSChan.Click += btnSoLuongUSChan_Click;
            btnSLUSNT.Click += btnSLUSNT_Click;
            btnExit.Click += btnExit_Click;
        }

        private List<int> soDaThem = new List<int>();

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapSo.Text, out int soNhap))
            {
                if (!soDaThem.Contains(soNhap))
                {
                    comboBoxList.Items.Add(soNhap);
                    soDaThem.Add(soNhap);
                    txtNhapSo.Clear();
                    txtNhapSo.Focus();
                }
                else
                {
                    MessageBox.Show("Số đã tồn tại trong danh sách.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
            }
        }

        private void btnTongUocSo_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                int tongUocSo = 0;
                foreach (var item in listBox.Items)
                {
                    tongUocSo += (int)item;
                }
                MessageBox.Show("Tổng các ước số : " + tongUocSo);
            }
            else
            {
                MessageBox.Show("Chưa có ước số nào để tính tổng.");
            }
        }

        private void btnSoLuongUSChan_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                int soLuongUocSoChan = 0;

                foreach (var item in listBox.Items)
                {
                    if ((int)item % 2 == 0)
                    {
                        soLuongUocSoChan++;
                    }
                }

                MessageBox.Show($"Số lượng ước số chẵn: {soLuongUocSoChan}");
            }
            else
            {
                MessageBox.Show("Chưa có ước số nào để đếm.");
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private void btnSLUSNT_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                int soLuongUocSoNguyenTo = 0;

                foreach (var item in listBox.Items)
                {
                    if (IsPrime((int)item))
                    {
                        soLuongUocSoNguyenTo++;
                    }
                }

                MessageBox.Show($"Số lượng ước số nguyên tố: {soLuongUocSoNguyenTo}");
            }
            else
            {
                MessageBox.Show("Chưa có ước số nào để đếm.");
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

        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            if (comboBoxList.SelectedIndex != -1)
            {
                int selectedNumber = (int)comboBoxList.SelectedItem;
                for (int i = 1; i <= selectedNumber; i++)
                {
                    if (selectedNumber % i == 0)
                    {
                        listBox.Items.Add(i);
                    }
                }
            }
        }
    }
}
