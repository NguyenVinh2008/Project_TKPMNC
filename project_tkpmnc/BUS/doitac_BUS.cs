using Phan_mem_quan_ly_voucher.DAO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.BUS
{
    internal class doitac_BUS
    {
        DOITAC_DAO DOITAC_DAO = new DOITAC_DAO();
        public DataTable timdoitac()
        {
            return DOITAC_DAO.timdoitac();
        }
        public DataTable timdoitactheoten(string ten)
        {
            return DOITAC_DAO.timdoitactheoten(ten);
        }
        public DataTable timdoitacgandungtheoemail(string email)
        {
            return DOITAC_DAO.timdoitacgandungtheoemail(email);
        }
        public DataTable timdoitactheosodienthoai(string sodienthoai)
        {
            return DOITAC_DAO.timdoitactheosodienthoai(sodienthoai);
        }
        public DataTable timdoitactheotrangthai(int trangthai)
        {
            return DOITAC_DAO.timdoitactheotrangthai(trangthai);
        }
        public DataTable timdoitactheoid()
        {
            return DOITAC_DAO.timdoitactheoid(doitac_DTO.id);
        }
        public int thaydoithongtindoitac()
        {
            return DOITAC_DAO.thaydoithongtindoitac(doitac_DTO.id, doitac_DTO.email, doitac_DTO.ten, doitac_DTO.sodienthoai);
        }
        public int duyetdoitac()
        {
            return DOITAC_DAO.duyetdoitac(doitac_DTO.id, admin_DTO.id);
        }
    }
}
