
namespace Revise_Test1_Ex3
{
    partial class Exercise3
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkNui = new System.Windows.Forms.CheckBox();
            this.checkBanhCanh = new System.Windows.Forms.CheckBox();
            this.checkHuTieu = new System.Windows.Forms.CheckBox();
            this.checkBunBo = new System.Windows.Forms.CheckBox();
            this.radioKhachQuen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioKhachLa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(403, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(271, 360);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(91, 32);
            this.btnThanhToan.TabIndex = 39;
            this.btnThanhToan.Text = "Tính Tiền";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(333, 317);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(286, 26);
            this.txtTotal.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tổng số tiền khác phải thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chương trình tính tiền quán ăn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkNui);
            this.groupBox1.Controls.Add(this.checkBanhCanh);
            this.groupBox1.Controls.Add(this.checkHuTieu);
            this.groupBox1.Controls.Add(this.checkBunBo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 194);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Món Ăn";
            // 
            // checkNui
            // 
            this.checkNui.AutoSize = true;
            this.checkNui.Location = new System.Drawing.Point(19, 155);
            this.checkNui.Name = "checkNui";
            this.checkNui.Size = new System.Drawing.Size(130, 20);
            this.checkNui.TabIndex = 3;
            this.checkNui.Text = "Nui (28.000/phần)";
            this.checkNui.UseVisualStyleBackColor = true;
            // 
            // checkBanhCanh
            // 
            this.checkBanhCanh.AutoSize = true;
            this.checkBanhCanh.Location = new System.Drawing.Point(19, 117);
            this.checkBanhCanh.Name = "checkBanhCanh";
            this.checkBanhCanh.Size = new System.Drawing.Size(173, 20);
            this.checkBanhCanh.TabIndex = 2;
            this.checkBanhCanh.Text = "Bánh canh (35.000/phần)";
            this.checkBanhCanh.UseVisualStyleBackColor = true;
            // 
            // checkHuTieu
            // 
            this.checkHuTieu.AutoSize = true;
            this.checkHuTieu.Location = new System.Drawing.Point(19, 79);
            this.checkHuTieu.Name = "checkHuTieu";
            this.checkHuTieu.Size = new System.Drawing.Size(151, 20);
            this.checkHuTieu.TabIndex = 1;
            this.checkHuTieu.Text = "Hủ tiếu (30.000/phần)";
            this.checkHuTieu.UseVisualStyleBackColor = true;
            // 
            // checkBunBo
            // 
            this.checkBunBo.AutoSize = true;
            this.checkBunBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBunBo.Location = new System.Drawing.Point(19, 36);
            this.checkBunBo.Name = "checkBunBo";
            this.checkBunBo.Size = new System.Drawing.Size(152, 20);
            this.checkBunBo.TabIndex = 0;
            this.checkBunBo.Text = "Bún bò (45.000/phần)";
            this.checkBunBo.UseVisualStyleBackColor = true;
            // 
            // radioKhachQuen
            // 
            this.radioKhachQuen.AutoSize = true;
            this.radioKhachQuen.Location = new System.Drawing.Point(42, 36);
            this.radioKhachQuen.Name = "radioKhachQuen";
            this.radioKhachQuen.Size = new System.Drawing.Size(188, 20);
            this.radioKhachQuen.TabIndex = 4;
            this.radioKhachQuen.TabStop = true;
            this.radioKhachQuen.Text = "Khách quen (giảm giá 10%)\r\n";
            this.radioKhachQuen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioKhachLa);
            this.groupBox2.Controls.Add(this.radioKhachQuen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(347, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 194);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách Hàng";
            // 
            // radioKhachLa
            // 
            this.radioKhachLa.AutoSize = true;
            this.radioKhachLa.Location = new System.Drawing.Point(42, 87);
            this.radioKhachLa.Name = "radioKhachLa";
            this.radioKhachLa.Size = new System.Drawing.Size(180, 20);
            this.radioKhachLa.TabIndex = 5;
            this.radioKhachLa.TabStop = true;
            this.radioKhachLa.Text = "Khách lạ (không giảm giá)";
            this.radioKhachLa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkNui;
        private System.Windows.Forms.CheckBox checkBanhCanh;
        private System.Windows.Forms.CheckBox checkHuTieu;
        private System.Windows.Forms.CheckBox checkBunBo;
        private System.Windows.Forms.RadioButton radioKhachQuen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioKhachLa;
    }
}

