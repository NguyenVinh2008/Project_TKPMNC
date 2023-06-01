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
            string sql = "EXEC TAO_NGUOI_DUNG N'" + ten + "','" + email + "','" + sodienthoai + "','" + password + "'";
            return db.thucthi(sql);
        }
        public DataTable timnguoidung()
        {
            string sql = "EXEC SELECT_NGUOI_DUNG_INFO";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheoten(string ten)
        {
            string sql = "EXEC SELECT_LIKE_NGUOI_DUNG_INFO_THEO_TEN N'" + ten + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheosodienthoai(string sodienthoai)
        {
            string sql = "EXEC SELECT_LIKE_NGUOI_DUNG_INFO_THEO_SODIENTHOAI '" + sodienthoai + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidunggandungtheoemail(string email)
        {
            string sql = "EXEC SELECT_LIKE_NGUOI_DUNG_INFO_THEO_EMAIL '" + email + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheoemail(string email)
        {
            string sql = "EXEC SELECT_NGUOI_DUNG_INFO_THEO_EMAIL '" + email + "'";
            return db.laydulieu(sql);
        }
        public DataTable timnguoidungtheoid(int id)
        {
            string sql = "EXEC SELECT_NGUOI_DUNG_INFO_THEO_ID '" + id + "'";
            return db.laydulieu(sql);
        }
        public int thaydoithongtinnguoidung(int nguoidung_id, string ten, string sodienthoai, int trangthai)
        {
            string sql = "EXEC UPDATE_NGUOI_DUNG_INFO " + nguoidung_id + ",N'" + ten + "', '" + sodienthoai + "', '"+ trangthai+ "'";
            return db.thucthi(sql);
        }
        public int thaydoithongtinnguoidungemail(int nguoidung_id, string email, string ten, string sodienthoai)
        {
            string sql = "EXEC UPDATE_NGUOI_DUNG_INFO_EMAIL " + nguoidung_id + ",'" + email + "', N'" + ten + "', '" + sodienthoai + "'";
            return db.thucthi(sql);
        } 
    }
}
