
namespace Class_Ex2
{
    partial class Class_Ex2
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
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.TenSinhVien = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.TenKhoa = new System.Windows.Forms.Label();
            this.MaSinhVien = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Items.AddRange(new object[] {
            "Tất cả lớp"});
            this.comboBoxKhoa.Location = new System.Drawing.Point(722, 57);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(286, 33);
            this.comboBoxKhoa.TabIndex = 83;
            this.comboBoxKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKhoa_SelectedIndexChanged);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(279, 116);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(274, 32);
            this.txtTenLop.TabIndex = 82;
            this.txtTenLop.TextChanged += new System.EventHandler(this.txtTenLop_TextChanged);
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.AutoSize = true;
            this.TenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSinhVien.Location = new System.Drawing.Point(114, 116);
            this.TenSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.Size = new System.Drawing.Size(97, 26);
            this.TenSinhVien.TabIndex = 80;
            this.TenSinhVien.Text = "Tên Lớp";
            this.TenSinhVien.Click += new System.EventHandler(this.TenSinhVien_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(740, 211);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 34);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(61, 269);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(988, 303);
            this.dataGridView.TabIndex = 78;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(279, 57);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(274, 32);
            this.txtMaLop.TabIndex = 77;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSize = true;
            this.TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhoa.Location = new System.Drawing.Point(564, 57);
            this.TenKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Size = new System.Drawing.Size(113, 26);
            this.TenKhoa.TabIndex = 76;
            this.TenKhoa.Text = "Tên Khoa";
            this.TenKhoa.Click += new System.EventHandler(this.TenKhoa_Click);
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.AutoSize = true;
            this.MaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSinhVien.Location = new System.Drawing.Point(114, 57);
            this.MaSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Size = new System.Drawing.Size(90, 26);
            this.MaSinhVien.TabIndex = 75;
            this.MaSinhVien.Text = "Mã Lớp";
            this.MaSinhVien.Click += new System.EventHandler(this.MaSinhVien_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(587, 211);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 34);
            this.btnEdit.TabIndex = 74;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(438, 211);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 34);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(277, 211);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Class_Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 626);
            this.Controls.Add(this.comboBoxKhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.TenSinhVien);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.TenKhoa);
            this.Controls.Add(this.MaSinhVien);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Class_Ex2";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Class_Ex2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label TenSinhVien;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label TenKhoa;
        private System.Windows.Forms.Label MaSinhVien;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

