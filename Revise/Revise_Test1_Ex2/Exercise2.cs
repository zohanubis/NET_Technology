using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revise_Test1_Ex2
{
    public partial class Exercise2 : Form
    {
        private List<int> arr;
        public Exercise2()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtJoin.Text, out int n) && n> 0)
            {
                RandomNumbers(n);
                ShowListArr();
            }
           
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(arr == null || arr.Count == 0)
            {
                MessageBox.Show("Hãy tạo dãy số trước khi xử lí");
                return;
            }
            TimVaHienThiSoCucDai();
            DemBoiSoCua3();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RandomNumbers (int n)
        {
            Random ranDom = new Random(0);
            arr = new List<int>(); 

            for(int i = 0; i< n; i++)
            {
                int numbersRan = ranDom.Next(1, 100);
                arr.Add(numbersRan);
            }
        }
        private void ShowListArr()
        {
            string chuoiDaySo = string.Join(" ", arr);
            txtList.Text = chuoiDaySo;
        }
        private void TimVaHienThiSoCucDai()
        {
            List<int> phanTuCucDai = new List<int>();

            for (int i = 1; i < arr.Count - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    phanTuCucDai.Add(arr[i]);
                }
            }
            string chuoiCucDai = string.Join(" ", phanTuCucDai);
            txtPhanTuCucDai.Text = ($"Các phần tử cực đại : {chuoiCucDai}");


        }
        private void DemBoiSoCua3()
        {
            int count = arr.Count(num => num % 3 == 0);
            txtKQBoiSo3.Text = ($"Các phần tử là bội số của 3 : {count}");
        }
    }
}
