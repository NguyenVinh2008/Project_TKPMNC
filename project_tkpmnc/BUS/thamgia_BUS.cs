using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
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
    }
}
