namespace _04_01_BTVN_2033200113_PhungTanSang
{
    partial class KhachSanThanhThanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_phongBa = new System.Windows.Forms.RadioButton();
            this.rdo_phongDoi = new System.Windows.Forms.RadioButton();
            this.rdo_phongDon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_mayNuocNong = new System.Windows.Forms.CheckBox();
            this.chk_Internet = new System.Windows.Forms.CheckBox();
            this.chk_tiVi = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_anSang = new System.Windows.Forms.CheckBox();
            this.chk_karaoke = new System.Windows.Forms.CheckBox();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.btn_nhapMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thanhTien = new System.Windows.Forms.TextBox();
            this.btn_tongKet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_tongSoTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_soLuotNguoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHACH SAN THANH THANH - TRA PHONG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho va Ten";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(91, 38);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(209, 20);
            this.txt_hoTen.TabIndex = 2;
            this.txt_hoTen.TextChanged += new System.EventHandler(this.txt_hoTen_TextChanged);
            this.txt_hoTen.Leave += new System.EventHandler(this.txt_hoTen_Leave);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(91, 74);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(314, 20);
            this.txt_diaChi.TabIndex = 4;
            this.txt_diaChi.TextChanged += new System.EventHandler(this.txt_diaChi_TextChanged);
            this.txt_diaChi.Leave += new System.EventHandler(this.txt_diaChi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dia Chi";
            // 
            // txt_soNgay
            // 
            this.txt_soNgay.Location = new System.Drawing.Point(91, 113);
            this.txt_soNgay.Name = "txt_soNgay";
            this.txt_soNgay.Size = new System.Drawing.Size(209, 20);
            this.txt_soNgay.TabIndex = 6;
            this.txt_soNgay.TextChanged += new System.EventHandler(this.txt_soNgay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "So ngay o";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_phongBa);
            this.groupBox1.Controls.Add(this.rdo_phongDoi);
            this.groupBox1.Controls.Add(this.rdo_phongDon);
            this.groupBox1.Location = new System.Drawing.Point(30, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loai phong";
            // 
            // rdo_phongBa
            // 
            this.rdo_phongBa.AutoSize = true;
            this.rdo_phongBa.Location = new System.Drawing.Point(17, 75);
            this.rdo_phongBa.Name = "rdo_phongBa";
            this.rdo_phongBa.Size = new System.Drawing.Size(71, 17);
            this.rdo_phongBa.TabIndex = 2;
            this.rdo_phongBa.TabStop = true;
            this.rdo_phongBa.Text = "Phong ba";
            this.rdo_phongBa.UseVisualStyleBackColor = true;
            // 
            // rdo_phongDoi
            // 
            this.rdo_phongDoi.AutoSize = true;
            this.rdo_phongDoi.Location = new System.Drawing.Point(17, 52);
            this.rdo_phongDoi.Name = "rdo_phongDoi";
            this.rdo_phongDoi.Size = new System.Drawing.Size(73, 17);
            this.rdo_phongDoi.TabIndex = 1;
            this.rdo_phongDoi.TabStop = true;
            this.rdo_phongDoi.Text = "Phong doi";
            this.rdo_phongDoi.UseVisualStyleBackColor = true;
            // 
            // rdo_phongDon
            // 
            this.rdo_phongDon.AutoSize = true;
            this.rdo_phongDon.Location = new System.Drawing.Point(17, 29);
            this.rdo_phongDon.Name = "rdo_phongDon";
            this.rdo_phongDon.Size = new System.Drawing.Size(77, 17);
            this.rdo_phongDon.TabIndex = 0;
            this.rdo_phongDon.TabStop = true;
            this.rdo_phongDon.Text = "Phong don";
            this.rdo_phongDon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_mayNuocNong);
            this.groupBox2.Controls.Add(this.chk_Internet);
            this.groupBox2.Controls.Add(this.chk_tiVi);
            this.groupBox2.Location = new System.Drawing.Point(178, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 121);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tien nghi";
            // 
            // chk_mayNuocNong
            // 
            this.chk_mayNuocNong.AutoSize = true;
            this.chk_mayNuocNong.Location = new System.Drawing.Point(17, 76);
            this.chk_mayNuocNong.Name = "chk_mayNuocNong";
            this.chk_mayNuocNong.Size = new System.Drawing.Size(100, 17);
            this.chk_mayNuocNong.TabIndex = 2;
            this.chk_mayNuocNong.Text = "May nuoc nong";
            this.chk_mayNuocNong.UseVisualStyleBackColor = true;
            // 
            // chk_Internet
            // 
            this.chk_Internet.AutoSize = true;
            this.chk_Internet.Location = new System.Drawing.Point(17, 52);
            this.chk_Internet.Name = "chk_Internet";
            this.chk_Internet.Size = new System.Drawing.Size(62, 17);
            this.chk_Internet.TabIndex = 1;
            this.chk_Internet.Text = "Internet";
            this.chk_Internet.UseVisualStyleBackColor = true;
            // 
            // chk_tiVi
            // 
            this.chk_tiVi.AutoSize = true;
            this.chk_tiVi.Location = new System.Drawing.Point(17, 29);
            this.chk_tiVi.Name = "chk_tiVi";
            this.chk_tiVi.Size = new System.Drawing.Size(43, 17);
            this.chk_tiVi.TabIndex = 0;
            this.chk_tiVi.Text = "Tivi";
            this.chk_tiVi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_anSang);
            this.groupBox3.Controls.Add(this.chk_karaoke);
            this.groupBox3.Location = new System.Drawing.Point(333, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 121);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dich vu";
            // 
            // chk_anSang
            // 
            this.chk_anSang.AutoSize = true;
            this.chk_anSang.Location = new System.Drawing.Point(17, 52);
            this.chk_anSang.Name = "chk_anSang";
            this.chk_anSang.Size = new System.Drawing.Size(65, 17);
            this.chk_anSang.TabIndex = 1;
            this.chk_anSang.Text = "An sang";
            this.chk_anSang.UseVisualStyleBackColor = true;
            // 
            // chk_karaoke
            // 
            this.chk_karaoke.AutoSize = true;
            this.chk_karaoke.Location = new System.Drawing.Point(17, 29);
            this.chk_karaoke.Name = "chk_karaoke";
            this.chk_karaoke.Size = new System.Drawing.Size(66, 17);
            this.chk_karaoke.TabIndex = 0;
            this.chk_karaoke.Text = "Karaoke";
            this.chk_karaoke.UseVisualStyleBackColor = true;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Location = new System.Drawing.Point(497, 31);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(75, 23);
            this.btn_thanhToan.TabIndex = 10;
            this.btn_thanhToan.Text = "Thanh Toan";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // btn_nhapMoi
            // 
            this.btn_nhapMoi.Location = new System.Drawing.Point(578, 31);
            this.btn_nhapMoi.Name = "btn_nhapMoi";
            this.btn_nhapMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_nhapMoi.TabIndex = 11;
            this.btn_nhapMoi.Text = "Nhap Moi";
            this.btn_nhapMoi.UseVisualStyleBackColor = true;
            this.btn_nhapMoi.Click += new System.EventHandler(this.btn_nhapMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thanh Tien";
            // 
            // txt_thanhTien
            // 
            this.txt_thanhTien.Location = new System.Drawing.Point(565, 73);
            this.txt_thanhTien.Name = "txt_thanhTien";
            this.txt_thanhTien.Size = new System.Drawing.Size(198, 20);
            this.txt_thanhTien.TabIndex = 13;
            // 
            // btn_tongKet
            // 
            this.btn_tongKet.Location = new System.Drawing.Point(497, 116);
            this.btn_tongKet.Name = "btn_tongKet";
            this.btn_tongKet.Size = new System.Drawing.Size(75, 23);
            this.btn_tongKet.TabIndex = 14;
            this.btn_tongKet.Text = "Tong Ket";
            this.btn_tongKet.UseVisualStyleBackColor = true;
            this.btn_tongKet.Click += new System.EventHandler(this.btn_tongKet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_tongSoTien);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_soLuotNguoi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(497, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 93);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thong tin tong ket";
            // 
            // txt_tongSoTien
            // 
            this.txt_tongSoTien.Location = new System.Drawing.Point(88, 52);
            this.txt_tongSoTien.Name = "txt_tongSoTien";
            this.txt_tongSoTien.Size = new System.Drawing.Size(191, 20);
            this.txt_tongSoTien.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tong so tien";
            // 
            // txt_soLuotNguoi
            // 
            this.txt_soLuotNguoi.Location = new System.Drawing.Point(88, 26);
            this.txt_soLuotNguoi.Name = "txt_soLuotNguoi";
            this.txt_soLuotNguoi.Size = new System.Drawing.Size(191, 20);
            this.txt_soLuotNguoi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "So luot nguoi";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(497, 257);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 16;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KhachSanThanhThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 292);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_tongKet);
            this.Controls.Add(this.txt_thanhTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_nhapMoi);
            this.Controls.Add(this.btn_thanhToan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_soNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhachSanThanhThanh";
            this.Text = "KhachSanThanhThanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KhachSanThanhThanh_FormClosing);
            this.Load += new System.EventHandler(this.KhachSanThanhThanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_phongBa;
        private System.Windows.Forms.RadioButton rdo_phongDoi;
        private System.Windows.Forms.RadioButton rdo_phongDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_Internet;
        private System.Windows.Forms.CheckBox chk_tiVi;
        private System.Windows.Forms.CheckBox chk_mayNuocNong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_anSang;
        private System.Windows.Forms.CheckBox chk_karaoke;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Button btn_nhapMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_thanhTien;
        private System.Windows.Forms.Button btn_tongKet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_soLuotNguoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongSoTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}