using DevExpress.Charts.Native;
using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System.Data;

namespace project_tkpmnc.BUS
{
    internal class ochu_BUS
    {
        ochu_DAO ochu_DAO = new ochu_DAO();
        phanthuong_BUS phanthuong_BUS = new phanthuong_BUS();
        public DataTable layochuidtieptheo()
        {
            return ochu_DAO.layochuidtieptheo();
        }
        public int taoochu()
        {
            return ochu_DAO.taoochu(trochoi_DTO.id, chiendich_DTO.chiendich_id, ochu_DTO.cauhoi1, ochu_DTO.cauhoi2, ochu_DTO.cauhoi3, ochu_DTO.dapan1, ochu_DTO.dapan2, ochu_DTO.dapan3, ochu_DTO.phanthuong0, ochu_DTO.phanthuong1, ochu_DTO.phanthuong2, ochu_DTO.phanthuong3);
        }
        public DataTable layochu()
        {
            DataTable dt = ochu_DAO.laythongtinochu(chiendich_DTO.chiendich_id);
            ochu_DTO.ochu_id = int.Parse(dt.Rows[0]["ochu_id"].ToString());
            ochu_DTO.cauhoi1 = dt.Rows[0]["ochu_cauhoi1"].ToString();
            ochu_DTO.cauhoi2 = dt.Rows[0]["ochu_cauhoi2"].ToString();
            ochu_DTO.cauhoi3 = dt.Rows[0]["ochu_cauhoi3"].ToString();
            ochu_DTO.dapan1 = dt.Rows[0]["ochu_dapan1"].ToString();
            ochu_DTO.dapan2 = dt.Rows[0]["ochu_dapan2"].ToString();
            ochu_DTO.dapan3 = dt.Rows[0]["ochu_dapan3"].ToString();
            ochu_DTO.phanthuong0 = dt.Rows[0]["phanthuong0"].ToString();
            ochu_DTO.phanthuong1 = dt.Rows[0]["phanthuong1"].ToString();
            ochu_DTO.phanthuong2 = dt.Rows[0]["phanthuong2"].ToString();
            ochu_DTO.phanthuong3 = dt.Rows[0]["phanthuong3"].ToString();
            return dt;
        }
        public int kiemtradapan()
        {
            int ok = 0;
            DataTable dt = ochu_DAO.laythongtinochu(chiendich_DTO.chiendich_id);
            if (ochu_DTO.dapan1 == dt.Rows[0]["ochu_dapan1"].ToString())
                ok++;
            if (ochu_DTO.dapan2 == dt.Rows[0]["ochu_dapan2"].ToString())
                ok++;
            if (ochu_DTO.dapan3 == dt.Rows[0]["ochu_dapan3"].ToString())
                ok++;
            return ok;
        }
        public int ganphanthuongvaotaikhoan()
        {
            DataTable dt = ochu_DAO.layphanthuongochu(chiendich_DTO.chiendich_id, voucher_DTO.giatri);
            phanthuong_DTO.id = int.Parse(dt.Rows[0]["phanthuong_id"].ToString());
            return phanthuong_BUS.themphanthuongvaotaikhoannguoidung();
        }       
    }
}
