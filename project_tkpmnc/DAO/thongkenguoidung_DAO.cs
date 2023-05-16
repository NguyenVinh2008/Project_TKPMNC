using Phan_mem_quan_ly_voucher.DTO;
using System.Data;

namespace project_tkpmnc.DAO
{
    internal class thongkenguoidung_DAO
    {
        public db db = new db();
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
        public DataTable tongsotaikhoanmoitrongthang()
        {
            string sql = "EXEC SELECT_TONG_SO_TAI_KHOAN_MOI_TRONG_THANG";
            return db.laydulieu(sql);
        }
    }
}
