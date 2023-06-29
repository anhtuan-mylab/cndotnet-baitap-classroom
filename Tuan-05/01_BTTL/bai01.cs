using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_BTTL_2033200113_PhungTanSang
{
    public partial class bai01 : Form
    {
        int dem = 0;
        int tong = 0;

        int demSNT = 0;

        int dem_2 = 0;

        public bai01()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bai01_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txt_nhapSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;

                this.errorProvider1.SetError(ctr,"Chi dc nhap so.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btn_capNhap_Click(object sender, EventArgs e)
        {
            int dem = 0;

            for (int i = 0; i < cbb_nhapSo.Items.Count; i++)
            {
                string value = cbb_nhapSo.GetItemText(cbb_nhapSo.Items[i]);

                if (txt_nhapSo.Text == value)
                {
                    dem = dem + 1;
                }
            }

            if (dem==0)
            {
                cbb_nhapSo.Items.Add(txt_nhapSo.Text);
                txt_nhapSo.Clear();
                txt_nhapSo.Focus();
            }

            if (dem>0)
            {
                MessageBox.Show("So da nhap.");
                txt_nhapSo.Clear();
                txt_nhapSo.Focus();
            }


        }

        private void cbb_nhapSo_SelectedIndexChanged(object sender, EventArgs e)
        {


            int a = int.Parse(cbb_nhapSo.SelectedItem.ToString());

            if (lst_danhSach.Items.Count>0)
            {
                lst_danhSach.Items.Clear();
            }

            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    lst_danhSach.Items.Add(i);

                    tong = tong + i;

                    dem_2 = dem_2 + 1;

                    if (i%2==0)
                    {
                        dem = dem + 1;
                    }                 
                }

                if (dem_2==2)
                {
                    demSNT = demSNT + 1;
                }
            }


        }

        private void btn_tong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tong cac uoc so la: " + tong);
        }

        private void btn_slChan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So luong uoc so chan: " + dem);
        }

        private void btn_slSNT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So luong snt: " + demSNT);
        }
    }
}
