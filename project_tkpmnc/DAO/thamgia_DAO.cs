using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.DAO
{
    internal class thamgia_DAO
    {
        db db = new db();
        public int taonguoidungthamgiachiendich(int nguoidung_id, int chiendich_id)
        {
            string sql = "EXEC TAO_NGUOIDUNG_THAMGIA_CHIENDICH '" + nguoidung_id + "','" + chiendich_id + "'";
            return db.thucthi(sql);
        }
    }
}
