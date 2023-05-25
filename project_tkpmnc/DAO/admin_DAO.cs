using DevExpress.Utils.DPI;
using Phan_mem_quan_ly_voucher.DTO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.DAO
{
    internal class admin_DAO
    {
        public db db = new db();

        public int themquantrivien(string ten, string email, string sodienthoai, string password)
        {
            string sql = "EXEC TAO_QUAN_TRI_VIEN '" + ten + "','" + email + "','" + sodienthoai + "','" + password + "'";
            return db.thucthi(sql);
        }

        public DataTable timquantrivienidbangemail(string email)
        {
            string sql = "EXEC SELECT_ADMIN_ID_BANG_EMAIL '" + email + "'";
            return db.laydulieu(sql);
        }
        public int thaydoithongtinquantrivien(int id, string ten, string email, string sodienthoai)
        {
            string sql = "EXEC UPDATE_ADMIN_INFO '" + id + "','" + ten + "','" + email + "','" + sodienthoai + "'";
            return db.thucthi(sql);
        }
    }
}
