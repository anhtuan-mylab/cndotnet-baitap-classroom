namespace _01_BTTL_2033200113_PhungTanSang
{
    partial class bai02
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
            this.tree_dsLop = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_chonLop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_capNhap = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_themLop = new System.Windows.Forms.CheckBox();
            this.grb_thongTinLop = new System.Windows.Forms.GroupBox();
            this.btn_themLop = new System.Windows.Forms.Button();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grb_thongTinLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tree_dsLop
            // 
            this.tree_dsLop.Location = new System.Drawing.Point(13, 13);
            this.tree_dsLop.Name = "tree_dsLop";
            this.tree_dsLop.Size = new System.Drawing.Size(203, 282);
            this.tree_dsLop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chon lop";
            // 
            // cbo_chonLop
            // 
            this.cbo_chonLop.FormattingEnabled = true;
            this.cbo_chonLop.Location = new System.Drawing.Point(299, 13);
            this.cbo_chonLop.Name = "cbo_chonLop";
            this.cbo_chonLop.Size = new System.Drawing.Size(233, 21);
            this.cbo_chonLop.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_capNhap);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_hoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_maSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(238, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Thanh Vien";
            // 
            // btn_capNhap
            // 
            this.btn_capNhap.Location = new System.Drawing.Point(75, 108);
            this.btn_capNhap.Name = "btn_capNhap";
            this.btn_capNhap.Size = new System.Drawing.Size(132, 23);
            this.btn_capNhap.TabIndex = 11;
            this.btn_capNhap.Text = "Cap Nhap";
            this.btn_capNhap.UseVisualStyleBackColor = true;
            this.btn_capNhap.Click += new System.EventHandler(this.btn_capNhap_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(213, 108);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(75, 82);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(213, 20);
            this.txt_diaChi.TabIndex = 9;
            this.txt_diaChi.Leave += new System.EventHandler(this.txt_diaChi_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dia Chi";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(75, 56);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(213, 20);
            this.txt_hoTen.TabIndex = 7;
            this.txt_hoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoTen_KeyPress);
            this.txt_hoTen.Leave += new System.EventHandler(this.txt_hoTen_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ho Ten";
            // 
            // txt_maSV
            // 
            this.txt_maSV.Location = new System.Drawing.Point(75, 30);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(213, 20);
            this.txt_maSV.TabIndex = 5;
            this.txt_maSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maSV_KeyPress);
            this.txt_maSV.Leave += new System.EventHandler(this.txt_maSV_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ma SV";
            // 
            // chk_themLop
            // 
            this.chk_themLop.AutoSize = true;
            this.chk_themLop.Location = new System.Drawing.Point(238, 219);
            this.chk_themLop.Name = "chk_themLop";
            this.chk_themLop.Size = new System.Drawing.Size(74, 17);
            this.chk_themLop.TabIndex = 4;
            this.chk_themLop.Text = "Them Lop";
            this.chk_themLop.UseVisualStyleBackColor = true;
            this.chk_themLop.CheckedChanged += new System.EventHandler(this.chk_themLop_CheckedChanged);
            // 
            // grb_thongTinLop
            // 
            this.grb_thongTinLop.Controls.Add(this.btn_themLop);
            this.grb_thongTinLop.Controls.Add(this.txt_tenLop);
            this.grb_thongTinLop.Controls.Add(this.label5);
            this.grb_thongTinLop.Location = new System.Drawing.Point(238, 243);
            this.grb_thongTinLop.Name = "grb_thongTinLop";
            this.grb_thongTinLop.Size = new System.Drawing.Size(294, 52);
            this.grb_thongTinLop.TabIndex = 5;
            this.grb_thongTinLop.TabStop = false;
            this.grb_thongTinLop.Text = "Thong tin lop";
            // 
            // btn_themLop
            // 
            this.btn_themLop.Location = new System.Drawing.Point(213, 17);
            this.btn_themLop.Name = "btn_themLop";
            this.btn_themLop.Size = new System.Drawing.Size(75, 23);
            this.btn_themLop.TabIndex = 12;
            this.btn_themLop.Text = "Them lop";
            this.btn_themLop.UseVisualStyleBackColor = true;
            this.btn_themLop.Click += new System.EventHandler(this.btn_themLop_Click);
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(75, 19);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(132, 20);
            this.txt_tenLop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ten Lop";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 305);
            this.Controls.Add(this.grb_thongTinLop);
            this.Controls.Add(this.chk_themLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_chonLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree_dsLop);
            this.Name = "bai02";
            this.Text = "Quan Ly Sinh Vien";
            this.Load += new System.EventHandler(this.bai02_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_thongTinLop.ResumeLayout(false);
            this.grb_thongTinLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_dsLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_chonLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_capNhap;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.CheckBox chk_themLop;
        private System.Windows.Forms.GroupBox grb_thongTinLop;
        private System.Windows.Forms.Button btn_themLop;
        private System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}