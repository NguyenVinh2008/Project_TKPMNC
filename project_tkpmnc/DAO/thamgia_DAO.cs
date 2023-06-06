using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable laychiendichdangdienratheotrangthainguoidungchuathamgia(int nguoidung_id, int trangthai)
        {
            string sql = "EXEC SELECT_CHIENDICH_DANGDIENRA_THEOTRANGTHAI_CHUATHAMGIA '" + nguoidung_id + "','" + trangthai + "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichdangdienratheotrangthainguoidungdathamgia(int nguoidung_id, int trangthai)
        {
            string sql = "EXEC SELECT_CHIENDICH_DANGDIENRA_THEOTRANGTHAI_DATHAMGIA '" + nguoidung_id + "','" + trangthai + "'";
            return db.laydulieu(sql);
        }
    }
}
