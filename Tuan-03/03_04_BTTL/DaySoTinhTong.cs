using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_04_BTTL_2033200113_PhungTanSang
{
    public partial class DaySoTinhTong : Form
    {
        public DaySoTinhTong()
        {
            InitializeComponent();
        }

        int tong = 0;
        int tongChan = 0;
        int tongLe = 0;

        string x = " ";
        


        private void btn_nhap_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_so.Text);
            txt_daySo.Text = txt_daySo.Text + x.ToString() + " ";


            tong = tong + x;

            txt_tong.Text = tong.ToString();

            if (x%2==0)
            {
                tongChan = tongChan + x;
                txt_tongChan.Text = tongChan.ToString();
            }
            else
            {
                tongLe = tongLe + x;
                txt_tongLe.Text = tongLe.ToString();
            }


            
        }


    }
}
