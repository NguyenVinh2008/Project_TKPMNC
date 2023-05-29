using project_tkpmnc.DAO;
using project_tkpmnc.DTO;
using System;
using System.Data;
using System.Text;

namespace project_tkpmnc.BUS
{
    internal class voucher_BUS
    {
        voucher_DAO voucher_DAO = new voucher_DAO();
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public int kiemtratrunglapmagiamgia(string magiamgia)
        {
            DataTable dataTable = voucher_DAO.kiemtratrunglapmagiamgia(magiamgia);
            if (dataTable.Rows.Count > 0)
            {
                return 0;
            }
            return 1;
        }
        public string taomagiamgia()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            if (kiemtratrunglapmagiamgia(builder.ToString()) == 1)
                return builder.ToString();
            else
                return taomagiamgia();
        }
        public DataTable layvoucher()
        {
            return voucher_DAO.layvoucher();
        }
        public DataTable layvouchertheotrangthai()
        {
            return voucher_DAO.layvouchertheotrangthai(voucher_DTO.trangthai);
        }
        public DataTable layvouchertheovoucherid()
        {
            return voucher_DAO.layvouchertheovoucherid(voucher_DTO.id);
        }
        public int updatevouchertheogiatri()
        {
            return voucher_DAO.updatevouchertheogiatri(voucher_DTO.id, voucher_DTO.giatri);
        }
        public DataTable layphanthuongcuachiendichbangtrangthai(int trangthai)
        {
            return voucher_DAO.layphanthuongcuachiendichbangtrangthai(chiendich_DTO.chiendich_id, trangthai);
        }
        public DataTable layvoucheridbangmagiamgia()
        {
            return voucher_DAO.layvoucheridbangmagiamgia(voucher_DTO.magiamgia);
        }
        public DataTable layvouchertheodoitac()
        {
            return voucher_DAO.layvouchertheodoitac(doitac_DTO.id);
        }
        public DataTable layvouchercuadoitactheotrangthai()
        {
            return voucher_DAO.layvouchercuadoitactheotrangthai(doitac_DTO.id, voucher_DTO.trangthai);
        }
        public DataTable layvouchercuadoitactheovoucherid()
        {
            return voucher_DAO.layvouchercuadoitactheovoucherid(doitac_DTO.id, voucher_DTO.id);
        }
       
    }
}
