using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_01_BTVN_2033200113_PhungTanSang
{
    public partial class MayTinhBoTui : Form
    {
        public MayTinhBoTui()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void MayTinhBoTui_Load(object sender, EventArgs e)
        {

        }

        private void MayTinhBoTui_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Ban co muon thoat phai khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 1;
            

            
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 2;

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 3;

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 4;

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 5;

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 6;

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 7;

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 8;

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 9;

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_ketQua.Text = txt_ketQua.Text + 0;

        }


        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_ketQua.Clear();
        }


        private void btn_plus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_ketQua.Text);
            txt_ketQua.Clear();
            txt_ketQua.Focus();
            count = 2;

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_ketQua.Text);
            txt_ketQua.Clear();
            txt_ketQua.Focus();
            count = 1;
        }

        private void btn_split_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_ketQua.Text);
            txt_ketQua.Clear();
            txt_ketQua.Focus();
            count = 4;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            compute(count);
        }


        private void btn_multi_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_ketQua.Text);
            txt_ketQua.Clear();
            txt_ketQua.Focus();
            count = 3;
        }


        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - int.Parse(txt_ketQua.Text);
                    txt_ketQua.Text = ans.ToString();
                    break;

                case 2:
                    ans = num1 + int.Parse(txt_ketQua.Text);
                    txt_ketQua.Text = ans.ToString();
                    break;
                
                case 3:
                    ans = num1 * int.Parse(txt_ketQua.Text);
                    txt_ketQua.Text = ans.ToString();
                    break;

                case 4:
                    ans = num1 / float.Parse(txt_ketQua.Text);
                    txt_ketQua.Text = ans.ToString();
                    break;
            }
        }



















        

        

        






    }
}
