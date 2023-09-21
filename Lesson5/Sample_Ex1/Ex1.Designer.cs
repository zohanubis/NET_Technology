
namespace Sample_Ex1
{
    partial class Ex1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnChuyenPhai = new System.Windows.Forms.Button();
            this.btnChuyenTatCaPhai = new System.Windows.Forms.Button();
            this.btnChuyenTrai = new System.Windows.Forms.Button();
            this.btnChuyenTatCaTrai = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(327, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(228, 355);
            this.listBox2.TabIndex = 1;
            // 
            // btnChuyenPhai
            // 
            this.btnChuyenPhai.Location = new System.Drawing.Point(246, 44);
            this.btnChuyenPhai.Name = "btnChuyenPhai";
            this.btnChuyenPhai.Size = new System.Drawing.Size(75, 29);
            this.btnChuyenPhai.TabIndex = 2;
            this.btnChuyenPhai.Text = ">";
            this.btnChuyenPhai.UseVisualStyleBackColor = true;
            this.btnChuyenPhai.Click += new System.EventHandler(this.btnChuyenPhai_Click);
            // 
            // btnChuyenTatCaPhai
            // 
            this.btnChuyenTatCaPhai.Location = new System.Drawing.Point(246, 96);
            this.btnChuyenTatCaPhai.Name = "btnChuyenTatCaPhai";
            this.btnChuyenTatCaPhai.Size = new System.Drawing.Size(75, 29);
            this.btnChuyenTatCaPhai.TabIndex = 3;
            this.btnChuyenTatCaPhai.Text = ">>";
            this.btnChuyenTatCaPhai.UseVisualStyleBackColor = true;
            this.btnChuyenTatCaPhai.Click += new System.EventHandler(this.btnChuyenTatCaPhai_Click);
            // 
            // btnChuyenTrai
            // 
            this.btnChuyenTrai.Location = new System.Drawing.Point(246, 148);
            this.btnChuyenTrai.Name = "btnChuyenTrai";
            this.btnChuyenTrai.Size = new System.Drawing.Size(75, 29);
            this.btnChuyenTrai.TabIndex = 4;
            this.btnChuyenTrai.Text = "<";
            this.btnChuyenTrai.UseVisualStyleBackColor = true;
            this.btnChuyenTrai.Click += new System.EventHandler(this.btnChuyenTrai_Click);
            // 
            // btnChuyenTatCaTrai
            // 
            this.btnChuyenTatCaTrai.Location = new System.Drawing.Point(246, 203);
            this.btnChuyenTatCaTrai.Name = "btnChuyenTatCaTrai";
            this.btnChuyenTatCaTrai.Size = new System.Drawing.Size(75, 29);
            this.btnChuyenTatCaTrai.TabIndex = 5;
            this.btnChuyenTatCaTrai.Text = "<<";
            this.btnChuyenTatCaTrai.UseVisualStyleBackColor = true;
            this.btnChuyenTatCaTrai.Click += new System.EventHandler(this.btnChuyenTatCaTrai_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(246, 301);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnChuyenTatCaTrai);
            this.Controls.Add(this.btnChuyenTrai);
            this.Controls.Add(this.btnChuyenTatCaPhai);
            this.Controls.Add(this.btnChuyenPhai);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Ex1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnChuyenPhai;
        private System.Windows.Forms.Button btnChuyenTatCaPhai;
        private System.Windows.Forms.Button btnChuyenTrai;
        private System.Windows.Forms.Button btnChuyenTatCaTrai;
        private System.Windows.Forms.Button btnLoad;
    }
}

