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


namespace _07_32_2033200113_PhungTanSang
{
    public partial class bai05 : Form
    {
        SqlConnection connsql;

        public bai05()
        {
            InitializeComponent();
            connsql = new SqlConnection("Data Source=A110PC32;Initial Catalog=QLSinhVien;Integrated Security=True");

        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string insertString;

                insertString = "insert into Diem values('" + txt_maSV.Text + "',N'" + txt_maMH.Text + "',N'" + txt_diem.Text + "')";

                SqlCommand cmd = new SqlCommand(insertString, connsql);

                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Thanh cong.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("That bai.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string deleteString = "delete Diem where MaSinhVien='" + txt_maSV.Text + "'and MaMonHoc='" + txt_maMH.Text + "'";

                SqlCommand cmd = new SqlCommand(deleteString, connsql);

                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Da xoa thanh cong.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Da xoa that bai.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string updateString;

                updateString = "update Diem set Diem='" + txt_diem.Text + "' where MaSinhVien='" + txt_maSV.Text + "'and MaMonHoc='" + txt_maMH.Text +"'";

                SqlCommand cmd = new SqlCommand(updateString, connsql);

                cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                MessageBox.Show("Da cap nhap thanh cong.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Da cap nhap that bai.");
            }
        }
    }
}
