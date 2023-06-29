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
    public partial class bai02 : Form
    {
        public bai02()
        {
            InitializeComponent();
        }

        private void bai02_Load(object sender, EventArgs e)
        {
            string[] lop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };

            foreach (string s in lop)
            {
                tree_dsLop.Nodes.Add(s);
                cbo_chonLop.Items.Add(s);
            }

            grb_thongTinLop.Visible = false;

            cbo_chonLop.SelectedIndex = 0;
        }

        private void chk_themLop_CheckedChanged(object sender, EventArgs e)
        {
            grb_thongTinLop.Visible = true;

            if (chk_themLop.Checked == false)
            {
                grb_thongTinLop.Visible = false;
            }
        }

        private void btn_themLop_Click(object sender, EventArgs e)
        {
            int dem = 0;

            foreach (TreeNode node in tree_dsLop.Nodes)
            {
                if (txt_tenLop.Text.ToLower().Contains(node.Text.Trim().ToLower()))
                {
                    dem = dem + 1;
                }
            }

            if (dem>0)
            {
                MessageBox.Show("Lop da nhap.");
            }

            if (dem==0)
            {
                tree_dsLop.Nodes.Add(txt_tenLop.Text);
                cbo_chonLop.Items.Add(txt_tenLop.Text);
            }

        }

        private void btn_capNhap_Click(object sender, EventArgs e)
        {
            int dem = 0;

            int index = -1;

            foreach (TreeNode node in tree_dsLop.Nodes)
	        {
		        if (node.Text == cbo_chonLop.Text)
                {
                    index = node.Index;
                    break;
                }


	        }

            tree_dsLop.Nodes[index].Nodes.Add(txt_maSV.Text + "," + txt_hoTen.Text + "," + txt_diaChi.Text);

            tree_dsLop.ExpandAll();


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)
            {
                if (tree_dsLop.SelectedNode != null)
                {
                    cbo_chonLop.Items.Remove(tree_dsLop.SelectedNode.Text);
                    tree_dsLop.Nodes.Remove(tree_dsLop.SelectedNode);
                }
            }
        }

        private void txt_maSV_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length  == 0)
            {
                this.errorProvider1.SetError(ctr, "Khong dc de trong.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_hoTen_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Khong dc de trong.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_diaChi_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Khong dc de trong.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_hoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;

                this.errorProvider1.SetError(ctr, "chi dc nhap chu.");
            }
        }

        private void txt_maSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;

                this.errorProvider1.SetError(ctr, "chi dc nhap so.");
            }
        }
    }
}
