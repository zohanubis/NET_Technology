using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Hotel
{
    public partial class Hotel : Form
    {
        decimal tongTien = 0;
        int tongSoKhach = 0;
        public Hotel()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string tenKH = txtNameKH.Text;
            string diaChi = txtAdress.Text;
            int soNgayO = 0;

            if (!int.TryParse(txtSoNgayO.Text, out soNgayO) || soNgayO <= 0)
            {
                MessageBox.Show("Số ngày ở phải là số nguyên dương.");
                return;
            }

            decimal giaPhong = 0;
            if (radioPhongDon.Checked)
            {
                giaPhong = 300000;
            }
            else if (radioPhongDoi.Checked)
            {
                giaPhong = 350000;
            }
            else if (radioPhongBa.Checked)
            {
                giaPhong = 400000;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng.");
                return;
            }

            decimal giaTienNghi = 0;
            if (checkTivi.Checked)
            {
                giaTienNghi += 10000;
            }
            if (checkInternet.Checked)
            {
                giaTienNghi += 10000;
            }
            if (checkMayNuocNong.Checked)
            {
                giaTienNghi += 10000;
            }

            decimal giaDichVu = 0;
            if (checkKaraoke.Checked)
            {
                giaDichVu += 50000;
            }
            if (checkAnSang.Checked)
            {
                giaDichVu += 15000 * soNgayO;
            }

            decimal thanhTien = (giaPhong + giaTienNghi) * soNgayO + giaDichVu;

            tongTien += thanhTien;
            tongSoKhach++;

            txtThanhTien.Text = thanhTien.ToString("C");
            btnTongKet.Enabled = true;
            btnNhapMoi.Enabled = true;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtNameKH.Clear();
            txtAdress.Clear();
            txtSoNgayO.Clear();
            radioPhongDon.Checked = false;
            radioPhongDoi.Checked = false;
            radioPhongBa.Checked = false;
            checkTivi.Checked = false;
            checkInternet.Checked = false;
            checkMayNuocNong.Checked = false;
            checkKaraoke.Checked = false;
            checkAnSang.Checked = false;
            txtThanhTien.Text = "";
            btnTinhTien.Enabled = true;
            btnNhapMoi.Enabled = false;
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoLuotNguoi.Text = tongSoKhach.ToString();
            txtTongTien.Text = tongTien.ToString("C");

            tongTien = 0;
            tongSoKhach = 0;

            txtNameKH.Clear();
            txtAdress.Clear();
            txtSoNgayO.Clear();
            radioPhongDon.Checked = false;
            radioPhongDoi.Checked = false;
            radioPhongBa.Checked = false;
            checkTivi.Checked = false;
            checkInternet.Checked = false;
            checkMayNuocNong.Checked = false;
            checkKaraoke.Checked = false;
            checkAnSang.Checked = false;

            btnTongKet.Enabled = false;
            btnNhapMoi.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            txtNameKH.Focus();
            btnTongKet.Enabled = false;
            btnNhapMoi.Enabled = false;
            txtThanhTien.Text = "";
            txtSoLuotNguoi.Text = "";
            txtTongTien.Text = "";
        }
    }
}
