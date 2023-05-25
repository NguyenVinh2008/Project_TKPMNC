using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.DAO
{
    internal class voucher_DAO
    {
        public db db = new db();
        public int taovoucher(string giatri, string magiamgia)
        {
            string sql = "EXEC TAO_VOUCHER '" + giatri + "','" + magiamgia + "'";
            return db.thucthi(sql);
        }
        public DataTable layvoucher()
        {
            string sql = "EXEC SELECT_VOUCHER";
            return db.laydulieu(sql);
        }
        public DataTable layvouchertheotrangthai(int trangthai)
        {
            string sql = "EXEC SELECT_VOUCHER_TRANGTHAI'" + trangthai + "'";
            return db.laydulieu(sql);
        }
        public DataTable layvouchertheovoucherid(int voucher_id)
        {
            string sql = "EXEC SELECT_VOUCHER_ID'" + voucher_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable layvoucheridlonnhat()
        {
            string sql = "EXEC SELECT_MAX_VOUCHER_ID";
            return db.laydulieu(sql);
        }
        public DataTable layvouchercuadoitactheotrangthai(int doitac_id, int trangthai)
        {
            string sql = "EXEC SELECT_VOUCHER_CUA_DOITAC_THEO_TRANGTHAI '" + doitac_id + "','" + trangthai + "'";
            return db.laydulieu(sql);
        }
        public DataTable layvouchertheodoitac(int doitac_id)
        {
            string sql = "EXEC SELECT_VOUCHER_THEO_DOITAC '" + doitac_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable layvouchercuadoitactheovoucherid(int doitac_id, int voucher_id)
        {
            string sql = "EXEC SELECT_VOUCHER_CUA_DOITAC_THEO_VOUCHERID '" + doitac_id + "','" + voucher_id + "'";
            return db.laydulieu(sql);
        }
        public int updatevouchertheogiatri(int voucher_id, string giatri)
        {
            string sql = "EXEC UPDATE_VOUCHER_GIATRI '" + voucher_id + "','" + giatri + "'";
            return db.thucthi(sql);
        }
    }
}
