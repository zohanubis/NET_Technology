
namespace Home
{
    partial class HomeEx
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
            this.comboBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.Diem = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TenKhoa = new System.Windows.Forms.Label();
            this.SinhVien = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxSinhVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMonHoc
            // 
            this.comboBoxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonHoc.FormattingEnabled = true;
            this.comboBoxMonHoc.Items.AddRange(new object[] {
            "Tất cả lớp"});
            this.comboBoxMonHoc.Location = new System.Drawing.Point(765, 67);
            this.comboBoxMonHoc.Name = "comboBoxMonHoc";
            this.comboBoxMonHoc.Size = new System.Drawing.Size(286, 33);
            this.comboBoxMonHoc.TabIndex = 94;
            this.comboBoxMonHoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonHoc_SelectedIndexChanged);
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(322, 126);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(274, 32);
            this.txtDiem.TabIndex = 93;
            // 
            // Diem
            // 
            this.Diem.AutoSize = true;
            this.Diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diem.Location = new System.Drawing.Point(157, 126);
            this.Diem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diem.Name = "Diem";
            this.Diem.Size = new System.Drawing.Size(68, 26);
            this.Diem.TabIndex = 92;
            this.Diem.Text = "Điểm";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(783, 221);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 34);
            this.btnExit.TabIndex = 91;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(104, 279);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(988, 303);
            this.dataGridView.TabIndex = 90;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSize = true;
            this.TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhoa.Location = new System.Drawing.Point(607, 67);
            this.TenKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Size = new System.Drawing.Size(106, 26);
            this.TenKhoa.TabIndex = 88;
            this.TenKhoa.Text = "Môn Học";
            // 
            // SinhVien
            // 
            this.SinhVien.AutoSize = true;
            this.SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinhVien.Location = new System.Drawing.Point(157, 67);
            this.SinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SinhVien.Name = "SinhVien";
            this.SinhVien.Size = new System.Drawing.Size(115, 26);
            this.SinhVien.TabIndex = 87;
            this.SinhVien.Text = "Sinh Viên";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(630, 221);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 34);
            this.btnEdit.TabIndex = 86;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(481, 221);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 34);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(320, 221);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 84;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxSinhVien
            // 
            this.comboBoxSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSinhVien.FormattingEnabled = true;
            this.comboBoxSinhVien.Items.AddRange(new object[] {
            "Tất cả lớp"});
            this.comboBoxSinhVien.Location = new System.Drawing.Point(310, 67);
            this.comboBoxSinhVien.Name = "comboBoxSinhVien";
            this.comboBoxSinhVien.Size = new System.Drawing.Size(286, 33);
            this.comboBoxSinhVien.TabIndex = 95;
            this.comboBoxSinhVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxSinhVien_SelectedIndexChanged);
            // 
            // HomeEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 648);
            this.Controls.Add(this.comboBoxSinhVien);
            this.Controls.Add(this.comboBoxMonHoc);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.Diem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.TenKhoa);
            this.Controls.Add(this.SinhVien);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "HomeEx";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeEx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMonHoc;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label Diem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label TenKhoa;
        private System.Windows.Forms.Label SinhVien;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxSinhVien;
    }
}

