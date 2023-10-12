
namespace Advanced_Ex2
{
    partial class Advanced_Ex2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLocDuLieu = new System.Windows.Forms.Button();
            this.listViewData = new System.Windows.Forms.ListView();
            this.ColumnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(649, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLocDuLieu
            // 
            this.btnLocDuLieu.AutoSize = true;
            this.btnLocDuLieu.Location = new System.Drawing.Point(512, 12);
            this.btnLocDuLieu.Name = "btnLocDuLieu";
            this.btnLocDuLieu.Size = new System.Drawing.Size(94, 27);
            this.btnLocDuLieu.TabIndex = 4;
            this.btnLocDuLieu.Text = "Lọc Dữ Liệu";
            this.btnLocDuLieu.UseVisualStyleBackColor = true;
            this.btnLocDuLieu.Click += new System.EventHandler(this.btnLocDuLieu_Click);
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnSTT,
            this.columnTenSV,
            this.columnNgaySinh,
            this.columnTenMonHoc,
            this.columnDiem});
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(50, 49);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(701, 353);
            this.listViewData.TabIndex = 3;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.Text = "STT";
            // 
            // columnTenSV
            // 
            this.columnTenSV.Text = "Tên Sinh Viên";
            this.columnTenSV.Width = 152;
            // 
            // columnNgaySinh
            // 
            this.columnNgaySinh.Text = "Ngày Sinh";
            this.columnNgaySinh.Width = 173;
            // 
            // columnTenMonHoc
            // 
            this.columnTenMonHoc.Text = "Tên Môn Học";
            this.columnTenMonHoc.Width = 130;
            // 
            // columnDiem
            // 
            this.columnDiem.Text = "Điểm";
            // 
            // comboBoxMonHoc
            // 
            this.comboBoxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonHoc.FormattingEnabled = true;
            this.comboBoxMonHoc.Location = new System.Drawing.Point(277, 12);
            this.comboBoxMonHoc.Name = "comboBoxMonHoc";
            this.comboBoxMonHoc.Size = new System.Drawing.Size(164, 30);
            this.comboBoxMonHoc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng Điểm";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(461, 415);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(87, 22);
            this.txtTongDiem.TabIndex = 9;
            // 
            // Advanced_Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMonHoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLocDuLieu);
            this.Controls.Add(this.listViewData);
            this.Name = "Advanced_Ex2";
            this.Text = "Quản Lí Điểm";
            this.Load += new System.EventHandler(this.Advanced_Ex2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLocDuLieu;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader ColumnSTT;
        private System.Windows.Forms.ColumnHeader columnTenSV;
        private System.Windows.Forms.ColumnHeader columnNgaySinh;
        private System.Windows.Forms.ColumnHeader columnTenMonHoc;
        private System.Windows.Forms.ComboBox comboBoxMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongDiem;
    }
}

