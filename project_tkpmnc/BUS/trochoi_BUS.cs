using project_tkpmnc.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tkpmnc.BUS
{
    internal class trochoi_BUS
    {
        trochoi_DAO trochoi_DAO = new trochoi_DAO();
        public DataTable laydanhsachtrochoi()
        {
            return trochoi_DAO.laydanhsachtrochoi();
        }
    }
}
