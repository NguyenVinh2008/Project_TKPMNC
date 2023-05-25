using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.DAO
{
    internal class trochoi_DAO
    {
        db db = new db();
        public DataTable laydanhsachtrochoi()
        {
            string sql = "EXEC SELECT_TROCHOI";
            return db.laydulieu(sql);
        }
    }
}
