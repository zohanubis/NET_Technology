using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Ex1
{
    public partial class Home_Ex1 : Form
    {
        private List<Word> wordList;
        public Home_Ex1()
        {
            InitializeComponent();

            // Khởi tạo danh sách từ và thêm một số từ mẫu
            wordList = new List<Word>();
            wordList = new List<Word>();
            wordList.Add(new Word("Hello", "Xin chào"));
            wordList.Add(new Word("Apple", "Quả táo"));
            wordList.Add(new Word("Car", "Xe ô tô"));
            wordList.Add(new Word("Dog", "Con chó"));
            wordList.Add(new Word("Cat", "Con mèo"));
            wordList.Add(new Word("Book", "Cuốn sách"));
            wordList.Add(new Word("Computer", "Máy tính"));
            wordList.Add(new Word("Phone", "Điện thoại"));
            wordList.Add(new Word("Table", "Cái bàn"));
            wordList.Add(new Word("Chair", "Cái ghế"));
            wordList.Add(new Word("Sun", "Mặt trời"));
            wordList.Add(new Word("Moon", "Mặt trăng"));
            wordList.Add(new Word("Sky", "Bầu trời"));
            wordList.Add(new Word("Water", "Nước"));
            wordList.Add(new Word("Fire", "Lửa"));
            wordList.Add(new Word("Earth", "Trái đất"));
            wordList.Add(new Word("Air", "Khí"));
            wordList.Add(new Word("Tree", "Cây"));
            wordList.Add(new Word("Mountain", "Núi"));
            wordList.Add(new Word("River", "Sông"));

            // Đổ dữ liệu từ danh sách vào combobox
            foreach (Word word in wordList)
            {
                comboBoxWord.Items.Add(word.English);
            }

            // Thêm event handler cho sự kiện KeyDown của combobox
            comboBoxWord.KeyDown += comboBoxWord_KeyDown;
        }

        private void comboBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý khi combobox được chọn
            string selectedWord = comboBoxWord.SelectedItem.ToString();
            Word word = FindWord(selectedWord);
            if (word != null)
            {
                txtVietnamese.Text = word.Vietnamese;
            }
        }

        private void txtVietnamese_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selectedWord = comboBoxWord.Text;
                Word word = FindWord(selectedWord);
                if (word != null)
                {
                    txtVietnamese.Text = word.Vietnamese;
                }
            }
        }
        private Word FindWord(string englishWord)
        {
            // Tìm từ trong danh sách
            foreach (Word word in wordList)
            {
                if (word.English.Equals(englishWord, StringComparison.OrdinalIgnoreCase))
                {
                    return word;
                }
            }
            return null; // Trả về null nếu không tìm thấy
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    public class Word
    {
        public string English { get; }
        public string Vietnamese { get; }

        public Word(string english, string vietnamese)
        {
            English = english;
            Vietnamese = vietnamese;
        }
    }
}
