using project_tkpmnc.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
