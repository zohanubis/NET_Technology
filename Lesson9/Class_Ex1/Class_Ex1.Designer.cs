
namespace Class_Ex1
{
    partial class Class_Ex1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.MaSinhVien = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.Lop = new System.Windows.Forms.Label();
            this.TenSinhVien = new System.Windows.Forms.Label();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(715, 175);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 34);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(36, 233);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(988, 303);
            this.dataGridView.TabIndex = 63;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(254, 21);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(274, 32);
            this.txtMaSinhVien.TabIndex = 62;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.Location = new System.Drawing.Point(539, 21);
            this.NgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(122, 26);
            this.NgaySinh.TabIndex = 60;
            this.NgaySinh.Text = "Ngày Sinh";
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.AutoSize = true;
            this.MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSinhVien.Location = new System.Drawing.Point(89, 21);
            this.MaSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Size = new System.Drawing.Size(154, 26);
            this.MaSinhVien.TabIndex = 59;
            this.MaSinhVien.Text = "Mã Sinh Viên";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(562, 175);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 34);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(413, 175);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 34);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(252, 175);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSinhVien.Location = new System.Drawing.Point(254, 80);
            this.txtTenSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(274, 32);
            this.txtTenSinhVien.TabIndex = 68;
            // 
            // Lop
            // 
            this.Lop.AutoSize = true;
            this.Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lop.Location = new System.Drawing.Point(571, 86);
            this.Lop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lop.Name = "Lop";
            this.Lop.Size = new System.Drawing.Size(51, 26);
            this.Lop.TabIndex = 66;
            this.Lop.Text = "Lớp";
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.AutoSize = true;
            this.TenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSinhVien.Location = new System.Drawing.Point(89, 80);
            this.TenSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.Size = new System.Drawing.Size(161, 26);
            this.TenSinhVien.TabIndex = 65;
            this.TenSinhVien.Text = "Tên Sinh Viên";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Items.AddRange(new object[] {
            "Tất cả lớp"});
            this.comboBoxLop.Location = new System.Drawing.Point(694, 86);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(286, 33);
            this.comboBoxLop.TabIndex = 70;
            this.comboBoxLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxLop_SelectedIndexChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(694, 18);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(274, 32);
            this.txtNgaySinh.TabIndex = 71;
            // 
            // Class_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 573);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.Lop);
            this.Controls.Add(this.TenSinhVien);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.MaSinhVien);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Class_Ex1";
            this.Text = "Bài 1 - Bài Tập Trên Lớp";
            this.Load += new System.EventHandler(this.Class_Ex1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.Label MaSinhVien;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.Label Lop;
        private System.Windows.Forms.Label TenSinhVien;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.TextBox txtNgaySinh;
    }
}

