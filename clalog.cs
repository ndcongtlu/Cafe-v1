using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cafe
{
    class clalog
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=NDCONG\SQLEXPRESS;Initial Catalog=id_cafe;Integrated Security=True");
        private void opendata()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }
        private void closedata()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
        public Boolean exedata(string cmd)
        {
            opendata();
            Boolean check = false;
            try
            {
                SqlCommand sq = new SqlCommand(cmd, sqlcon);
                sq.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closedata();
            return check;
        }
        public DataTable readdata(string cmd)
        {
            opendata();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sq = new SqlCommand(cmd, sqlcon);
                SqlDataAdapter sqd = new SqlDataAdapter(sq);
                sqd.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closedata();
            return da;
        }
    }
}
