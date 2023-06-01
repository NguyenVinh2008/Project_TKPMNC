using Phan_mem_quan_ly_voucher.DTO;
using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_tkpmnc.BUS
{
    internal class nguoidung_BUS
    {
        nguoidung_DAO nguoidung_DAO = new nguoidung_DAO();
        application_BUS application_BUS = new application_BUS();
        public DataTable timnguoidung()
        {
            return nguoidung_DAO.timnguoidung();
        }
        public DataTable timnguoidungtheoten(string ten)
        {
            return nguoidung_DAO.timnguoidungtheoten(ten);
        }
        public DataTable timnguoidungtheoemail(string email)
        {
            return nguoidung_DAO.timnguoidungtheoemail(email);
        }
        public DataTable timnguoidunggandungtheoemail(string email)
        {
            return nguoidung_DAO.timnguoidunggandungtheoemail(email);
        }
        public DataTable timnguoidungtheosodienthoai(string sodienthoai)
        {
            return nguoidung_DAO.timnguoidungtheosodienthoai(sodienthoai);
        }
        public DataTable timnguoidungtheoid()
        {
            return nguoidung_DAO.timnguoidungtheoid(nguoidung_DTO.id);
        }
        public int thaydoithongtinnguoidung()
        {
            return nguoidung_DAO.thaydoithongtinnguoidung(nguoidung_DTO.id, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai, nguoidung_DTO.trangthai);
        }
        public int thaydoithongtinnguoidungemail()
        {
            var datatable = timnguoidungtheoemail(nguoidung_DTO.email);
            if (datatable.Rows.Count == 1)
            {
                if (application_BUS.CheckExistEmail(nguoidung_DTO.email) == 0)
                {
                    nguoidung_DAO.thaydoithongtinnguoidungemail(nguoidung_DTO.id, nguoidung_DTO.email, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai);
                    return 1;
                }
                else
                {
                    if (int.Parse(datatable.Rows[0]["nguoidung_id"].ToString()) == nguoidung_DTO.id)
                    {
                        nguoidung_DAO.thaydoithongtinnguoidungemail(nguoidung_DTO.id, nguoidung_DTO.email, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai);
                        return 1;
                    }
                    else
                        return 0;
                }
            }
            else
            {
                if (application_BUS.CheckExistEmail(nguoidung_DTO.email) == 0)
                {
                    nguoidung_DAO.thaydoithongtinnguoidungemail(nguoidung_DTO.id, nguoidung_DTO.email, nguoidung_DTO.ten, nguoidung_DTO.sodienthoai);
                    return 1;
                }
                else
                    return 0;
            }
        } 
    }
}
