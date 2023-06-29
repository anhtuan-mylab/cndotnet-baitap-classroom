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

namespace QLSinhVien
{
    public partial class btm_qlsinhvien_02 : Form
    {
        DataColumn[] key = new DataColumn[1];
        Control_SinhVien sv = new Control_SinhVien();
        string table = "SinhVien";

        SqlConnection connnsql = new SqlConnection(@"Data Source=A110PC32;Initial Catalog=QL_SinhVien;Integrated Security=True");


        public btm_qlsinhvien_02()
        {
            InitializeComponent();

        }

        public void load_dtg()
        {

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Rows.Clear();
            }

            DataTable dtSV = sv.select(table);

            dataGridView1.DataSource = dtSV;

            key[0] = dtSV.Columns[0];
            dtSV.PrimaryKey = key;
        }

        public void load_lop()
        {
            string table = "Lop";

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Rows.Clear();
            }

            DataTable dt = sv.select(table);
            cbo_lop.DataSource = dt;
            cbo_lop.DisplayMember = "TenLop";
            cbo_lop.ValueMember = "MaLop";
        }

        public void load_all()
        {
            load_dtg();
        }

        private void btm_qlsinhvien_02_Load(object sender, EventArgs e)
        {
            load_lop();
            load_all();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Model_SinhVien newsv = new Model_SinhVien();

                newsv.MaSV = txt_maSinhVien.Text;
                newsv.TenSV = txt_hoTen.Text;
                newsv.NgaySinh = txt_ngaySinh.Text;
                newsv.MaLop = cbo_lop.SelectedValue.ToString().Trim();

                if (sv.checkTrungMa(newsv.MaSV, table) == 1)
                {
                    MessageBox.Show("Bi trung ma.");
                    return;
                }

                sv.insert(newsv, table);
                MessageBox.Show("Them thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi.");
            }

            
            
            
            
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Model_SinhVien newsv = new Model_SinhVien();

                newsv.MaSV = txt_maSinhVien.Text;
                newsv.TenSV = txt_hoTen.Text;
                newsv.NgaySinh = txt_ngaySinh.Text;
                newsv.MaLop = cbo_lop.SelectedValue.ToString().Trim();

                sv.delete(newsv.MaSV, table);
                MessageBox.Show("Xoa thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi.");
            }

        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Model_SinhVien newsv = new Model_SinhVien();

                newsv.MaSV = txt_maSinhVien.Text;
                newsv.TenSV = txt_hoTen.Text;
                newsv.NgaySinh = txt_ngaySinh.Text;
                newsv.MaLop = cbo_lop.SelectedValue.ToString().Trim();

                sv.modifie(newsv, table, newsv.MaSV);


                MessageBox.Show("Sua thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txt_maSinhVien.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_hoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_ngaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbo_lop.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }


    }
}
