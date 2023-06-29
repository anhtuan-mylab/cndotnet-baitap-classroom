namespace _07_32_2033200113_PhungTanSang
{
    partial class bai01
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
            this.lbl_maKhoa = new System.Windows.Forms.Label();
            this.txt_maKhoa = new System.Windows.Forms.TextBox();
            this.txt_tenKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_maKhoa
            // 
            this.lbl_maKhoa.AutoSize = true;
            this.lbl_maKhoa.Location = new System.Drawing.Point(13, 13);
            this.lbl_maKhoa.Name = "lbl_maKhoa";
            this.lbl_maKhoa.Size = new System.Drawing.Size(50, 13);
            this.lbl_maKhoa.TabIndex = 0;
            this.lbl_maKhoa.Text = "Ma Khoa";
            // 
            // txt_maKhoa
            // 
            this.txt_maKhoa.Location = new System.Drawing.Point(69, 10);
            this.txt_maKhoa.Name = "txt_maKhoa";
            this.txt_maKhoa.Size = new System.Drawing.Size(202, 20);
            this.txt_maKhoa.TabIndex = 1;
            // 
            // txt_tenKhoa
            // 
            this.txt_tenKhoa.Location = new System.Drawing.Point(69, 45);
            this.txt_tenKhoa.Name = "txt_tenKhoa";
            this.txt_tenKhoa.Size = new System.Drawing.Size(202, 20);
            this.txt_tenKhoa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ten Khoa";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(23, 85);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(104, 85);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(185, 85);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maKhoa);
            this.Controls.Add(this.lbl_maKhoa);
            this.Name = "bai01";
            this.Text = "Quan Ly Khoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_maKhoa;
        private System.Windows.Forms.TextBox txt_maKhoa;
        private System.Windows.Forms.TextBox txt_tenKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
    }
}