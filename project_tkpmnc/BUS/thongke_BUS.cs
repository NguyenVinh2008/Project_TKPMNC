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
    internal class thongke_BUS
    {
        thongke_DAO thongke_DAO = new thongke_DAO();
        public DataTable tongsotaikhoan()
        {
            return thongke_DAO.tongsotaikhoan();
        }
        public DataTable tongsonguoidung()
        {
            return thongke_DAO.tongsonguoidung();
        }
        public DataTable tongsodoitac()
        {
            return thongke_DAO.tongsodoitac();
        }
        public DataTable tongsoquantrivien()
        {
            return thongke_DAO.tongsoquantrivien();
        }
        public DataTable tongsotaikhoanmoitrongthang()
        {
            return thongke_DAO.tongsotaikhoanmoitrongthang();
        }
        public DataTable tongsochiendich()
        {
            return thongke_DAO.tongsochiendich();
        }
        public DataTable chiendichdaduyet()
        {
            return thongke_DAO.tongsochiendichdaduyet();
        }
        public DataTable chiendichchuaduyet()
        {
            return thongke_DAO.tongsochiendichchuaduyet();
        }
        public DataTable chiendichdadung()
        {
            return thongke_DAO.tongsochiendichdadung();
        }
        public DataTable tongsovoucher()
        {
            return thongke_DAO.tongsovoucher();
        }
        public DataTable voucherchuaphat()
        {
            return thongke_DAO.tongsovoucherchuaphat();
        }
        public DataTable voucherdaphat()
        {
            return thongke_DAO.tongsovoucherdaphat();
        }
        public DataTable voucherdasudung()
        {
            return thongke_DAO.tongsovoucherdasudung();
        }
        public DataTable chiendichtheothang(int thang)
        {
            return thongke_DAO.sochiendichtheothang(thang);
        }
        public DataTable thongkechiendich()
        {
            thongke_DTO.tongso_chiendich = int.Parse(tongsochiendich().Rows.Count.ToString());
            thongke_DTO.chiendich_daduyet = int.Parse(chiendichdaduyet().Rows.Count.ToString());
            thongke_DTO.chiendich_chuaduyet = int.Parse(chiendichchuaduyet().Rows.Count.ToString());
            thongke_DTO.chiendich_dadung = int.Parse(chiendichdadung().Rows.Count.ToString());
            DataTable table_chiendich = new DataTable();
            table_chiendich.Columns.Add("Chiến dịch");
            table_chiendich.Columns.Add("Số lượng", typeof(double));

            // Thêm dữ liệu vào DataTable
            table_chiendich.Rows.Add("Chưa duyệt", thongke_DTO.chiendich_chuaduyet);
            table_chiendich.Rows.Add("Đã duyệt", thongke_DTO.chiendich_daduyet);
            table_chiendich.Rows.Add("Đã dừng", thongke_DTO.chiendich_dadung);
            return table_chiendich;
            // Gắn dữ liệu vào bảng
            //dataGridView_Data.DataSource = table_chiendich;
            //bieudotron(table_chiendich, "Thống kê chiến dịch theo trạng thái", "Chiến dịch", "Số lượng");
        }
        public DataTable thongkechiendichtheothang()
        {
            DataTable data = new DataTable();

            // Tạo DataTable với 2 cột (Tháng và Số lượng)
            data.Columns.Add("Tháng", typeof(string));
            data.Columns.Add("Số lượng", typeof(int));
            // Tạo hàng dữ liệu đầu tiên (tháng)
            for (int i = 1; i < 13; i++)
            {
                DataRow row = data.NewRow();
                row["Tháng"] = "Tháng " + i;
                row["Số lượng"] = int.Parse(chiendichtheothang(i).Rows.Count.ToString());
                data.Rows.Add(row);
            }
            return data;
        }
        public DataTable thongkevoucher()
        {
            thongke_DTO.tongso_voucher = int.Parse(tongsovoucher().Rows.Count.ToString());
            thongke_DTO.voucher_chuaphat = int.Parse(voucherchuaphat().Rows.Count.ToString());
            thongke_DTO.voucher_daphat = int.Parse(voucherdaphat().Rows.Count.ToString());
            thongke_DTO.voucher_dasudung = int.Parse(voucherdasudung().Rows.Count.ToString());
            DataTable table_voucher = new DataTable();
            table_voucher.Columns.Add("Voucher");
            table_voucher.Columns.Add("Số lượng", typeof(double));
            // Thêm dữ liệu vào DataTable
            table_voucher.Rows.Add("Chưa phát", thongke_DTO.voucher_chuaphat);
            table_voucher.Rows.Add("Đã phát", thongke_DTO.voucher_daphat);
            table_voucher.Rows.Add("Đã sử dụng", thongke_DTO.voucher_dasudung);
            return table_voucher;
        }
        public DataTable thongkevouchertheothang()
        {
            DataTable data = new DataTable();

            // Tạo DataTable với 2 cột (Tháng và Số lượng)
            data.Columns.Add("Tháng", typeof(string));
            data.Columns.Add("Số lượng", typeof(int));


            // Tạo hàng dữ liệu đầu tiên (tháng)
            for (int i = 1; i < 13; i++)
            {
                DataRow row = data.NewRow();
                row["Tháng"] = "Tháng " + i;
                row["Số lượng"] = int.Parse(chiendichtheothang(i).Rows.Count.ToString());
                data.Rows.Add(row);
            }
            return data;
        }
        public DataTable thongkenguoidung()
        {
            thongke_DTO.tongso_taikhoan = int.Parse(tongsotaikhoan().Rows.Count.ToString());
            thongke_DTO.so_nguoidung = int.Parse(tongsonguoidung().Rows.Count.ToString());
            thongke_DTO.so_doitac = int.Parse(tongsodoitac().Rows.Count.ToString());
            thongke_DTO.so_quantrivien = int.Parse(tongsoquantrivien().Rows.Count.ToString());

            DataTable table_nguoidung = new DataTable();
            table_nguoidung.Columns.Add("Tài khoản");
            table_nguoidung.Columns.Add("Số lượng", typeof(double));

            // Thêm dữ liệu vào DataTable
            table_nguoidung.Rows.Add("Người dùng", thongke_DTO.so_nguoidung);
            table_nguoidung.Rows.Add("Đối tác", thongke_DTO.so_doitac);
            table_nguoidung.Rows.Add("Quản trị viên", thongke_DTO.so_quantrivien);
            return table_nguoidung;
        }
        public DataTable thongkenguoidungmoitheothang()
        {
            DataTable data = new DataTable();

            // Tạo DataTable với 2 cột (Tháng và Số lượng)
            data.Columns.Add("Tháng", typeof(string));
            data.Columns.Add("Số lượng", typeof(int));
            // Tạo hàng dữ liệu đầu tiên (tháng)
            for (int i = 1; i < 13; i++)
            {
                DataRow row = data.NewRow();
                row["Tháng"] = "Tháng " + i;
                row["Số lượng"] = int.Parse(thongke_DAO.sotaikhoanmoitrongthang(i).Rows.Count.ToString());
                data.Rows.Add(row);
            }
            return data;
        }
        public DataTable thongkevouchermoitheothang()
        {
            DataTable data = new DataTable();

            // Tạo DataTable với 2 cột (Tháng và Số lượng)
            data.Columns.Add("Tháng", typeof(string));
            data.Columns.Add("Số lượng", typeof(int));
            // Tạo hàng dữ liệu đầu tiên (tháng)
            for (int i = 1; i < 13; i++)
            {
                DataRow row = data.NewRow();
                row["Tháng"] = "Tháng " + i;
                row["Số lượng"] = int.Parse(thongke_DAO.sovouchernmoitrongthang(i).Rows.Count.ToString());
                data.Rows.Add(row);
            }
            return data;
        }
    }
}
