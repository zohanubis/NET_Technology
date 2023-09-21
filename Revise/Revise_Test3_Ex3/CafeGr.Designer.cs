
namespace Revise_Test3_Ex3
{
    partial class CafeGr
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCafeDen = new System.Windows.Forms.RadioButton();
            this.radioCafeDa = new System.Windows.Forms.RadioButton();
            this.radioCafeSua = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSanVuon = new System.Windows.Forms.CheckBox();
            this.checkPhongVip = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.txtSLSua = new System.Windows.Forms.TextBox();
            this.txtSLDa = new System.Windows.Forms.TextBox();
            this.txtSLDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSLDen);
            this.groupBox2.Controls.Add(this.txtSLDa);
            this.groupBox2.Controls.Add(this.txtSLSua);
            this.groupBox2.Controls.Add(this.radioCafeDen);
            this.groupBox2.Controls.Add(this.radioCafeDa);
            this.groupBox2.Controls.Add(this.radioCafeSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(368, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 194);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Thức Uống";
            // 
            // radioCafeDen
            // 
            this.radioCafeDen.AutoSize = true;
            this.radioCafeDen.Location = new System.Drawing.Point(6, 117);
            this.radioCafeDen.Name = "radioCafeDen";
            this.radioCafeDen.Size = new System.Drawing.Size(81, 20);
            this.radioCafeDen.TabIndex = 6;
            this.radioCafeDen.TabStop = true;
            this.radioCafeDen.Text = "Cafe Đen";
            this.radioCafeDen.UseVisualStyleBackColor = true;
            this.radioCafeDen.CheckedChanged += new System.EventHandler(this.radioCafeDen_CheckedChanged);
            // 
            // radioCafeDa
            // 
            this.radioCafeDa.AutoSize = true;
            this.radioCafeDa.Location = new System.Drawing.Point(6, 79);
            this.radioCafeDa.Name = "radioCafeDa";
            this.radioCafeDa.Size = new System.Drawing.Size(74, 20);
            this.radioCafeDa.TabIndex = 5;
            this.radioCafeDa.TabStop = true;
            this.radioCafeDa.Text = "Cafe Đá";
            this.radioCafeDa.UseVisualStyleBackColor = true;
            this.radioCafeDa.CheckedChanged += new System.EventHandler(this.radioCafeDa_CheckedChanged);
            // 
            // radioCafeSua
            // 
            this.radioCafeSua.AutoSize = true;
            this.radioCafeSua.Location = new System.Drawing.Point(6, 35);
            this.radioCafeSua.Name = "radioCafeSua";
            this.radioCafeSua.Size = new System.Drawing.Size(81, 20);
            this.radioCafeSua.TabIndex = 4;
            this.radioCafeSua.TabStop = true;
            this.radioCafeSua.Text = "Cafe Sữa";
            this.radioCafeSua.UseVisualStyleBackColor = true;
            this.radioCafeSua.CheckedChanged += new System.EventHandler(this.radioCafeSua_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSanVuon);
            this.groupBox1.Controls.Add(this.checkPhongVip);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 194);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Phòng";
            // 
            // checkSanVuon
            // 
            this.checkSanVuon.AutoSize = true;
            this.checkSanVuon.Location = new System.Drawing.Point(19, 79);
            this.checkSanVuon.Name = "checkSanVuon";
            this.checkSanVuon.Size = new System.Drawing.Size(85, 20);
            this.checkSanVuon.TabIndex = 1;
            this.checkSanVuon.Text = "Sân Vườn";
            this.checkSanVuon.UseVisualStyleBackColor = true;
            // 
            // checkPhongVip
            // 
            this.checkPhongVip.AutoSize = true;
            this.checkPhongVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPhongVip.Location = new System.Drawing.Point(19, 36);
            this.checkPhongVip.Name = "checkPhongVip";
            this.checkPhongVip.Size = new System.Drawing.Size(90, 20);
            this.checkPhongVip.TabIndex = 0;
            this.checkPhongVip.Text = "Phòng VIP";
            this.checkPhongVip.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(537, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(440, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 32);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Nhập Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(139, 294);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(286, 26);
            this.txtTongTien.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "CAFE GREEN";
            // 
            // btnTongTien
            // 
            this.btnTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongTien.Location = new System.Drawing.Point(30, 288);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(91, 32);
            this.btnTongTien.TabIndex = 50;
            this.btnTongTien.Text = "Tổng Tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // txtSLSua
            // 
            this.txtSLSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLSua.Location = new System.Drawing.Point(121, 30);
            this.txtSLSua.Name = "txtSLSua";
            this.txtSLSua.Size = new System.Drawing.Size(78, 26);
            this.txtSLSua.TabIndex = 51;
            this.txtSLSua.TextChanged += new System.EventHandler(this.txtSLSua_TextChanged);
            // 
            // txtSLDa
            // 
            this.txtSLDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLDa.Location = new System.Drawing.Point(121, 75);
            this.txtSLDa.Name = "txtSLDa";
            this.txtSLDa.Size = new System.Drawing.Size(78, 26);
            this.txtSLDa.TabIndex = 52;
            this.txtSLDa.TextChanged += new System.EventHandler(this.txtSLDa_TextChanged);
            // 
            // txtSLDen
            // 
            this.txtSLDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLDen.Location = new System.Drawing.Point(121, 113);
            this.txtSLDen.Name = "txtSLDen";
            this.txtSLDen.Size = new System.Drawing.Size(78, 26);
            this.txtSLDen.TabIndex = 53;
            this.txtSLDen.TextChanged += new System.EventHandler(this.txtSLDen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Số lượng";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CafeGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 342);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Name = "CafeGr";
            this.Text = "Cafe Green";
            this.Load += new System.EventHandler(this.CafeGr_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioCafeDa;
        private System.Windows.Forms.RadioButton radioCafeSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkSanVuon;
        private System.Windows.Forms.CheckBox checkPhongVip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCafeDen;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSLDen;
        private System.Windows.Forms.TextBox txtSLDa;
        private System.Windows.Forms.TextBox txtSLSua;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

