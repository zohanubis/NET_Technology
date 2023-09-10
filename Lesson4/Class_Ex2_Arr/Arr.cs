using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex2_Arr
{
    public partial class Arr : Form
    {
        private int[] arr;

        public Arr()
        {
            InitializeComponent();
            this.FormClosing += Ex2_Arr_FormClosing;

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox txtJoin và chuyển thành mảng số nguyên
            string input = txtJoin.Text;
            string[] values = input.Split(' ');
            arr = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            // Hiển thị mảng trong TextBox txtResult
            txtResult.Text = input;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtJoin.Text = "";
            txtResult.Text = "";
            txtGiaTriCanTim.Text = "";
            txtViTriCanTim.Text = "";
            txtGiaTriCanXoa.Text = "";
            txtViTriCanXoa.Text = "";
            txtGiaTriCanThem.Text = "";
            txtViTriCanThem.Text = "";
            radioGiaTriCanTim.Checked = false;
            radioViTriCanTim.Checked = false;
            radioGiaTriCanXoa.Checked = false;
            radioViTriCanXoa.Checked = false;
            radioGiaTriCanThem.Checked = false;
            radioSXTang.Checked = false;
            radioSXGiam.Checked = false;
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            if (radioSXTang.Checked)
            {
                Array.Sort(arr);
            }
            else if (radioSXGiam.Checked)
            {
                Array.Sort(arr);
                Array.Reverse(arr);
            }
            // Xử lí radio Tìm Max Min
            if (radioGiaTriCanTim.Checked)
            {
                int targetValue = int.Parse(txtGiaTriCanTim.Text);
                int index = Array.IndexOf(arr, targetValue);

                if (index != -1)
                {
                    txtKQTimDuoc.Text = " " + targetValue;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị");

                }
            }
            else if (radioViTriCanTim.Checked)
            {
                int targetIndex = int.Parse(txtViTriCanTim.Text);
                if (targetIndex >= 0 && targetIndex < arr.Length)
                {
                    int value = arr[targetIndex];
                    txtKQTimDuoc.Text = "" + value;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị");

                }
            }
            else if (radioGiaTriCanXoa.Checked)
            {
                int targetValue = int.Parse(txtGiaTriCanXoa.Text);
                int index = Array.IndexOf(arr, targetValue);

                if (index != -1)
                {
                    arr = arr.Where((val, i) => i != index).ToArray();
                    txtResult.Text = string.Join(" ", arr);
                    Array.Sort(arr);

                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị");
                }
            }
            else if (radioViTriCanXoa.Checked)
            {
                int targetIndex = int.Parse(txtViTriCanXoa.Text);
                if (targetIndex >= 0 && targetIndex < arr.Length)
                {
                    arr = arr.Where((val, i) => i != targetIndex).ToArray();
                    txtResult.Text = string.Join(" ", arr);
                    Array.Sort(arr);

                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị");
                }
            }
            else if (radioGiaTriCanThem.Checked)
            {
                int targetValue = int.Parse(txtGiaTriCanThem.Text);
                int targetIndex = int.Parse(txtViTriCanThem.Text);

                if (targetIndex >= 0 && targetIndex <= arr.Length)
                {
                    int[] newArray = new int[arr.Length + 1];
                    for (int i = 0; i < targetIndex; i++)
                    {
                        newArray[i] = arr[i];
                    }
                    newArray[targetIndex] = targetValue;
                    for (int i = targetIndex + 1; i < newArray.Length; i++)
                    {
                        newArray[i] = arr[i - 1];
                    }
                    arr = newArray;
                    txtResult.Text = string.Join(" ", arr);
                    Array.Sort(arr);

                }
                else
                {
                    MessageBox.Show("Vị trí không hợp lệ");
                }
            }
            else if (radioGiaTriThayThe.Checked)
            {
                int targetValue = int.Parse(txtGiaTriThayThe.Text);
                int replaceValue = int.Parse(txtSoThayThe.Text);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == targetValue)
                    {
                        arr[i] = replaceValue;
                    }
                }
                txtResult.Text = string.Join(" ", arr);
            }
            else if (radioViTriThayThe.Checked)
            {
                int targetIndex = int.Parse(txtViTriCanThayThe.Text);
                int replaceValue = int.Parse(txtSoThayThe.Text);

                if (targetIndex >= 0 && targetIndex < arr.Length)
                {
                    arr[targetIndex] = replaceValue;
                    txtResult.Text = string.Join(" ", arr);
                }
                else
                {
                    MessageBox.Show("Vị trí không hợp lệ");
                }
            }


            txtResult.Text = string.Join(" ", arr);
        }
        private void Ex2_Arr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không ? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { this.Close(); }
        }

        private void BtnTong_Click(object sender, EventArgs e)
        {
            if (radioTongMang.Checked)
            {
                int sum = CalculateSum(arr);
                txtTongMang.Text = sum.ToString();
            }
            else if (radioTongChan.Checked)
            {
                int sumEven = CalculateSumEven(arr);
                txtTongChan.Text = sumEven.ToString();
            }
            else if (radioTongLe.Checked)
            {
                int sumOdd = CalculateSumOdd(arr);
                txtTongLe.Text = sumOdd.ToString();
            }
        }

        private void BtnTimGiaTriMaxMin_Click(object sender, EventArgs e)
        {
            if (radioGiaTriMax.Checked)
            {
                int max = FindMaxValue(arr);
                txtGiaTriLonNhat.Text = max.ToString();
            }
            else if (radioGiaTriMin.Checked)
            {
                int min = FindMinValue(arr);
                txtGiaTriNhoNhat.Text = min.ToString();
            }
        }
        private int CalculateSum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        private int CalculateSumEven(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        private int CalculateSumOdd(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        private int FindMaxValue(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        private int FindMinValue(int[] array)
        {
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
