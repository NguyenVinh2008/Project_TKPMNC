using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System.Data;

namespace project_tkpmnc.BUS
{
    internal class chiendich_BUS
    {
        chiendich_DAO chiendich_DAO = new chiendich_DAO();
        public DataTable laythongtinchiendich()
        {
            return chiendich_DAO.laythongtinchiendich();
        }
        public DataTable timkiemtheotrangthai()
        {
            DataTable dt = new DataTable();
            switch (chiendich_DTO.trangthai)
            {
                case 0:
                    chiendich_DTO.trangthai = 0;
                    break;
                case 1:
                    chiendich_DTO.trangthai = 1;
                    break;
                case 2:
                    chiendich_DTO.trangthai = 2;
                    break;
            }
            dt = chiendich_DAO.laychiendichtheotrangthai(chiendich_DTO.trangthai);
            return dt;
        }
        public DataTable timkiemtheoiddoitac()
        {
            return chiendich_DAO.laychiendichtheodoitacid(doitac_DTO.id);
        }
        public DataTable timkiemtheotengandung(string ten)
        {
            return chiendich_DAO.laychiendichtheotengandung(ten);
        }
        public DataTable laychiendichtheoid()
        {
            return chiendich_DAO.laychiendichtheoid(chiendich_DTO.chiendich_id);
        }
        public int thaydoitrangthaichiendich()
        {
            return chiendich_DAO.thaydoitrangthaichiendich(admin_DTO.id, chiendich_DTO.chiendich_id, chiendich_DTO.trangthai);
        }
        public DataTable laychiendichtheodoitacid()
        {
            return chiendich_DAO.laychiendichtheodoitacid(doitac_DTO.id);
        }
        public DataTable laychiendichcuadoitactheotrangthai()
        {
            return chiendich_DAO.laychiendichcuadoitactheotrangthai(doitac_DTO.id, chiendich_DTO.trangthai);
        }
        public DataTable laychiendichcuadoitacdangdienra()
        {
            return chiendich_DAO.laychiendichcuadoitacdangdienra(doitac_DTO.id);
        }
        public DataTable laychiendichcuadoitacdaketthuc()
        {
            return chiendich_DAO.laychiendichcuadoitacdaketthuc(doitac_DTO.id);
        }
        public int thaydoithongtinchiendich()
        {
            return chiendich_DAO.thaydoithongtinchiendich(chiendich_DTO.chiendich_id, chiendich_DTO.chiendich_ten);
        }
        public DataTable laychiendichdangdienratheotrangthai()
        {
            return chiendich_DAO.laychiendichdangdienratheotrangthai(nguoidung_DTO.id, chiendich_DTO.trangthai);
        }
        public DataTable laychiendichidlonnhat()
        {
            return chiendich_DAO.laychiendichidlonnhat();
        }
        public int taochiendich()
        {
            return chiendich_DAO.taochiendich(chiendich_DTO.chiendich_ten, doitac_DTO.id, trochoi_DTO.id, chiendich_DTO.chiendich_start, chiendich_DTO.chiendich_end);
        }
    }
}
