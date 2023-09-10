
namespace Class_Ex3_CafeSV
{
    partial class CafeSV
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongThanhToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupFood = new System.Windows.Forms.GroupBox();
            this.checkMiCay = new System.Windows.Forms.CheckBox();
            this.myMiXaoBo = new System.Windows.Forms.CheckBox();
            this.checkMyTomTrung = new System.Windows.Forms.CheckBox();
            this.checkBanhMyCa = new System.Windows.Forms.CheckBox();
            this.checkBanhMyTrung = new System.Windows.Forms.CheckBox();
            this.groupDrink = new System.Windows.Forms.GroupBox();
            this.radioCafeKem = new System.Windows.Forms.RadioButton();
            this.radioCafeDa = new System.Windows.Forms.RadioButton();
            this.radioCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.radioCafeSua = new System.Windows.Forms.RadioButton();
            this.radioCafeDen = new System.Windows.Forms.RadioButton();
            this.checkSV = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupFood.SuspendLayout();
            this.groupDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 139;
            this.label4.Text = "Tổng Tiền Thanh Toán";
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.Location = new System.Drawing.Point(268, 409);
            this.txtTongThanhToan.Multiline = true;
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.Size = new System.Drawing.Size(276, 26);
            this.txtTongThanhToan.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 137;
            this.label5.Text = "Tổng Khách Hàng";
            // 
            // txtTongKH
            // 
            this.txtTongKH.Location = new System.Drawing.Point(268, 368);
            this.txtTongKH.Multiline = true;
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(276, 26);
            this.txtTongKH.TabIndex = 136;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(455, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 135;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(323, 326);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 134;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(198, 326);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 133;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(77, 326);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 132;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // groupFood
            // 
            this.groupFood.Controls.Add(this.checkMiCay);
            this.groupFood.Controls.Add(this.myMiXaoBo);
            this.groupFood.Controls.Add(this.checkMyTomTrung);
            this.groupFood.Controls.Add(this.checkBanhMyCa);
            this.groupFood.Controls.Add(this.checkBanhMyTrung);
            this.groupFood.Location = new System.Drawing.Point(308, 154);
            this.groupFood.Name = "groupFood";
            this.groupFood.Size = new System.Drawing.Size(247, 151);
            this.groupFood.TabIndex = 131;
            this.groupFood.TabStop = false;
            this.groupFood.Text = "Thức Ăn";
            // 
            // checkMiCay
            // 
            this.checkMiCay.AutoSize = true;
            this.checkMiCay.Location = new System.Drawing.Point(147, 63);
            this.checkMiCay.Name = "checkMiCay";
            this.checkMiCay.Size = new System.Drawing.Size(60, 17);
            this.checkMiCay.TabIndex = 4;
            this.checkMiCay.Text = "Mỳ cay";
            this.checkMiCay.UseVisualStyleBackColor = true;
            // 
            // myMiXaoBo
            // 
            this.myMiXaoBo.AutoSize = true;
            this.myMiXaoBo.Location = new System.Drawing.Point(147, 29);
            this.myMiXaoBo.Name = "myMiXaoBo";
            this.myMiXaoBo.Size = new System.Drawing.Size(72, 17);
            this.myMiXaoBo.TabIndex = 3;
            this.myMiXaoBo.Text = "Mì xào bò";
            this.myMiXaoBo.UseVisualStyleBackColor = true;
            // 
            // checkMyTomTrung
            // 
            this.checkMyTomTrung.AutoSize = true;
            this.checkMyTomTrung.Location = new System.Drawing.Point(15, 97);
            this.checkMyTomTrung.Name = "checkMyTomTrung";
            this.checkMyTomTrung.Size = new System.Drawing.Size(87, 17);
            this.checkMyTomTrung.TabIndex = 2;
            this.checkMyTomTrung.Text = "Mỳ tôm trứng";
            this.checkMyTomTrung.UseVisualStyleBackColor = true;
            // 
            // checkBanhMyCa
            // 
            this.checkBanhMyCa.AutoSize = true;
            this.checkBanhMyCa.Location = new System.Drawing.Point(15, 63);
            this.checkBanhMyCa.Name = "checkBanhMyCa";
            this.checkBanhMyCa.Size = new System.Drawing.Size(82, 17);
            this.checkBanhMyCa.TabIndex = 1;
            this.checkBanhMyCa.Text = "Bánh mỳ cá";
            this.checkBanhMyCa.UseVisualStyleBackColor = true;
            // 
            // checkBanhMyTrung
            // 
            this.checkBanhMyTrung.AutoSize = true;
            this.checkBanhMyTrung.Location = new System.Drawing.Point(15, 28);
            this.checkBanhMyTrung.Name = "checkBanhMyTrung";
            this.checkBanhMyTrung.Size = new System.Drawing.Size(94, 17);
            this.checkBanhMyTrung.TabIndex = 0;
            this.checkBanhMyTrung.Text = "Bánh mỳ trứng";
            this.checkBanhMyTrung.UseVisualStyleBackColor = true;
            // 
            // groupDrink
            // 
            this.groupDrink.Controls.Add(this.radioCafeKem);
            this.groupDrink.Controls.Add(this.radioCafeDa);
            this.groupDrink.Controls.Add(this.radioCafeSuaDa);
            this.groupDrink.Controls.Add(this.radioCafeSua);
            this.groupDrink.Controls.Add(this.radioCafeDen);
            this.groupDrink.Location = new System.Drawing.Point(39, 154);
            this.groupDrink.Name = "groupDrink";
            this.groupDrink.Size = new System.Drawing.Size(247, 151);
            this.groupDrink.TabIndex = 130;
            this.groupDrink.TabStop = false;
            this.groupDrink.Text = "Nước Uống";
            // 
            // radioCafeKem
            // 
            this.radioCafeKem.AutoSize = true;
            this.radioCafeKem.Location = new System.Drawing.Point(145, 63);
            this.radioCafeKem.Name = "radioCafeKem";
            this.radioCafeKem.Size = new System.Drawing.Size(70, 17);
            this.radioCafeKem.TabIndex = 4;
            this.radioCafeKem.TabStop = true;
            this.radioCafeKem.Text = "Cafe kem";
            this.radioCafeKem.UseVisualStyleBackColor = true;
            // 
            // radioCafeDa
            // 
            this.radioCafeDa.AutoSize = true;
            this.radioCafeDa.Location = new System.Drawing.Point(145, 28);
            this.radioCafeDa.Name = "radioCafeDa";
            this.radioCafeDa.Size = new System.Drawing.Size(63, 17);
            this.radioCafeDa.TabIndex = 3;
            this.radioCafeDa.TabStop = true;
            this.radioCafeDa.Text = "Cafe đá";
            this.radioCafeDa.UseVisualStyleBackColor = true;
            // 
            // radioCafeSuaDa
            // 
            this.radioCafeSuaDa.AutoSize = true;
            this.radioCafeSuaDa.Location = new System.Drawing.Point(6, 97);
            this.radioCafeSuaDa.Name = "radioCafeSuaDa";
            this.radioCafeSuaDa.Size = new System.Drawing.Size(83, 17);
            this.radioCafeSuaDa.TabIndex = 2;
            this.radioCafeSuaDa.TabStop = true;
            this.radioCafeSuaDa.Text = "Cafe sữa đá";
            this.radioCafeSuaDa.UseVisualStyleBackColor = true;
            // 
            // radioCafeSua
            // 
            this.radioCafeSua.AutoSize = true;
            this.radioCafeSua.Location = new System.Drawing.Point(8, 63);
            this.radioCafeSua.Name = "radioCafeSua";
            this.radioCafeSua.Size = new System.Drawing.Size(67, 17);
            this.radioCafeSua.TabIndex = 1;
            this.radioCafeSua.TabStop = true;
            this.radioCafeSua.Text = "Cafe sữa";
            this.radioCafeSua.UseVisualStyleBackColor = true;
            // 
            // radioCafeDen
            // 
            this.radioCafeDen.AutoSize = true;
            this.radioCafeDen.Location = new System.Drawing.Point(6, 28);
            this.radioCafeDen.Name = "radioCafeDen";
            this.radioCafeDen.Size = new System.Drawing.Size(69, 17);
            this.radioCafeDen.TabIndex = 0;
            this.radioCafeDen.TabStop = true;
            this.radioCafeDen.Text = "Cafe đen";
            this.radioCafeDen.UseVisualStyleBackColor = true;
            // 
            // checkSV
            // 
            this.checkSV.AutoSize = true;
            this.checkSV.Location = new System.Drawing.Point(279, 131);
            this.checkSV.Name = "checkSV";
            this.checkSV.Size = new System.Drawing.Size(71, 17);
            this.checkSV.TabIndex = 129;
            this.checkSV.Text = "Sinh Viên";
            this.checkSV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "Số Khách Hàng:";
            // 
            // txtIDKH
            // 
            this.txtIDKH.Location = new System.Drawing.Point(279, 99);
            this.txtIDKH.Multiline = true;
            this.txtIDKH.Name = "txtIDKH";
            this.txtIDKH.Size = new System.Drawing.Size(276, 26);
            this.txtIDKH.TabIndex = 127;
            this.txtIDKH.Validating += new System.ComponentModel.CancelEventHandler(this.textID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(218, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 126;
            this.label1.Text = "CAFE SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 125;
            this.label2.Text = "Tên Khách Hàng :";
            // 
            // txtNameKH
            // 
            this.txtNameKH.Location = new System.Drawing.Point(279, 58);
            this.txtNameKH.Multiline = true;
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(276, 26);
            this.txtNameKH.TabIndex = 124;
            this.txtNameKH.Validating += new System.ComponentModel.CancelEventHandler(this.textKH_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CafeSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongKH);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupFood);
            this.Controls.Add(this.groupDrink);
            this.Controls.Add(this.checkSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameKH);
            this.Name = "CafeSV";
            this.Text = "Cafe Sinh Viên";
            this.Load += new System.EventHandler(this.CafeSV_Load);
            this.groupFood.ResumeLayout(false);
            this.groupFood.PerformLayout();
            this.groupDrink.ResumeLayout(false);
            this.groupDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox groupFood;
        private System.Windows.Forms.CheckBox checkMiCay;
        private System.Windows.Forms.CheckBox myMiXaoBo;
        private System.Windows.Forms.CheckBox checkMyTomTrung;
        private System.Windows.Forms.CheckBox checkBanhMyCa;
        private System.Windows.Forms.CheckBox checkBanhMyTrung;
        private System.Windows.Forms.GroupBox groupDrink;
        private System.Windows.Forms.RadioButton radioCafeKem;
        private System.Windows.Forms.RadioButton radioCafeDa;
        private System.Windows.Forms.RadioButton radioCafeSuaDa;
        private System.Windows.Forms.RadioButton radioCafeSua;
        private System.Windows.Forms.RadioButton radioCafeDen;
        private System.Windows.Forms.CheckBox checkSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

