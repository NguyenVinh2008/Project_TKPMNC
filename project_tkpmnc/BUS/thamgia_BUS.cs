using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.BUS
{
    internal class thamgia_BUS
    {
        thamgia_DAO thamgia_DAO = new thamgia_DAO();
        public int taonguoidungthamgiachiendich()
        {
            return thamgia_DAO.taonguoidungthamgiachiendich(nguoidung_DTO.id, chiendich_DTO.chiendich_id);
        }

        public DataTable laydanhsachchiendichdathamgia()
        {
            return thamgia_DAO.laychiendichdangdienratheotrangthainguoidungdathamgia(nguoidung_DTO.id, chiendich_DTO.trangthai);
        }
        public DataTable laydanhsachchiendichchuathamgia()
        {
            return thamgia_DAO.laychiendichdangdienratheotrangthainguoidungchuathamgia(nguoidung_DTO.id, chiendich_DTO.trangthai);
        }
    }
}
