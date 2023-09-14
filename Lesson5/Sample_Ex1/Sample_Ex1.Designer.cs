
namespace Sample_Ex1
{
    partial class Sample_Ex1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnTatCaQuaPhai = new System.Windows.Forms.Button();
            this.BtnQuaTrai = new System.Windows.Forms.Button();
            this.BtnTatCaQuaTrai = new System.Windows.Forms.Button();
            this.BtnChuyenTuyChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(22, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(269, 381);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.AutoSize = true;
            this.btnQuaPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaPhai.Location = new System.Drawing.Point(297, 83);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(37, 30);
            this.btnQuaPhai.TabIndex = 3;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 381);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnTatCaQuaPhai
            // 
            this.BtnTatCaQuaPhai.AutoSize = true;
            this.BtnTatCaQuaPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTatCaQuaPhai.Location = new System.Drawing.Point(297, 145);
            this.BtnTatCaQuaPhai.Name = "BtnTatCaQuaPhai";
            this.BtnTatCaQuaPhai.Size = new System.Drawing.Size(37, 30);
            this.BtnTatCaQuaPhai.TabIndex = 5;
            this.BtnTatCaQuaPhai.Text = ">>";
            this.BtnTatCaQuaPhai.UseVisualStyleBackColor = true;
            this.BtnTatCaQuaPhai.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnQuaTrai
            // 
            this.BtnQuaTrai.AutoSize = true;
            this.BtnQuaTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuaTrai.Location = new System.Drawing.Point(297, 209);
            this.BtnQuaTrai.Name = "BtnQuaTrai";
            this.BtnQuaTrai.Size = new System.Drawing.Size(37, 30);
            this.BtnQuaTrai.TabIndex = 6;
            this.BtnQuaTrai.Text = "<";
            this.BtnQuaTrai.UseVisualStyleBackColor = true;
            this.BtnQuaTrai.Click += new System.EventHandler(this.BtnQuaTrai_Click);
            // 
            // BtnTatCaQuaTrai
            // 
            this.BtnTatCaQuaTrai.AutoSize = true;
            this.BtnTatCaQuaTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTatCaQuaTrai.Location = new System.Drawing.Point(297, 278);
            this.BtnTatCaQuaTrai.Name = "BtnTatCaQuaTrai";
            this.BtnTatCaQuaTrai.Size = new System.Drawing.Size(37, 30);
            this.BtnTatCaQuaTrai.TabIndex = 7;
            this.BtnTatCaQuaTrai.Text = "<<";
            this.BtnTatCaQuaTrai.UseVisualStyleBackColor = true;
            this.BtnTatCaQuaTrai.Click += new System.EventHandler(this.BtnTatCaQuaTrai_Click);
            // 
            // BtnChuyenTuyChon
            // 
            this.BtnChuyenTuyChon.AutoSize = true;
            this.BtnChuyenTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChuyenTuyChon.Location = new System.Drawing.Point(262, 407);
            this.BtnChuyenTuyChon.Name = "BtnChuyenTuyChon";
            this.BtnChuyenTuyChon.Size = new System.Drawing.Size(117, 30);
            this.BtnChuyenTuyChon.TabIndex = 8;
            this.BtnChuyenTuyChon.Text = "Chuyển Tùy Ý";
            this.BtnChuyenTuyChon.UseVisualStyleBackColor = true;
            this.BtnChuyenTuyChon.Click += new System.EventHandler(this.BtnChuyenTuyChon_Click);
            // 
            // Sample_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 449);
            this.Controls.Add(this.BtnChuyenTuyChon);
            this.Controls.Add(this.BtnTatCaQuaTrai);
            this.Controls.Add(this.BtnQuaTrai);
            this.Controls.Add(this.BtnTatCaQuaPhai);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnQuaPhai);
            this.Name = "Sample_Ex1";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.Sample_Ex1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnTatCaQuaPhai;
        private System.Windows.Forms.Button BtnQuaTrai;
        private System.Windows.Forms.Button BtnTatCaQuaTrai;
        private System.Windows.Forms.Button BtnChuyenTuyChon;
    }
}

