using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Bai3 : Form
    {
        private TongTien tongTien;
        private bool btnTongTienClicked;
        public Bai3()
        {
            InitializeComponent();
            tongTien = new TongTien();
            btnTongTienClicked = false;
        }
        public class TongTien
        {
            public bool BoBitTet { get; set; }
            public bool BoNe { get; set; }
            public bool CaBaSa { get; set; }
            public int SLBoBitTet { get; set; }
            public int SLBoNe { get; set; }
            public int SLCaBaSa { get; set; }

            public void Reset()
            {
                BoBitTet = false;
                BoNe = false;
                CaBaSa = false;
                SLBoBitTet = 0;
                SLBoNe = 0;
                SLCaBaSa = 0;
            }

            public double CalculateTotalAmount(bool isNuocNgoai, bool isVietNam)
            {
                double totalAmount = 0;

                if (BoBitTet)
                    totalAmount += 80000 * SLBoBitTet;

                if (BoNe)
                    totalAmount += 100000 * SLBoNe;

                if (CaBaSa)
                    totalAmount += 150000 * SLCaBaSa;

                if (isVietNam)
                    totalAmount *= 0.85;

                return totalAmount;
            }
        }
        private void btnTongTien_Click(object sender, EventArgs e)
        {
            double totalAmount = tongTien.CalculateTotalAmount(checkNuocNgoai.Checked, checkVietNam.Checked);
            txtTongTien.Text = totalAmount.ToString();

            btnTongTien.Enabled = false;
            btnReset.Enabled = true;
            btnTongTienClicked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnTongTienClicked)
            {
                radioBoBitTet.Checked = true
                    ;
                radioBoNe.Checked = false;
                radioCaBasa.Checked = false;
                txtSLBoBitTet.Text = string.Empty;
                txtSLBoNe.Text = string.Empty;
                txtSLCaBaSa.Text = string.Empty;
                txtTongTien.Text = string.Empty;
                checkNuocNgoai.Checked = false;
                checkVietNam.Checked = false;
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

        private void txtSLBoBitTet_TextChanged(object sender, EventArgs e)
        {
            int SL;
            if (int.TryParse(txtSLBoBitTet.Text, out SL))
                tongTien.SLBoBitTet = SL;
            else
                errorProvider.SetError(txtSLBoBitTet, "Vui lòng nhập số lượng.");
        }

        private void txtSLBoNe_TextChanged(object sender, EventArgs e)
        {
            int SL;
            if (int.TryParse(txtSLBoNe.Text, out SL))
            {
                tongTien.SLBoNe = SL;
            }
            else
                errorProvider.SetError(txtSLBoNe, "Vui lòng nhập số lượng.");
        }

        private void txtSLCaBaSa_TextChanged(object sender, EventArgs e)
        {
            int SL;
            if (int.TryParse(txtSLCaBaSa.Text, out SL))
                tongTien.SLCaBaSa = SL;
            else
                errorProvider.SetError(txtSLCaBaSa, "Vui lòng nhập số lượng.");
        }

        private void radioBoBitTet_CheckedChanged(object sender, EventArgs e)
        {
            txtSLBoBitTet.Enabled = radioBoBitTet.Checked;
            tongTien.BoBitTet = radioBoBitTet.Checked;
        }

        private void radioBoNe_CheckedChanged(object sender, EventArgs e)
        {
            txtSLBoNe.Enabled = radioBoNe.Checked;
            tongTien.BoNe = radioBoNe.Checked;
        }

        private void radioCaBasa_CheckedChanged(object sender, EventArgs e)
        {
            txtSLCaBaSa.Enabled = radioCaBasa.Checked;
            tongTien.CaBaSa = radioCaBasa.Checked;
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            txtSLBoBitTet.Enabled = false;
            txtSLBoNe.Enabled = false;
            txtSLCaBaSa.Enabled = false;
            btnReset.Enabled = false;
        }
    }
}
