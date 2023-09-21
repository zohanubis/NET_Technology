using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revise_Test3_Ex3
{
    public partial class CafeGr : Form
    {
        private TongTien tongTien;
        private bool btnTongTienClicked;
        public CafeGr()
        {
            InitializeComponent();
            tongTien = new TongTien();
            btnTongTienClicked = false;
        }
        public class TongTien
        {
            public bool CafeSua { get; set; }
            public bool CafeDa { get; set; }
            public bool CafeDen { get; set; }
            public int SLCafeSua { get; set; }
            public int SLCafeDa { get; set; }
            public int SLCafeDen { get; set; }

            public void Reset()
            {
                CafeSua = false;
                CafeDa = false;
                CafeDen = false;
                SLCafeSua = 0;
                SLCafeDa = 0;
                SLCafeDen = 0;
            }

            public double CalculateTotalAmount(bool isPhongVip, bool isSanVuon)
            {
                double totalAmount = 0;

                if (CafeSua)
                    totalAmount += 25000 * SLCafeSua;

                if (CafeDa)
                    totalAmount += 20000 * SLCafeDa;

                if (CafeDen)
                    totalAmount += 15000 * SLCafeDen;

                if (isSanVuon)
                    totalAmount *= 0.85;

                return totalAmount;
            }
        }
        private void btnTongTien_Click(object sender, EventArgs e)
        {
            double totalAmount = tongTien.CalculateTotalAmount(checkPhongVip.Checked, checkSanVuon.Checked);
            txtTongTien.Text = totalAmount.ToString();

            btnTongTien.Enabled = false;
            btnReset.Enabled = true;
            btnTongTienClicked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnTongTienClicked)
            {
                radioCafeSua.Checked = false;
                radioCafeDa.Checked = false;
                radioCafeDen.Checked = false;
                txtSLSua.Text = string.Empty;
                txtSLDa.Text = string.Empty;
                txtSLDen.Text = string.Empty;
                txtTongTien.Text = string.Empty;
                checkPhongVip.Checked = false;
                checkSanVuon.Checked = false;
                errorProvider.Clear();
                tongTien.Reset();

                btnTongTien.Enabled = true; 
                btnReset.Enabled = false;
                btnTongTienClicked = false; 
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void radioCafeSua_CheckedChanged(object sender, EventArgs e)
        {
            txtSLSua.Enabled = radioCafeSua.Checked;
            tongTien.CafeSua = radioCafeSua.Checked;
        }

        private void radioCafeDa_CheckedChanged(object sender, EventArgs e)
        {
            txtSLDa.Enabled = radioCafeDa.Checked;
            tongTien.CafeDa = radioCafeDa.Checked;
        }

        private void radioCafeDen_CheckedChanged(object sender, EventArgs e)
        {
            txtSLDen.Enabled = radioCafeDen.Checked;
            tongTien.CafeDen = radioCafeDen.Checked;
        }

        private void txtSLSua_TextChanged(object sender, EventArgs e)
        {
            int SL;
            if (int.TryParse(txtSLSua.Text, out SL))
                tongTien.SLCafeSua = SL;
            else
                errorProvider.SetError(txtSLSua, "Vui lòng nhập số lượng.");
        }

        private void txtSLDa_TextChanged(object sender, EventArgs e)
        {
            int SL;
            if (int.TryParse(txtSLDa.Text, out SL))
                tongTien.SLCafeDa = SL;
            else
                errorProvider.SetError(txtSLDa, "Vui lòng nhập số lượng.");
        }

        private void txtSLDen_TextChanged(object sender, EventArgs e)
        {
            int SL;
            if (int.TryParse(txtSLDen.Text, out SL))
                tongTien.SLCafeDen = SL;
            else
                errorProvider.SetError(txtSLDen, "Vui lòng nhập số lượng.");
        }

        private void CafeGr_Load(object sender, EventArgs e)
        {
            txtSLSua.Enabled = false;
            txtSLDa.Enabled = false;
            txtSLDen.Enabled = false;
            btnReset.Enabled = false;
        }
    }
}
