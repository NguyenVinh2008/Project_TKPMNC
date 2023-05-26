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
        public int taochiendich(string chiendich_ten, int doitac_id, int trochoi_id, string start, string end)
        {
            string sql = "EXEC TAO_CHIEN_DICH '" + chiendich_ten + "','" + doitac_id + "','" + trochoi_id + "','" + start + "','" + end + "'";
            return db.thucthi(sql);
        }
        public DataTable laythongtinchiendich()
        {
            string sql = "EXEC SELECT_CHIENDICH";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichtheotrangthai(int trangthai)
        {
            string sql = "EXEC SELECT_CHIENDICH_THEO_TRANGTHAI'" + trangthai + "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichtheotengandung(string tenchiendich)
        {
            string sql = "EXEC SELECT_LIKE_CHIENDICH_THEO_TEN'" + tenchiendich + "'";
            return db.laydulieu(sql);
        }
        public int duyetchiendich (int chiendich_id, int quantrivien_id)
        {
            string sql = "EXEC DUYET_CHIEN_DICH '" + chiendich_id + "','" + quantrivien_id +  "'";
            return db.thucthi(sql);
        }
        public int thaydoithongtinchiendich(int chiendich_id,string chiendich_ten)
        {
            string sql = "EXEC UPDATE_CHIENDICH_INFO '" + chiendich_id + "','" + chiendich_ten + "'";
            return db.thucthi(sql);
        }
        public DataTable laychiendichidlonnhat()
        {
            string sql = "EXEC SELECT_MAX_CHIENDICH_ID";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichtheodoitacid(int doitac_id)
        {
            string sql = "EXEC SELECT_CHIENDICH_THEO_DOITAC_ID '" + doitac_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichcuadoitactheotrangthai(int doitac_id, int trangthai)
        {
            string sql = "EXEC SELECT_CHIENDICH_CUADOITAC_THEOTRANGTHAI '" + doitac_id + "','" + trangthai + "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichcuadoitacdangdienra(int doitac_id)
        {
            string sql = "EXEC SELECT_CHIENDICH_CUADOITAC_DANGDIENRA '" + doitac_id +  "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichcuadoitacdaketthuc(int doitac_id)
        {
            string sql = "EXEC SELECT_CHIENDICH_CUADOITAC_DAKETTHUC '" + doitac_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichtheoid(int chiendich_id)
        {
            string sql = "EXEC SELECT_CHIENDICH_THEO_CHIENDICHID '" + chiendich_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable laychiendichdangdienratheotrangthai(int trangthai)
        {
            string sql = "EXEC SELECT_CHIENDICH_DANGDIENRA_THEOTRANGTHAI '" + trangthai + "'";
            return db.laydulieu(sql);
        }

    }
}
