namespace _08_BaiTapNangCao
{
    partial class bai_01_DanhSachLop
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
            this.btn_hienThiDL = new System.Windows.Forms.Button();
            this.list_lopHoc = new System.Windows.Forms.ListView();
            this.col_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hienThiDL
            // 
            this.btn_hienThiDL.Location = new System.Drawing.Point(13, 13);
            this.btn_hienThiDL.Name = "btn_hienThiDL";
            this.btn_hienThiDL.Size = new System.Drawing.Size(75, 23);
            this.btn_hienThiDL.TabIndex = 0;
            this.btn_hienThiDL.Text = "Hien Thi Du Lieu";
            this.btn_hienThiDL.UseVisualStyleBackColor = true;
            this.btn_hienThiDL.Click += new System.EventHandler(this.btn_hienThiDL_Click);
            // 
            // list_lopHoc
            // 
            this.list_lopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_STT,
            this.col_MaLop,
            this.col_TenLop,
            this.col_MaKhoa});
            this.list_lopHoc.GridLines = true;
            this.list_lopHoc.Location = new System.Drawing.Point(12, 42);
            this.list_lopHoc.Name = "list_lopHoc";
            this.list_lopHoc.Size = new System.Drawing.Size(581, 206);
            this.list_lopHoc.TabIndex = 1;
            this.list_lopHoc.UseCompatibleStateImageBehavior = false;
            this.list_lopHoc.View = System.Windows.Forms.View.Details;
            // 
            // col_STT
            // 
            this.col_STT.Text = "STT";
            this.col_STT.Width = 54;
            // 
            // col_MaLop
            // 
            this.col_MaLop.Text = "Ma Lop";
            this.col_MaLop.Width = 127;
            // 
            // col_TenLop
            // 
            this.col_TenLop.Text = "Ten Lop";
            this.col_TenLop.Width = 203;
            // 
            // col_MaKhoa
            // 
            this.col_MaKhoa.Text = "Ma Khoa";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(518, 254);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // bai_01_DanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 379);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.list_lopHoc);
            this.Controls.Add(this.btn_hienThiDL);
            this.Name = "bai_01_DanhSachLop";
            this.Text = "bai_01_DanhSachLop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bai_01_DanhSachLop_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hienThiDL;
        private System.Windows.Forms.ListView list_lopHoc;
        private System.Windows.Forms.ColumnHeader col_STT;
        private System.Windows.Forms.ColumnHeader col_MaLop;
        private System.Windows.Forms.ColumnHeader col_TenLop;
        private System.Windows.Forms.ColumnHeader col_MaKhoa;
        private System.Windows.Forms.Button btn_thoat;
    }
}