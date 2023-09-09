
namespace Class_Ex1_CalculateForm
{
    partial class Ex1_CalculateForm
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
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChia
            // 
            this.btnChia.AutoSize = true;
            this.btnChia.Location = new System.Drawing.Point(452, 123);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(82, 32);
            this.btnChia.TabIndex = 19;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.AutoSize = true;
            this.btnNhan.Location = new System.Drawing.Point(321, 123);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(82, 32);
            this.btnNhan.TabIndex = 18;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.AutoSize = true;
            this.btnTru.Location = new System.Drawing.Point(188, 123);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(82, 32);
            this.btnTru.TabIndex = 17;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.AutoSize = true;
            this.btnCong.Location = new System.Drawing.Point(70, 123);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(82, 32);
            this.btnCong.TabIndex = 16;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "B =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "A =";
            // 
            // txtNumberB
            // 
            this.txtNumberB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberB.Location = new System.Drawing.Point(367, 14);
            this.txtNumberB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(180, 29);
            this.txtNumberB.TabIndex = 12;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(103, 76);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(444, 29);
            this.txtResult.TabIndex = 11;
            // 
            // txtNumberA
            // 
            this.txtNumberA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberA.Location = new System.Drawing.Point(105, 14);
            this.txtNumberA.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(180, 29);
            this.txtNumberA.TabIndex = 10;
            // 
            // Ex1_CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 179);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumberA);
            this.Name = "Ex1_CalculateForm";
            this.Text = "Cộng Trừ Nhân Chia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtNumberA;
    }
}

