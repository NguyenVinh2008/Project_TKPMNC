using DevExpress.ClipboardSource.SpreadsheetML;
using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_tkpmnc.BUS
{
    internal class ochu_BUS
    {
        ochu_DAO ochu_DAO = new ochu_DAO();
        public DataTable layochuidtieptheo()
        {
            return ochu_DAO.layochuidtieptheo();
        }
        public int taoochu()
        {
            return ochu_DAO.taoochu(trochoi_DTO.id, chiendich_DTO.chiendich_id, ochu_DTO.cauhoi1, ochu_DTO.cauhoi2, ochu_DTO.cauhoi3, ochu_DTO.dapan1, ochu_DTO.dapan2, ochu_DTO.dapan3, ochu_DTO.phanthuong0, ochu_DTO.phanthuong1, ochu_DTO.phanthuong2, ochu_DTO.phanthuong3);
        }
    }
}
