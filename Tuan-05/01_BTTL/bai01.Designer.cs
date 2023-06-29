namespace _01_BTTL_2033200113_PhungTanSang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nhapSo = new System.Windows.Forms.TextBox();
            this.btn_capNhap = new System.Windows.Forms.Button();
            this.cbb_nhapSo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_danhSach = new System.Windows.Forms.ListBox();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_slChan = new System.Windows.Forms.Button();
            this.btn_slSNT = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_nhapSo);
            this.groupBox1.Controls.Add(this.btn_capNhap);
            this.groupBox1.Controls.Add(this.txt_nhapSo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhap So";
            // 
            // txt_nhapSo
            // 
            this.txt_nhapSo.Location = new System.Drawing.Point(7, 20);
            this.txt_nhapSo.Name = "txt_nhapSo";
            this.txt_nhapSo.Size = new System.Drawing.Size(100, 20);
            this.txt_nhapSo.TabIndex = 0;
            this.txt_nhapSo.TextChanged += new System.EventHandler(this.txt_nhapSo_TextChanged);
            this.txt_nhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhapSo_KeyPress);
            // 
            // btn_capNhap
            // 
            this.btn_capNhap.Location = new System.Drawing.Point(114, 16);
            this.btn_capNhap.Name = "btn_capNhap";
            this.btn_capNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_capNhap.TabIndex = 1;
            this.btn_capNhap.Text = "Cap Nhap";
            this.btn_capNhap.UseVisualStyleBackColor = true;
            this.btn_capNhap.Click += new System.EventHandler(this.btn_capNhap_Click);
            // 
            // cbb_nhapSo
            // 
            this.cbb_nhapSo.FormattingEnabled = true;
            this.cbb_nhapSo.Location = new System.Drawing.Point(7, 47);
            this.cbb_nhapSo.Name = "cbb_nhapSo";
            this.cbb_nhapSo.Size = new System.Drawing.Size(182, 21);
            this.cbb_nhapSo.TabIndex = 2;
            this.cbb_nhapSo.SelectedIndexChanged += new System.EventHandler(this.cbb_nhapSo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_danhSach);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sach Cac Uoc So";
            // 
            // lst_danhSach
            // 
            this.lst_danhSach.FormattingEnabled = true;
            this.lst_danhSach.Location = new System.Drawing.Point(7, 20);
            this.lst_danhSach.Name = "lst_danhSach";
            this.lst_danhSach.Size = new System.Drawing.Size(187, 95);
            this.lst_danhSach.TabIndex = 0;
            // 
            // btn_tong
            // 
            this.btn_tong.Location = new System.Drawing.Point(229, 140);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(200, 23);
            this.btn_tong.TabIndex = 2;
            this.btn_tong.Text = "Tong cac uoc so";
            this.btn_tong.UseVisualStyleBackColor = true;
            this.btn_tong.Click += new System.EventHandler(this.btn_tong_Click);
            // 
            // btn_slChan
            // 
            this.btn_slChan.Location = new System.Drawing.Point(229, 169);
            this.btn_slChan.Name = "btn_slChan";
            this.btn_slChan.Size = new System.Drawing.Size(200, 23);
            this.btn_slChan.TabIndex = 3;
            this.btn_slChan.Text = "So luong cac uoc so chan";
            this.btn_slChan.UseVisualStyleBackColor = true;
            this.btn_slChan.Click += new System.EventHandler(this.btn_slChan_Click);
            // 
            // btn_slSNT
            // 
            this.btn_slSNT.Location = new System.Drawing.Point(229, 198);
            this.btn_slSNT.Name = "btn_slSNT";
            this.btn_slSNT.Size = new System.Drawing.Size(200, 23);
            this.btn_slSNT.TabIndex = 4;
            this.btn_slSNT.Text = "so luong cac uoc so nguyen to";
            this.btn_slSNT.UseVisualStyleBackColor = true;
            this.btn_slSNT.Click += new System.EventHandler(this.btn_slSNT_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(12, 198);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(200, 23);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 250);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_slSNT);
            this.Controls.Add(this.btn_slChan);
            this.Controls.Add(this.btn_tong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bai01";
            this.Text = "bai01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bai01_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nhapSo;
        private System.Windows.Forms.Button btn_capNhap;
        private System.Windows.Forms.ComboBox cbb_nhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_danhSach;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_slChan;
        private System.Windows.Forms.Button btn_slSNT;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}