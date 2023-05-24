using Phan_mem_quan_ly_voucher.DTO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_tkpmnc.DTO;
using project_tkpmnc.BUS;
using project_tkpmnc.DAO;

namespace project_tkpmnc.DAO
{
    internal class phanthuong_DAO
    {
        db db = new db();
        public int themphanthuong(int voucher_id, int chiendich_id)
        {
            string sql = "EXEC TAO_PHAN_THUONG '" + voucher_id + "','" + chiendich_id + "'";
            return db.thucthi(sql);
        }
    }
}
