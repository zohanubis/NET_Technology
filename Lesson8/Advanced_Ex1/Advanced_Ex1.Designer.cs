
namespace Advanced_Ex1
{
    partial class Advanced_Ex1
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
            this.listViewLop = new System.Windows.Forms.ListView();
            this.ColumnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLop
            // 
            this.listViewLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnSTT,
            this.columnMaLop,
            this.columnTenLop,
            this.columnMaKhoa});
            this.listViewLop.HideSelection = false;
            this.listViewLop.Location = new System.Drawing.Point(50, 63);
            this.listViewLop.Name = "listViewLop";
            this.listViewLop.Size = new System.Drawing.Size(701, 353);
            this.listViewLop.TabIndex = 0;
            this.listViewLop.UseCompatibleStateImageBehavior = false;
            this.listViewLop.View = System.Windows.Forms.View.Details;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.Text = "STT";
            // 
            // columnMaLop
            // 
            this.columnMaLop.Text = "Mã Lớp";
            this.columnMaLop.Width = 152;
            // 
            // columnTenLop
            // 
            this.columnTenLop.Text = "Tên Lớp";
            this.columnTenLop.Width = 246;
            // 
            // columnMaKhoa
            // 
            this.columnMaKhoa.Text = "Mã Khoa";
            this.columnMaKhoa.Width = 238;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(50, 24);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 27);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Hiển Thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(649, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Advanced_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.listViewLop);
            this.Name = "Advanced_Ex1";
            this.Text = "Danh Sách Lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLop;
        private System.Windows.Forms.ColumnHeader ColumnSTT;
        private System.Windows.Forms.ColumnHeader columnMaLop;
        private System.Windows.Forms.ColumnHeader columnTenLop;
        private System.Windows.Forms.ColumnHeader columnMaKhoa;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
    }
}

