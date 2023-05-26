using Phan_mem_quan_ly_voucher.DTO;
using project_tkpmnc.DTO;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using project_tkpmnc.GUI;
using DevExpress.XtraPrinting;
using System.Drawing;
using DevExpress.Xpo.DB.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phan_mem_quan_ly_voucher.DAO
{
    class DOITAC_DAO
    {   
        public db db = new db();

        public int themdoitac(string ten, string email, string sodienthoai, string password)
        {
            string sql = "EXEC TAO_DOI_TAC '" + ten + "','" + email + "','" + sodienthoai + "','" + password + "'";
            return db.thucthi(sql);
        }
        public DataTable timdoitactheotrangthai (int trangthai)
        {
            string sql = "EXEC SELECT_DOI_TAC_THEO_TRANG_THAI '" + trangthai + "'";
            return db.laydulieu(sql);
        }
        public int duyetdoitac(int doitac_id, int admin_id)
        {
            string sql = "EXEC DUYET_DOI_TAC '" + doitac_id + "','" + admin_id + "'";
            return db.thucthi(sql);
        }
        public DataTable timdoitac()
        {
            string sql = "EXEC SELECT_DOITAC_INFO";
            return db.laydulieu(sql);
        }
        public DataTable timdoitactheoten(string ten)
        {
            string sql = "EXEC SELECT_LIKE_DOITAC_INFO_THEO_TEN '" + ten + "'";
            return db.laydulieu(sql);
        }
        public DataTable timdoitactheosodienthoai(string sodienthoai)
        {
            string sql = "EXEC SELECT_LIKE_DOITAC_INFO_THEO_SODIENTHOAI '" + sodienthoai + "'";
            return db.laydulieu(sql);
        }
        public DataTable timdoitacgandungtheoemail(string email)
        {
            string sql = "EXEC SELECT_LIKE_DOITAC_INFO_THEO_EMAIL '"+ email +"'";
            return db.laydulieu(sql);
        }
        public DataTable timdoitactheoid(int id)
        {
            string sql = "EXEC SELECT_DOITAC_INFO_THEO_ID '" + id + "'";
            return db.laydulieu(sql);
        }
        public int thaydoithongtindoitac(int doitac_id, string email , string ten, string sodienthoai)
        {
            string sql = "EXEC UPDATE_DOITAC_INFO '" + doitac_id + "','" + email + "','" + ten + "', '" + sodienthoai + "'";
            return db.thucthi(sql);
        }
        public DataTable timdoitactheoemail(string email)
        {
            string sql = "EXEC SELECT_DOITAC_INFO_THEO_EMAIL '" + email + "'";
            return db.laydulieu(sql);
        }
    }
}
