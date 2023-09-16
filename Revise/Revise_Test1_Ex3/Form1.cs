using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revise_Test1_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!IsMonAnSelected() || !IsLoaiKhachSelected())
            {
                MessageBox.Show("Vui lòng chọn món ăn và loại khách hàng", "Lỗi");
                return;
            }

            decimal giaThucAn = 0;
            if (checkBunBo.Checked)
            {
                giaThucAn += 45000;
            }
            if (checkHuTieu.Checked)
            {
                giaThucAn += 30000;
            }
            if (checkBanhCanh.Checked)
            {
                giaThucAn += 35000;
            }
            if (checkNui.Checked)
            {
                giaThucAn += 28000;
            }

            if (radioKhachQuen.Checked)
            {
                giaThucAn -= giaThucAn * 0.1m;
            }

            // Hiển thị số tiền phải thanh toán
            txtTotal.Text = string.Format("{0:N0}đ", giaThucAn);
        }
        private bool IsMonAnSelected()
        {
            return checkBunBo.Checked || checkHuTieu.Checked || checkBanhCanh.Checked || checkNui.Checked;
        }

        private bool IsLoaiKhachSelected()
        {
            return radioKhachQuen.Checked || radioKhachLa.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
