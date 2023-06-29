using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLSinhVien
{
    public class Control_SinhVien
    {
        ConnSQL connect = new ConnSQL();
        DataSet ds;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder cB;


        public DataTable select(string table)
        {
            ds = new DataSet();
            string string_select = "select * from " + table;
            SqlCommand cmd = new SqlCommand(string_select, connect.ketNoiSQL());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, table);
            dt = ds.Tables[table];
            return dt;
        }

        public int checkTrungMa(string ma, string table)
        {
            DataRow drCheck = ds.Tables[table].Rows.Find(ma);
            if (drCheck != null)
            {
                return 1;
            }

            return 0;
        }

        public void insert(Model_SinhVien sv, string table)
        {
            DataRow dr = ds.Tables[table].NewRow();

            dr[0] = sv.MaSV;
            dr[1] = sv.TenSV;
            dr[2] = sv.NgaySinh;
            dr[3] = sv.MaLop;

            ds.Tables[table].Rows.Add(dr);

            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }

        public void delete(string ma, string table)
        {
            DataRow dr = ds.Tables[table].Rows.Find(ma);

            if (dr != null)
            {
                dr.Delete();
            }

            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }

        public void modifie(Model_SinhVien sv, string table, string ma)
        {
            DataRow dr = ds.Tables[table].Rows.Find(ma);

            if (dr != null)
            {
                dr[1] = sv.TenSV;
                dr[2] = sv.NgaySinh;
                dr[3] = sv.MaLop;
            }

            cB = new SqlCommandBuilder(da);
            da.Update(ds, table);
        }

    }
}
