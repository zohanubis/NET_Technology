
namespace Sample_Ex1_Calculate
{
    partial class Calculate
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
            this.BtnThucHien = new System.Windows.Forms.Button();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.radioMultiplication = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.textA = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnThucHien
            // 
            this.BtnThucHien.AutoSize = true;
            this.BtnThucHien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThucHien.Location = new System.Drawing.Point(187, 148);
            this.BtnThucHien.Name = "BtnThucHien";
            this.BtnThucHien.Size = new System.Drawing.Size(114, 34);
            this.BtnThucHien.TabIndex = 56;
            this.BtnThucHien.Text = "Tính";
            this.BtnThucHien.UseVisualStyleBackColor = true;
            this.BtnThucHien.Click += new System.EventHandler(this.BtnThucHien_Click);
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDivide.Location = new System.Drawing.Point(329, 97);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(33, 28);
            this.radioDivide.TabIndex = 55;
            this.radioDivide.TabStop = true;
            this.radioDivide.Text = "/";
            this.radioDivide.UseVisualStyleBackColor = true;
            // 
            // radioMultiplication
            // 
            this.radioMultiplication.AutoSize = true;
            this.radioMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMultiplication.Location = new System.Drawing.Point(248, 97);
            this.radioMultiplication.Name = "radioMultiplication";
            this.radioMultiplication.Size = new System.Drawing.Size(35, 28);
            this.radioMultiplication.TabIndex = 54;
            this.radioMultiplication.TabStop = true;
            this.radioMultiplication.Text = "*";
            this.radioMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSubtract.Location = new System.Drawing.Point(170, 97);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(34, 28);
            this.radioSubtract.TabIndex = 53;
            this.radioSubtract.TabStop = true;
            this.radioSubtract.Text = "-";
            this.radioSubtract.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdd.Location = new System.Drawing.Point(83, 97);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(39, 28);
            this.radioAdd.TabIndex = 52;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "+";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Kết quả";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(112, 59);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(293, 20);
            this.textResult.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "b =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "a =";
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(313, 23);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(92, 20);
            this.textB.TabIndex = 47;
            this.textB.VisibleChanged += new System.EventHandler(this.textB_TextChanged);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(112, 23);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(92, 20);
            this.textA.TabIndex = 46;
            this.textA.TextChanged += new System.EventHandler(this.textA_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 196);
            this.Controls.Add(this.BtnThucHien);
            this.Controls.Add(this.radioDivide);
            this.Controls.Add(this.radioMultiplication);
            this.Controls.Add(this.radioSubtract);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Name = "Calculate";
            this.Text = "Máy tính";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnThucHien;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.RadioButton radioMultiplication;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

