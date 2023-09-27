
namespace Home_Ex1
{
    partial class Home_Ex1
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
            this.comboBoxWord = new System.Windows.Forms.ComboBox();
            this.txtVietnamese = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(456, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxWord
            // 
            this.comboBoxWord.FormattingEnabled = true;
            this.comboBoxWord.Location = new System.Drawing.Point(52, 76);
            this.comboBoxWord.Name = "comboBoxWord";
            this.comboBoxWord.Size = new System.Drawing.Size(271, 21);
            this.comboBoxWord.TabIndex = 11;
            this.comboBoxWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxWord_SelectedIndexChanged);
            this.comboBoxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxWord_KeyDown);
            // 
            // txtVietnamese
            // 
            this.txtVietnamese.Location = new System.Drawing.Point(397, 76);
            this.txtVietnamese.Multiline = true;
            this.txtVietnamese.Name = "txtVietnamese";
            this.txtVietnamese.Size = new System.Drawing.Size(335, 232);
            this.txtVietnamese.TabIndex = 12;
            this.txtVietnamese.TextChanged += new System.EventHandler(this.txtVietnamese_TextChanged);
            // 
            // Home_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVietnamese);
            this.Controls.Add(this.comboBoxWord);
            this.Controls.Add(this.btnExit);
            this.Name = "Home_Ex1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxWord;
        private System.Windows.Forms.TextBox txtVietnamese;
    }
}

