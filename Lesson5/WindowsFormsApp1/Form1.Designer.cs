﻿
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoaTatCaPT = new System.Windows.Forms.Button();
            this.btnChuyenChuoiInHoaODauTu = new System.Windows.Forms.Button();
            this.btnChuyenChuoiInThuong = new System.Windows.Forms.Button();
            this.btnChuyenChuoiInHoa = new System.Windows.Forms.Button();
            this.btnXoaPTHoLe = new System.Windows.Forms.Button();
            this.btnXoaPhanTuTenSon = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDaChon = new System.Windows.Forms.Button();
            this.btnRandomName = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnXoaTatCaPT
            // 
            this.btnXoaTatCaPT.AutoSize = true;
            this.btnXoaTatCaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTatCaPT.Location = new System.Drawing.Point(373, 338);
            this.btnXoaTatCaPT.Name = "btnXoaTatCaPT";
            this.btnXoaTatCaPT.Size = new System.Drawing.Size(367, 30);
            this.btnXoaTatCaPT.TabIndex = 25;
            this.btnXoaTatCaPT.Text = "Xóa tất cả các phần tử";
            this.btnXoaTatCaPT.UseVisualStyleBackColor = true;
            this.btnXoaTatCaPT.Click += new System.EventHandler(this.btnXoaTatCaPT_Click);
            // 
            // btnChuyenChuoiInHoaODauTu
            // 
            this.btnChuyenChuoiInHoaODauTu.AutoSize = true;
            this.btnChuyenChuoiInHoaODauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenChuoiInHoaODauTu.Location = new System.Drawing.Point(373, 302);
            this.btnChuyenChuoiInHoaODauTu.Name = "btnChuyenChuoiInHoaODauTu";
            this.btnChuyenChuoiInHoaODauTu.Size = new System.Drawing.Size(367, 30);
            this.btnChuyenChuoiInHoaODauTu.TabIndex = 24;
            this.btnChuyenChuoiInHoaODauTu.Text = "Chuyển PT đang chọn thành chữ HOA đầu mỗi từ";
            this.btnChuyenChuoiInHoaODauTu.UseVisualStyleBackColor = true;
            this.btnChuyenChuoiInHoaODauTu.Click += new System.EventHandler(this.btnChuyenChuoiInHoaODauTu_Click);
            // 
            // btnChuyenChuoiInThuong
            // 
            this.btnChuyenChuoiInThuong.AutoSize = true;
            this.btnChuyenChuoiInThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenChuoiInThuong.Location = new System.Drawing.Point(373, 266);
            this.btnChuyenChuoiInThuong.Name = "btnChuyenChuoiInThuong";
            this.btnChuyenChuoiInThuong.Size = new System.Drawing.Size(367, 30);
            this.btnChuyenChuoiInThuong.TabIndex = 23;
            this.btnChuyenChuoiInThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnChuyenChuoiInThuong.UseVisualStyleBackColor = true;
            this.btnChuyenChuoiInThuong.Click += new System.EventHandler(this.btnChuyenChuoiInThuong_Click);
            // 
            // btnChuyenChuoiInHoa
            // 
            this.btnChuyenChuoiInHoa.AutoSize = true;
            this.btnChuyenChuoiInHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenChuoiInHoa.Location = new System.Drawing.Point(373, 230);
            this.btnChuyenChuoiInHoa.Name = "btnChuyenChuoiInHoa";
            this.btnChuyenChuoiInHoa.Size = new System.Drawing.Size(367, 30);
            this.btnChuyenChuoiInHoa.TabIndex = 22;
            this.btnChuyenChuoiInHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            this.btnChuyenChuoiInHoa.UseVisualStyleBackColor = true;
            this.btnChuyenChuoiInHoa.Click += new System.EventHandler(this.btnChuyenChuoiInHoa_Click);
            // 
            // btnXoaPTHoLe
            // 
            this.btnXoaPTHoLe.AutoSize = true;
            this.btnXoaPTHoLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPTHoLe.Location = new System.Drawing.Point(373, 194);
            this.btnXoaPTHoLe.Name = "btnXoaPTHoLe";
            this.btnXoaPTHoLe.Size = new System.Drawing.Size(367, 30);
            this.btnXoaPTHoLe.TabIndex = 21;
            this.btnXoaPTHoLe.Text = "Xóa phần tử có họ là Lê";
            this.btnXoaPTHoLe.UseVisualStyleBackColor = true;
            this.btnXoaPTHoLe.Click += new System.EventHandler(this.btnXoaPTHoLe_Click);
            // 
            // btnXoaPhanTuTenSon
            // 
            this.btnXoaPhanTuTenSon.AutoSize = true;
            this.btnXoaPhanTuTenSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanTuTenSon.Location = new System.Drawing.Point(373, 158);
            this.btnXoaPhanTuTenSon.Name = "btnXoaPhanTuTenSon";
            this.btnXoaPhanTuTenSon.Size = new System.Drawing.Size(367, 30);
            this.btnXoaPhanTuTenSon.TabIndex = 20;
            this.btnXoaPhanTuTenSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaPhanTuTenSon.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuTenSon.Click += new System.EventHandler(this.btnXoaPhanTuTenSon_Click);
            // 
            // btnXoaPhanTuDaChon
            // 
            this.btnXoaPhanTuDaChon.AutoSize = true;
            this.btnXoaPhanTuDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanTuDaChon.Location = new System.Drawing.Point(373, 122);
            this.btnXoaPhanTuDaChon.Name = "btnXoaPhanTuDaChon";
            this.btnXoaPhanTuDaChon.Size = new System.Drawing.Size(367, 30);
            this.btnXoaPhanTuDaChon.TabIndex = 19;
            this.btnXoaPhanTuDaChon.Text = "Xóa phần tử đã chọn";
            this.btnXoaPhanTuDaChon.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDaChon.Click += new System.EventHandler(this.btnXoaPhanTuDaChon_Click);
            // 
            // btnRandomName
            // 
            this.btnRandomName.AutoSize = true;
            this.btnRandomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomName.Location = new System.Drawing.Point(60, 83);
            this.btnRandomName.Name = "btnRandomName";
            this.btnRandomName.Size = new System.Drawing.Size(269, 30);
            this.btnRandomName.TabIndex = 18;
            this.btnRandomName.Text = "Nhập Tên Ngẫu Nhiên";
            this.btnRandomName.UseVisualStyleBackColor = true;
            this.btnRandomName.Click += new System.EventHandler(this.btnRandomName_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(60, 122);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(269, 244);
            this.listBox.TabIndex = 17;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaTatCaPT);
            this.Controls.Add(this.btnChuyenChuoiInHoaODauTu);
            this.Controls.Add(this.btnChuyenChuoiInThuong);
            this.Controls.Add(this.btnChuyenChuoiInHoa);
            this.Controls.Add(this.btnXoaPTHoLe);
            this.Controls.Add(this.btnXoaPhanTuTenSon);
            this.Controls.Add(this.btnXoaPhanTuDaChon);
            this.Controls.Add(this.btnRandomName);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaTatCaPT;
        private System.Windows.Forms.Button btnChuyenChuoiInHoaODauTu;
        private System.Windows.Forms.Button btnChuyenChuoiInThuong;
        private System.Windows.Forms.Button btnChuyenChuoiInHoa;
        private System.Windows.Forms.Button btnXoaPTHoLe;
        private System.Windows.Forms.Button btnXoaPhanTuTenSon;
        private System.Windows.Forms.Button btnXoaPhanTuDaChon;
        private System.Windows.Forms.Button btnRandomName;
        private System.Windows.Forms.ListBox listBox;
    }
}

