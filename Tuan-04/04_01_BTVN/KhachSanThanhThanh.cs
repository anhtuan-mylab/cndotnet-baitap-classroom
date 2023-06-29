using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_01_BTVN_2033200113_PhungTanSang
{
    public partial class KhachSanThanhThanh : Form
    {
        int tongSoTien = 0;
        int soLuotNguoi = 0;

        int dem = 0;

        int[] mang = new int[50];
        

        public KhachSanThanhThanh()
        {
            InitializeComponent();
        }

        private void KhachSanThanhThanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Ban co muon thoat khong ?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhachSanThanhThanh_Load(object sender, EventArgs e)
        {
            txt_hoTen.Focus();


            btn_tongKet.Enabled = false;
            btn_nhapMoi.Enabled = false;
            btn_thanhToan.Enabled = false;

            if (txt_hoTen.Text != "")
            {
                btn_thanhToan.Enabled = true;
            }

        }

        private void txt_hoTen_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Vui long nhap ho ten");

            }
            else
            {
                dem = dem + 1;
                this.errorProvider1.Clear();
            }
        }

        private void txt_soNgay_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Vui long chi nhap so.");

            }

            else
            {
                dem = dem + 1;
                this.errorProvider1.Clear();
            }

            if (txt_hoTen.Text != "" && txt_diaChi.Text != "" && txt_soNgay.Text != "")
            {
                btn_thanhToan.Enabled = true;
            }
        }

        private void txt_diaChi_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Vui long nhap dia chi");

            }
            else
            {
                dem = dem + 1;
                this.errorProvider1.Clear();
            }
        }




        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            int tong = 0;

            int phong = 0;
            int tienNghi = 0;

            int anSang = 0;
            int karaoke = 0;

            btn_nhapMoi.Enabled = true;


            int soNgay = int.Parse(txt_soNgay.Text);


            if (rdo_phongDon.Checked == true)
            {
                phong = phong + 300;
            }
            
            if (rdo_phongDoi.Checked == true)
            {
                phong = phong + 350;
            }
        
            if (rdo_phongBa.Checked == true)
            {
                phong = phong + 400;
            }

            if (chk_tiVi.Checked == true)
            {
                tienNghi = tienNghi + 10;
            }

            if (chk_Internet.Checked == true)
            {
                tienNghi = tienNghi + 10;
            }

            if (chk_mayNuocNong.Checked == true)
            {
                tienNghi = tienNghi + 10;
            }

            if (chk_karaoke.Checked == true)
            {
                karaoke = karaoke + 50;
            }

            if (chk_anSang.Checked == true)
            {
                anSang = anSang + 15;
            }

            tong = (phong + tienNghi) * soNgay + karaoke + anSang * soNgay;

            tongSoTien = tongSoTien + tong;

            txt_thanhTien.Text = tong.ToString();

            

        }

        private void btn_tongKet_Click(object sender, EventArgs e)
        {
            txt_tongSoTien.Text = tongSoTien.ToString();
            txt_soLuotNguoi.Text = soLuotNguoi.ToString();
        }

        private void btn_nhapMoi_Click(object sender, EventArgs e)
        {
            soLuotNguoi = soLuotNguoi + 1;

            int tongSoNguoi = 0;

            btn_tongKet.Enabled = true;

            tongSoNguoi = tongSoNguoi + 1;

            txt_thanhTien.Clear();
            txt_hoTen.Clear();
            txt_diaChi.Clear();
            txt_soNgay.Clear();



            


            
        }

        private void txt_hoTen_TextChanged(object sender, EventArgs e)
        {
            if (txt_hoTen.Text != "" && txt_diaChi.Text!= "" && txt_soNgay.Text != "")
            {
                btn_thanhToan.Enabled = true;
            }
        }

        private void txt_diaChi_TextChanged(object sender, EventArgs e)
        {
            if (txt_hoTen.Text != "" && txt_diaChi.Text != "" && txt_soNgay.Text != "")
            {
                btn_thanhToan.Enabled = true;
            }
        }









      
    }
}
