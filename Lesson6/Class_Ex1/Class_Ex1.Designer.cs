
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
            this.components = new System.ComponentModel.Container();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDanToc = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.checkAnh = new System.Windows.Forms.CheckBox();
            this.checkPhap = new System.Windows.Forms.CheckBox();
            this.checkTrung = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.listViewLiLich = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDanToc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColNgoaiNgu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(148, 56);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(280, 20);
            this.txtMa.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã sinh viên :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 30);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Họ và Tên :";
            // 
            // comboBoxDanToc
            // 
            this.comboBoxDanToc.FormattingEnabled = true;
            this.comboBoxDanToc.Location = new System.Drawing.Point(148, 152);
            this.comboBoxDanToc.Name = "comboBoxDanToc";
            this.comboBoxDanToc.Size = new System.Drawing.Size(280, 21);
            this.comboBoxDanToc.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Dân Tộc";
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(148, 82);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 24;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(261, 82);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 25;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // checkAnh
            // 
            this.checkAnh.AutoSize = true;
            this.checkAnh.Location = new System.Drawing.Point(148, 114);
            this.checkAnh.Name = "checkAnh";
            this.checkAnh.Size = new System.Drawing.Size(45, 17);
            this.checkAnh.TabIndex = 27;
            this.checkAnh.Text = "Anh";
            this.checkAnh.UseVisualStyleBackColor = true;
            // 
            // checkPhap
            // 
            this.checkPhap.AutoSize = true;
            this.checkPhap.Location = new System.Drawing.Point(261, 114);
            this.checkPhap.Name = "checkPhap";
            this.checkPhap.Size = new System.Drawing.Size(51, 17);
            this.checkPhap.TabIndex = 28;
            this.checkPhap.Text = "Pháp";
            this.checkPhap.UseVisualStyleBackColor = true;
            // 
            // checkTrung
            // 
            this.checkTrung.AutoSize = true;
            this.checkTrung.Location = new System.Drawing.Point(352, 114);
            this.checkTrung.Name = "checkTrung";
            this.checkTrung.Size = new System.Drawing.Size(54, 17);
            this.checkTrung.TabIndex = 29;
            this.checkTrung.Text = "Trung";
            this.checkTrung.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngoại ngữ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 298);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(207, 298);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(331, 298);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // listViewLiLich
            // 
            this.listViewLiLich.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.ColMa,
            this.ColDanToc,
            this.ColGioiTinh,
            this.ColNgoaiNgu});
            this.listViewLiLich.HideSelection = false;
            this.listViewLiLich.Location = new System.Drawing.Point(25, 179);
            this.listViewLiLich.Name = "listViewLiLich";
            this.listViewLiLich.Size = new System.Drawing.Size(402, 97);
            this.listViewLiLich.TabIndex = 36;
            this.listViewLiLich.UseCompatibleStateImageBehavior = false;
            this.listViewLiLich.View = System.Windows.Forms.View.Details;
            this.listViewLiLich.SelectedIndexChanged += new System.EventHandler(this.listViewLiLich_SelectedIndexChanged);
            // 
            // ColName
            // 
            this.ColName.Text = "Họ Tên";
            // 
            // ColMa
            // 
            this.ColMa.Text = "Mã Sinh Viên";
            // 
            // ColDanToc
            // 
            this.ColDanToc.DisplayIndex = 3;
            this.ColDanToc.Text = "Dân Tộc";
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.DisplayIndex = 2;
            this.ColGioiTinh.Text = "Giới Tính";
            // 
            // ColNgoaiNgu
            // 
            this.ColNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // Class_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 347);
            this.Controls.Add(this.listViewLiLich);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkTrung);
            this.Controls.Add(this.checkPhap);
            this.Controls.Add(this.checkAnh);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.comboBoxDanToc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Class_Ex1";
            this.Text = "Lí Lịch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDanToc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.CheckBox checkAnh;
        private System.Windows.Forms.CheckBox checkPhap;
        private System.Windows.Forms.CheckBox checkTrung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListView listViewLiLich;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColMa;
        public System.Windows.Forms.ColumnHeader ColDanToc;
        private System.Windows.Forms.ColumnHeader ColGioiTinh;
        private System.Windows.Forms.ColumnHeader ColNgoaiNgu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

