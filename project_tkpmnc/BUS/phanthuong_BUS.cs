using Phan_mem_quan_ly_voucher.DTO;
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
    internal class phanthuong_BUS
    {
        phanthuong_DAO phanthuong_DAO = new phanthuong_DAO();
        public DataTable layphanthuongbangvoucherid()
        {
            return phanthuong_DAO.layphanthuongbangvoucherid(voucher_DTO.id);
        }
        public int themphanthuongvaotaikhoannguoidung()
        {
            return phanthuong_DAO.themphanthuongvaotaikhoannguoidung(nguoidung_DTO.id, phanthuong_DTO.id);
        }
        public DataTable layphanthuongcuanguoidung()
        {
            return phanthuong_DAO.layphanthuongcuanguoidung(nguoidung_DTO.id);
        }

        public int themphanthuong()
        {
            return phanthuong_DAO.themphanthuong(voucher_DTO.id, chiendich_DTO.chiendich_id);
        }
        public DataTable layphanthuongcuanguoidungtheotrangthai()
        {
            return phanthuong_DAO.layphanthuongcuanguoidungtheotrangthai(nguoidung_DTO.id, voucher_DTO.trangthai);
        }
    }
}
