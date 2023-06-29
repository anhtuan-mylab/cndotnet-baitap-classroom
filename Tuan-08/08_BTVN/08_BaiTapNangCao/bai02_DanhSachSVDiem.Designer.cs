namespace _08_BaiTapNangCao
{
    partial class bai02_DanhSachSVDiem
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
            this.cbo_monHoc = new System.Windows.Forms.ComboBox();
            this.btn_locDL = new System.Windows.Forms.Button();
            this.list_danhSach = new System.Windows.Forms.ListView();
            this.col_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tenMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongDiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mon Hoc";
            // 
            // cbo_monHoc
            // 
            this.cbo_monHoc.FormattingEnabled = true;
            this.cbo_monHoc.Location = new System.Drawing.Point(79, 10);
            this.cbo_monHoc.Name = "cbo_monHoc";
            this.cbo_monHoc.Size = new System.Drawing.Size(236, 21);
            this.cbo_monHoc.TabIndex = 1;
            // 
            // btn_locDL
            // 
            this.btn_locDL.Location = new System.Drawing.Point(337, 8);
            this.btn_locDL.Name = "btn_locDL";
            this.btn_locDL.Size = new System.Drawing.Size(75, 23);
            this.btn_locDL.TabIndex = 2;
            this.btn_locDL.Text = "Loc Du Lieu";
            this.btn_locDL.UseVisualStyleBackColor = true;
            this.btn_locDL.Click += new System.EventHandler(this.btn_locDL_Click);
            // 
            // list_danhSach
            // 
            this.list_danhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_STT,
            this.col_TenSV,
            this.col_ngaySinh,
            this.col_tenMonHoc,
            this.col_diem});
            this.list_danhSach.GridLines = true;
            this.list_danhSach.Location = new System.Drawing.Point(16, 47);
            this.list_danhSach.Name = "list_danhSach";
            this.list_danhSach.Size = new System.Drawing.Size(523, 202);
            this.list_danhSach.TabIndex = 3;
            this.list_danhSach.UseCompatibleStateImageBehavior = false;
            this.list_danhSach.View = System.Windows.Forms.View.Details;
            // 
            // col_STT
            // 
            this.col_STT.Text = "STT";
            // 
            // col_TenSV
            // 
            this.col_TenSV.Text = "Ten Sinh Vien";
            this.col_TenSV.Width = 149;
            // 
            // col_ngaySinh
            // 
            this.col_ngaySinh.Text = "Ngay Sinh";
            this.col_ngaySinh.Width = 132;
            // 
            // col_tenMonHoc
            // 
            this.col_tenMonHoc.Text = "Ten Mon Hoc";
            this.col_tenMonHoc.Width = 109;
            // 
            // col_diem
            // 
            this.col_diem.Text = "Diem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tong Diem";
            // 
            // txt_tongDiem
            // 
            this.txt_tongDiem.Location = new System.Drawing.Point(439, 267);
            this.txt_tongDiem.Name = "txt_tongDiem";
            this.txt_tongDiem.Size = new System.Drawing.Size(100, 20);
            this.txt_tongDiem.TabIndex = 5;
            // 
            // bai02_DanhSachSVDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 315);
            this.Controls.Add(this.txt_tongDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_danhSach);
            this.Controls.Add(this.btn_locDL);
            this.Controls.Add(this.cbo_monHoc);
            this.Controls.Add(this.label1);
            this.Name = "bai02_DanhSachSVDiem";
            this.Text = "bai02_DanhSachSVDiem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bai02_DanhSachSVDiem_FormClosing);
            this.Load += new System.EventHandler(this.bai02_DanhSachSVDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_monHoc;
        private System.Windows.Forms.Button btn_locDL;
        private System.Windows.Forms.ListView list_danhSach;
        private System.Windows.Forms.ColumnHeader col_STT;
        private System.Windows.Forms.ColumnHeader col_TenSV;
        private System.Windows.Forms.ColumnHeader col_ngaySinh;
        private System.Windows.Forms.ColumnHeader col_tenMonHoc;
        private System.Windows.Forms.ColumnHeader col_diem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongDiem;
    }
}