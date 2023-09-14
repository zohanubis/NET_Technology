
namespace Sample_Ex2
{
    partial class Form_DanToc
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.labelDanToc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(58, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(347, 30);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Dữ Liệu ComboBox";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboBoxList
            // 
            this.comboBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(136, 78);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(269, 28);
            this.comboBoxList.TabIndex = 3;
            this.comboBoxList.SelectedIndexChanged += new System.EventHandler(this.comboBoxList_SelectedIndexChanged);
            // 
            // BtnShow
            // 
            this.BtnShow.AutoSize = true;
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(136, 122);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(179, 30);
            this.BtnShow.TabIndex = 4;
            this.BtnShow.Text = "Hiển Thị";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // labelDanToc
            // 
            this.labelDanToc.AutoSize = true;
            this.labelDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanToc.Location = new System.Drawing.Point(9, 81);
            this.labelDanToc.Name = "labelDanToc";
            this.labelDanToc.Size = new System.Drawing.Size(93, 25);
            this.labelDanToc.TabIndex = 5;
            this.labelDanToc.Text = "Dân Tộc";
            // 
            // Form_DanToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 164);
            this.Controls.Add(this.labelDanToc);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.comboBoxList);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form_DanToc";
            this.Text = "Dân tộc";
            this.Load += new System.EventHandler(this.Form_DanToc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Label labelDanToc;
    }
}

