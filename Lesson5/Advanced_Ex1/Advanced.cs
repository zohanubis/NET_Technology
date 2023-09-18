using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Advanced_Ex1
{
    public partial class Advanced : Form
    {
        private string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        private string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        private string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };
        public Advanced()
        {
            InitializeComponent();
        }

        private void btnRandomName_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox.Items.Clear();

            for (int i = 0; i < 50; i++)
            {
                string randomName = $"{HO[random.Next(HO.Length)]} {TENLOT[random.Next(TENLOT.Length)]} {TEN[random.Next(TEN.Length)]}";
                listBox.Items.Add(randomName);
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int selectedIndex = listBox.SelectedIndex;
                string selectedName = listBox.SelectedItem.ToString();

                // Sử dụng InputBox để lấy tên mới từ người dùng
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên mới:", "Thay đổi tên", selectedName);

                // Nếu người dùng nhập tên mới và không hủy bỏ
                if (!string.IsNullOrEmpty(newName))
                {
                    listBox.Items[selectedIndex] = newName;
                }
            }
        }
        private void UpdateListBoxDisplay()
        {
            listBox.Refresh();
        }
        private void btnXoaPhanTuDaChon_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void btnXoaPhanTuTenSon_Click(object sender, EventArgs e)
        {
            listBox.Items.Cast<string>()
               .Where(item => item.Contains("Sơn"))
               .ToList()
               .ForEach(item => listBox.Items.Remove(item));
        }

        private void btnXoaPTHoLe_Click(object sender, EventArgs e)
        {
            listBox.Items.Cast<string>()
              .Where(item => item.StartsWith("Lê "))
              .ToList()
              .ForEach(item => listBox.Items.Remove(item));
        }

        private void btnChuyenChuoiInHoa_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int selectedIndex = listBox.SelectedIndex;
                string selectedName = listBox.SelectedItem.ToString();
                listBox.Items[selectedIndex] = selectedName.ToUpper();
                UpdateListBoxDisplay();
            }
        }

        private void btnChuyenChuoiInThuong_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int selectedIndex = listBox.SelectedIndex;
                string selectedName = listBox.SelectedItem.ToString();
                listBox.Items[selectedIndex] = selectedName.ToLower();
                UpdateListBoxDisplay();

            }
        }

        private void btnChuyenChuoiInHoaODauTu_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int selectedIndex = listBox.SelectedIndex;
                string selectedName = listBox.SelectedItem.ToString();

                // Chuyển chữ cái đầu tiên của mỗi từ thành in hoa và phần còn lại thành in thường
                string[] words = selectedName.ToLower().Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words[i]))
                    {
                        char[] letters = words[i].ToCharArray();
                        if (letters.Length > 0)
                            letters[0] = char.ToUpper(letters[0]);
                        words[i] = new string(letters);
                    }
                }

                listBox.Items[selectedIndex] = string.Join(" ", words);
                UpdateListBoxDisplay();

            }
        }

        private void btnXoaTatCaPT_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
