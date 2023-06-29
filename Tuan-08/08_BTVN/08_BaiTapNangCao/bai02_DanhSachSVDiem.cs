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
    public partial class bai02_DanhSachSVDiem : Form
    {
        SqlConnection connsql;

        public bai02_DanhSachSVDiem()
        {
            InitializeComponent();

            connsql = new SqlConnection(@"Data Source=ANHTUAN-PC\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True");

        }

        private void bai02_DanhSachSVDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void load_du_lieu_monHoc()
        {
            connsql.Open();

            string select_string = "select * from MonHoc";

            SqlCommand cmd = new SqlCommand(select_string, connsql);

            SqlDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                cbo_monHoc.Items.Add(rd["MaMonHoc"].ToString());
            }

            cbo_monHoc.Items.Add("Chon tat ca.");


            rd.Close();
            connsql.Close();
        }

        private void bai02_DanhSachSVDiem_Load(object sender, EventArgs e)
        {
            load_du_lieu_monHoc();
        }

        private void btn_locDL_Click(object sender, EventArgs e)
        {

            connsql.Open();


            string select_string_chon = "select * from SinhVien full join Diem on SinhVien.MaSinhVien = Diem.MaSinhVien full join MonHoc on MonHoc.MaMonHoc = Diem.MaMonHoc where MonHoc.MaMonHoc= '" + cbo_monHoc.SelectedItem + "'";

            //string select_string_chon = "select * from SinhVien full join Diem on SinhVien.MaSinhVien = Diem.MaSinhVien full join MonHoc on MonHoc.MaMonHoc = Diem.MaMonHoc";

            SqlCommand cmd_1 = new SqlCommand(select_string_chon, connsql);

            SqlDataReader rd_1 = cmd_1.ExecuteReader();

            int last = cbo_monHoc.Items.Count - 1;

            if (cbo_monHoc.SelectedIndex == last || cbo_monHoc.SelectedIndex == -1)
            {
                list_danhSach.Items.Clear();


                rd_1.Close();
                connsql.Close();

                chon_het();
            }
            else
            {
                list_danhSach.Items.Clear();

                while (rd_1.Read())
                {
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

                    for (int i = -1; i < list_danhSach.Items.Count; i++)
                    {
                        item.Text = (i + 2).ToString();
                    }


                    item.SubItems.Add(rd_1["HoTen"].ToString());
                    item.SubItems.Add(rd_1["NgaySinh"].ToString());
                    item.SubItems.Add(rd_1["TenMonHoc"].ToString());
                    item.SubItems.Add(rd_1["Diem"].ToString());

                    list_danhSach.Items.Add(item);
                }
            }

            

            rd_1.Close();
            connsql.Close();



        }

        public void chon_het()
        {
            connsql.Open();

            
            string select_string_het = "select * from SinhVien full join Diem on SinhVien.MaSinhVien = Diem.MaSinhVien full join MonHoc on MonHoc.MaMonHoc = Diem.MaMonHoc";
            SqlCommand cmd = new SqlCommand(select_string_het, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem item = new ListViewItem();
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

                for (int i = -1; i < list_danhSach.Items.Count; i++)
                {
                    item.Text = (i + 2).ToString();
                }


                item.SubItems.Add(rd["HoTen"].ToString());
                item.SubItems.Add(rd["NgaySinh"].ToString());
                item.SubItems.Add(rd["TenMonHoc"].ToString());
                item.SubItems.Add(rd["Diem"].ToString());

                list_danhSach.Items.Add(item);

            }


            rd.Close();
            connsql.Close();
        }


    }
}
