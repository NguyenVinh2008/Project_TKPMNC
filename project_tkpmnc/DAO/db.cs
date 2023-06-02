using System.Data;
using System.Data.SqlClient;

namespace Phan_mem_quan_ly_voucher.DTO
{
    class db
    {
        string connectionstr = @"Data Source=DESKTOP-14TA0O6\SQLEXPRESS;Initial Catalog=project_tkpmnc;Integrated Security=True";

        public DataTable laydulieu(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionstr);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int thucthi(string sql)
        {
            SqlConnection conn = new SqlConnection(connectionstr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            var kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
