using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.DAO
{
    internal class nguoidung_DAO
    {
        public db db = new db();
        public int themnguoidung(string ten, string email, string sodienthoai, string password)
        {
            string sql = "EXEC TAO_NGUOI_DUNG '" + ten + "','" + email + "','" + sodienthoai + "','" + password + "'";
            return db.thucthi(sql);
        }
        public DataTable timnguoidungtheotrangthai(int trangthai)
        {
            string sql = "EXEC SELECT_NGUOI_DUNG_THEO_TRANG_THAI '" + trangthai + "'";
            return db.laydulieu(sql);
        }
        //public int duyetnguoidung(int doitac_id, int admin_id)
        //{
        //    string sql = "EXEC DUYET_NGUOI_DUNG '" + doitac_id + "','" + admin_id + "'";
        //    return db.thucthi(sql);
        //}
        public DataTable timnguoidung()
        {
            string sql = "EXEC SELECT_NGUOI_DUNG_INFO";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheoten(string ten)
        {
            string sql = "EXEC SELECT_LIKE_NGUOI_DUNG_INFO_THEO_TEN '" + ten + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheosodienthoai(string sodienthoai)
        {
            string sql = "EXEC SELECT_LIKE_NGUOI_DUNG_INFO_THEO_SODIENTHOAI '" + sodienthoai + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheoemail(string email)
        {
            string sql = "EXEC SELECT_LIKE_NGUOI_DUNG_INFO_THEO_EMAIL '" + email + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheoid(int id)
        {
            string sql = "EXEC SELECT_NGUOI_DUNG_INFO_THEO_ID '" + id + "'";
            return db.laydulieu(sql);
        }
        public int thaydoithongtinnguoidung(int doitac_id, string ten, string sodienthoai, int trangthai)
        {
            string sql = "EXEC UPDATE_NGUOI_DUNG_INFO " + doitac_id + ",'" + ten + "', '" + sodienthoai + "', '"+ trangthai+ "'";
            return db.thucthi(sql);
        }
    }
}
