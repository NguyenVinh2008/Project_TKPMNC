using Phan_mem_quan_ly_voucher.DTO;
using System.Data;

namespace project_tkpmnc.DAO
{
    internal class thongke_DAO
    {
        db db = new db();
        public DataTable tongsotaikhoan()
        {
            string sql = "EXEC SELECT_TONG_SO_TAI_KHOAN";
            return db.laydulieu(sql);
        }
        public DataTable tongsonguoidung()
        {
            string sql = "EXEC SELECT_TONG_SO_NGUOI_DUNG";
            return db.laydulieu(sql);
        }
        public DataTable tongsodoitac()
        {
            string sql = "EXEC SELECT_TONG_SO_DOI_TAC";
            return db.laydulieu(sql);
        }
        public DataTable tongsoquantrivien()
        {
            string sql = "EXEC SELECT_TONG_SO_QUAN_TRI_VIEN";
            return db.laydulieu(sql);
        }
        public DataTable tongsochiendich()
        {
            string sql = "EXEC SELECT_TONGSO_CHIENDICH";
            return db.laydulieu(sql);
        }
        public DataTable tongsochiendichchuaduyet()
        {
            string sql = "EXEC SELECT_TONGSO_CHIENDICH_THEO_TRANGTHAI 0";
            return db.laydulieu(sql);
        }
        public DataTable tongsochiendichdaduyet()
        {
            string sql = "EXEC SELECT_TONGSO_CHIENDICH_THEO_TRANGTHAI 1";
            return db.laydulieu(sql);
        }
        public DataTable tongsochiendichdadung()
        {
            string sql = "EXEC SELECT_TONGSO_CHIENDICH_THEO_TRANGTHAI 2";
            return db.laydulieu(sql);
        }
        public DataTable tongsovoucher()
        {
            string sql = "EXEC SELECT_TONGSO_VOUCHER";
            return db.laydulieu(sql);
        }
        public DataTable tongsovoucherchuaphat()
        {
            string sql = "EXEC SELECT_TONGSO_VOUCHER_THEO_TRANGTHAI 0";
            return db.laydulieu(sql);
        }
        public DataTable tongsovoucherdaphat()
        {
            string sql = "EXEC SELECT_TONGSO_VOUCHER_THEO_TRANGTHAI 1";
            return db.laydulieu(sql);
        }
        public DataTable tongsovoucherdasudung()
        {
            string sql = "EXEC SELECT_TONGSO_VOUCHER_THEO_TRANGTHAI 2";
            return db.laydulieu(sql);
        }
        public DataTable sochiendichtheothang(int thang)
        {
            string sql = "EXEC SELECT_CHIENDICH_START_THEOTHANG'" + thang + "'";
            return db.laydulieu(sql);
        }
        public DataTable sotaikhoanmoitrongthang(int thang)
        {
            string sql = "EXEC SELECT_TONG_SO_TAI_KHOAN_MOI_TRONG_THANG'" + thang + "'";
            return db.laydulieu(sql);
        }
        public DataTable sovouchernmoitrongthang(int thang)
        {
            string sql = "EXEC SELECT_TONG_SO_VOUCHER_MOI_TRONG_THANG'" + thang + "'";
            return db.laydulieu(sql);
        }
        public DataTable sovouchercuadoitac(int id)
        {
            string sql = "EXEC select_voucher_theo_doitac_id'" + id + "'";
            return db.laydulieu(sql);
        }
        public DataTable sovouchercuadoitactheotrangthai(int doitac_id, int trangthai_id)
        {
            string sql = "EXEC SELECT_VOUCHER_TRANGTHAI_THEO_DOITAC_ID '" + doitac_id + "','" + trangthai_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable sovouchercuadoitactheothangvanam(int doitac_id, int thang, int nam)
        {
            string sql = "EXEC SELECT_VOUCHER_CUADOITAC_THEOTHANGVANAM'" + doitac_id + "','" + thang + "','" + nam + "'";
            return db.laydulieu(sql);
        }
        public DataTable sochiendichcuadoitactheotrangthai(int doitac_id, int trangthai_id)
        {
            string sql = "EXEC select_chiendich_trangthai_cuadoitac'" + doitac_id + "','" + trangthai_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable sochiendichcuadoitactheothangvanam(int doitac_id, int thang, int nam)
        {
            string sql = "EXEC SELECT_CHIENDICH_START_CUADOITAC_THEOTHANGVANAM'" + doitac_id + "','" + thang + "','" + nam + "'";
            return db.laydulieu(sql);
        }
    }
}
