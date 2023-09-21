using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class TongTien
        {
            public bool IsSanVuon { get; set; }
            public int CafeSuaSL { get; set; }
            public int CafeDaSL { get; set; }
            public int CafeDenSL { get; set; }

            public TongTien()
            {
                CafeSuaSL = 0;
                CafeDaSL = 0;
                CafeDenSL = 0;
            }

            public int TinhTongTien()
            {
                int total = CafeSuaSL * 25000 + CafeDaSL * 20000 + CafeDenSL * 15000;

                if (IsSanVuon)
                {
                    // Giảm giá 15% nếu chọn sân vườn
                    total = (int)(total * 0.85);
                }

                return total;
            }
        }
        private void BtnTongTien_Click(object sender, EventArgs e)
        {
            TongTien tongTienCalculator = new TongTien
            {
                IsSanVuon = chkSanVuon.Checked, // Đây là cái checkbox nếu ông check vào dòng này sẽ đúng
                // Nhập số lượng từng cái sau nó nó sẽ tính tổng tiền
                CafeSuaSL = int.Parse(txtCafeSuaSL.Text), 
                CafeDaSL = int.Parse(txtCafeDaSL.Text),
                CafeDenSL = int.Parse(txtCafeDenSL.Text)
            };

            int total = tongTienCalculator.TinhTongTien();
            txtTongTien.Text = total.ToString("N0"); // Hiển thị tổng tiền với định dạng số
        }

        private void BtnNhapMoi_Click(object sender, EventArgs e)
        {
            chkSanVuon.Checked = false;
            txtCafeSuaSL.Text = "0";
            txtCafeDaSL.Text = "0";
            txtCafeDenSL.Text = "0";
            txtTongTien.Text = string.Empty;
            errorProvider.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
