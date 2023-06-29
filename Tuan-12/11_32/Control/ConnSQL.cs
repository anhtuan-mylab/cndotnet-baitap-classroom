using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLSinhVien
{
    public class ConnSQL
    {
        public SqlConnection ketNoiSQL()
        {
            SqlConnection connsql = new SqlConnection(@"Data Source=A110PC32;Initial Catalog=QL_SinhVien;Integrated Security=True");
            return connsql;
        }

    }
}
