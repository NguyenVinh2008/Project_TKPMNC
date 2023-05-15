using Phan_mem_quan_ly_voucher.DTO;
using project_tkpmnc.DTO;
using System.Data;

namespace project_tkpmnc.DAO
{
    internal class login_DAO
    {
        public db db = new db();

        public DataTable checklogin(string email, string password)
        {
            string sql = string.Format("EXEC SELECT_EMAIL_PASSWORD '" + email + "', '" + password + "'");
            return db.laydulieu(sql);
        }

        public DataTable checkexist(string email)
        {
            string sql = string.Format("EXEC SELECT_EMAIL '" + email + "'");
            return db.laydulieu(sql);
        }

        public DataTable checkadmin(string email)
        {
            string sql = string.Format("EXEC KIEM_TRA_QUAN_TRI_VIEN '" + email + "'");
            return db.laydulieu(sql);
        }

        public DataTable checkstatusbyemail(string email, int trangthai) 
        {
            string sql = string.Format("EXEC KIEM_TRA_TRANG_THAI_BANG_EMAIL '" + email + "', '" + trangthai + "'");
            return db.laydulieu(sql);
        }
    }
}
