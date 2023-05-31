using Phan_mem_quan_ly_voucher.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_tkpmnc.DAO
{
    internal class ochu_DAO
    {
        db db = new db();
        public DataTable layochuidtieptheo()
        {
            string sql = "EXEC SELECT_OCHUID_TIEPTHEO";
            return db.laydulieu(sql);
        }
        public int taoochu(int trochoi_id, int chiendich_id, string cauhoi1, string cauhoi2, string cauhoi3,
            string dapan1, string dapan2, string dapan3, string phanthuong0, string phanthuong1, string phanthuong2, string phanthuong3)
        {
            string sql = "EXEC TAOOCHU '" + trochoi_id + "','" + chiendich_id + "',N'" + cauhoi1 + "',N'" + cauhoi2 + "', N'" + cauhoi3 + "', N'" + dapan1 + "', N'" + dapan2 + "',N'" + dapan3 + "', N'" + phanthuong0 + "', N'" + phanthuong1 + "', N'" + phanthuong2 + "', N'" + phanthuong3 + "'";
            return db.thucthi(sql);
        }
        public DataTable laythongtinochu(int chiendich_id)
        {
            string sql = "EXEC SELECT_OCHU '"+chiendich_id + "'";
            return db.laydulieu(sql);
        }
        public DataTable layphanthuongochu(int chiendich_id, string voucher_giatri)
        {
            string sql = "EXEC layphanthuongochu '" + chiendich_id + "',N'" + voucher_giatri + "'";
            return db.laydulieu(sql);
        }
    }
}
