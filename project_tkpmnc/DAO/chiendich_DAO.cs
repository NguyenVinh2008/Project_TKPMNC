using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_tkpmnc.DTO;
using Phan_mem_quan_ly_voucher.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using System.Data;

namespace project_tkpmnc.DAO
{
    internal class chiendich_DAO
    {
        public db db = new db();
        public int taochiendich(int doitac_id, int trochoi_id, DateTime start, DateTime end)
        {
            string sql = "EXEC TAO_CHIEN_DICH '" + doitac_id + "','" + trochoi_id + "','" + start + "','" + end + "'";
            return db.thucthi(sql);
        }
        public int duyetchiendich (int chiendich_id, int quantrivien_id)
        {
            string sql = "EXEC DUYET_CHIEN_DICH '" + chiendich_id + "','" + quantrivien_id +  "'";
            return db.thucthi(sql);
        }
        public int thaydoithoigian(int chiendich_id, DateTime chiendich_start, DateTime chiendich_end)
        {
            string sql = "EXEC UPDATE_CHIENDICH_INFO '" + chiendich_id + "','" + chiendich_start + "','" + chiendich_end + "'";
            return db.thucthi(sql);
        }
        public DataTable laychiendichidlonnhat()
        {
            string sql = "EXEC SELECT_MAX_CHIENDICH_ID";
            return db.laydulieu(sql);
        }

    }
}
