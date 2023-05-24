using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.DAO
{
    internal class voucher_DAO
    {
        public db db = new db();
        public int taovoucher(string giatri)
        {
            string sql = "EXEC TAO_VOUCHER '" + giatri +  "'";
            return db.thucthi(sql);
        }
        public DataTable layvoucheridlonnhat()
        {
            string sql = "EXEC SELECT_MAX_VOUCHER_ID";
            return db.laydulieu(sql);
        }
    }
}
