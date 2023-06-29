namespace _03_04_BTTL_2033200113_PhungTanSang
{
    partial class DaySoTinhTong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_nhapSo = new System.Windows.Forms.Label();
            this.label_dayNhap = new System.Windows.Forms.Label();
            this.label_tong = new System.Windows.Forms.Label();
            this.label_tongChan = new System.Windows.Forms.Label();
            this.label_tongLe = new System.Windows.Forms.Label();
            this.txt_so = new System.Windows.Forms.TextBox();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.txt_tongChan = new System.Windows.Forms.TextBox();
            this.txt_tongLe = new System.Windows.Forms.TextBox();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.txt_daySo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap Day So va Tinh Tong";
            // 
            // label_nhapSo
            // 
            this.label_nhapSo.AutoSize = true;
            this.label_nhapSo.Location = new System.Drawing.Point(17, 61);
            this.label_nhapSo.Name = "label_nhapSo";
            this.label_nhapSo.Size = new System.Drawing.Size(53, 13);
            this.label_nhapSo.TabIndex = 1;
            this.label_nhapSo.Text = "Nhap so: ";
            // 
            // label_dayNhap
            // 
            this.label_dayNhap.AutoSize = true;
            this.label_dayNhap.Location = new System.Drawing.Point(17, 91);
            this.label_dayNhap.Name = "label_dayNhap";
            this.label_dayNhap.Size = new System.Drawing.Size(80, 13);
            this.label_dayNhap.TabIndex = 2;
            this.label_dayNhap.Text = "Day vua nhap: ";
            // 
            // label_tong
            // 
            this.label_tong.AutoSize = true;
            this.label_tong.Location = new System.Drawing.Point(17, 122);
            this.label_tong.Name = "label_tong";
            this.label_tong.Size = new System.Drawing.Size(145, 13);
            this.label_tong.TabIndex = 3;
            this.label_tong.Text = "Tong cac phan tu trong day: ";
            // 
            // label_tongChan
            // 
            this.label_tongChan.AutoSize = true;
            this.label_tongChan.Location = new System.Drawing.Point(17, 151);
            this.label_tongChan.Name = "label_tongChan";
            this.label_tongChan.Size = new System.Drawing.Size(65, 13);
            this.label_tongChan.TabIndex = 4;
            this.label_tongChan.Text = "Tong chan: ";
            // 
            // label_tongLe
            // 
            this.label_tongLe.AutoSize = true;
            this.label_tongLe.Location = new System.Drawing.Point(158, 151);
            this.label_tongLe.Name = "label_tongLe";
            this.label_tongLe.Size = new System.Drawing.Size(50, 13);
            this.label_tongLe.TabIndex = 5;
            this.label_tongLe.Text = "Tong Le:";
            // 
            // txt_so
            // 
            this.txt_so.Location = new System.Drawing.Point(77, 53);
            this.txt_so.Name = "txt_so";
            this.txt_so.Size = new System.Drawing.Size(100, 20);
            this.txt_so.TabIndex = 6;
            // 
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(169, 117);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(93, 20);
            this.txt_tong.TabIndex = 8;
            // 
            // txt_tongChan
            // 
            this.txt_tongChan.Location = new System.Drawing.Point(77, 148);
            this.txt_tongChan.Name = "txt_tongChan";
            this.txt_tongChan.Size = new System.Drawing.Size(48, 20);
            this.txt_tongChan.TabIndex = 9;
            // 
            // txt_tongLe
            // 
            this.txt_tongLe.Location = new System.Drawing.Point(214, 148);
            this.txt_tongLe.Name = "txt_tongLe";
            this.txt_tongLe.Size = new System.Drawing.Size(48, 20);
            this.txt_tongLe.TabIndex = 10;
            // 
            // btn_nhap
            // 
            this.btn_nhap.Location = new System.Drawing.Point(187, 50);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(75, 23);
            this.btn_nhap.TabIndex = 11;
            this.btn_nhap.Text = "Nhap";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // txt_daySo
            // 
            this.txt_daySo.Location = new System.Drawing.Point(103, 84);
            this.txt_daySo.Name = "txt_daySo";
            this.txt_daySo.Size = new System.Drawing.Size(100, 20);
            this.txt_daySo.TabIndex = 12;
            // 
            // DaySoTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_daySo);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.txt_tongLe);
            this.Controls.Add(this.txt_tongChan);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.txt_so);
            this.Controls.Add(this.label_tongLe);
            this.Controls.Add(this.label_tongChan);
            this.Controls.Add(this.label_tong);
            this.Controls.Add(this.label_dayNhap);
            this.Controls.Add(this.label_nhapSo);
            this.Controls.Add(this.label1);
            this.Name = "DaySoTinhTong";
            this.Text = "Day So Va Tinh Tong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nhapSo;
        private System.Windows.Forms.Label label_dayNhap;
        private System.Windows.Forms.Label label_tong;
        private System.Windows.Forms.Label label_tongChan;
        private System.Windows.Forms.Label label_tongLe;
        private System.Windows.Forms.TextBox txt_so;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.TextBox txt_tongChan;
        private System.Windows.Forms.TextBox txt_tongLe;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.TextBox txt_daySo;
    }
}