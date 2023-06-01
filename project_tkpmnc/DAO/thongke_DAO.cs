using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable tongsotaikhoanmoitrongthang()
        {
            string sql = "EXEC SELECT_TONG_SO_TAI_KHOAN_MOI_TRONG_THANG";
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
    }
}
