using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _08_BaiTapNangCao
{
    public partial class bai_01_DanhSachLop : Form
    {

        SqlConnection connsql;

        public bai_01_DanhSachLop()
        {
            InitializeComponent();

            connsql = new SqlConnection(@"Data Source=ANHTUAN-PC\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        }

        private void bai_01_DanhSachLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_hienThiDL_Click(object sender, EventArgs e)
        {
            connsql.Open();

            string select_string = "select * from Lop";

            SqlCommand cmd = new SqlCommand(select_string, connsql);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem item = new ListViewItem();
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

                for (int i = -1; i < list_lopHoc.Items.Count; i++)
                {
                    item.Text = (i + 2).ToString();
                }

                item.SubItems.Add(rd["MaLop"].ToString());
                item.SubItems.Add(rd["TenLop"].ToString());
                item.SubItems.Add(rd["MaKhoa"].ToString());

                list_lopHoc.Items.Add(item);
            }

            //for (int i = 0; i < list_lopHoc.Items.Count; i++)
            //{

            //}



                rd.Close();
            connsql.Close();


        }


    }
}
