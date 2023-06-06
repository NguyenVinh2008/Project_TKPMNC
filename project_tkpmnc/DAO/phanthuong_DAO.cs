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
using System.Data;

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
        public DataTable layphanthuongbangvoucherid(int voucher_id)
        {
            string sql = "EXEC SELECT_PHANTHUONG_BANG_VOUCHERID '" + voucher_id +  "'";
            return db.laydulieu(sql);
        }
        public int themphanthuongvaotaikhoannguoidung(int nguoidung_id, int phanthuong_id)
        {
            string sql = "EXEC INSERT_PHANTHUONG_VAOTAIKHOANNGUOIDUNG '" + nguoidung_id + "','" + phanthuong_id + "'";
            return db.thucthi(sql);
        }
        public DataTable layphanthuongcuanguoidung(int nguoidung_id)
        {
            string sql = "EXEC SELECT_PHANTHUONG_CUA_NGUOIDUNG '" + nguoidung_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable layphanthuongcuanguoidungtheotrangthai(int nguoidung_id, int trangthai)
        {
            string sql = "EXEC SELECT_PHANTHUONG_CUA_NGUOIDUNG_THEOTRANGTHAI '" + nguoidung_id+ "','" + trangthai + "'";
            return db.laydulieu(sql);
        }
    }
}
