﻿using project_tkpmnc.BUS;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace project_tkpmnc.GUI
{
    public partial class thongke_nguoidung : UserControl
    {
        public thongke_nguoidung()
        {
            InitializeComponent();
        }
        thongke_BUS thongke_BUS = new thongke_BUS();
        private double GetMaximumValue(DataTable table, string columnName)
        {
            double maxValue = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row[columnName] is int || row[columnName] is double || row[columnName] is decimal)
                {
                    double value = Convert.ToDouble(row[columnName]);
                    if (value > maxValue)
                        maxValue = value;
                }
            }
            return maxValue;
        }
        private void bieudotron(DataTable table, string name, string column1, string column2)
        {
            // Vẽ biểu đồ pie
            chart.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = chart.Series.Add(name);
            series.ChartType = SeriesChartType.Pie;
            series.Points.DataBindXY(table.Rows, column1, table.Rows, column2);
            // Thiết lập màu sắc cho các phần trong biểu đồ
            series.Palette = ChartColorPalette.Fire;

            // Hiển thị giá trị trên từng phần trong biểu đồ
            series.IsValueShownAsLabel = true;
        }    
        private void bieudocot(DataTable table, string name ,string x, string y)
        {            
            // Xóa các series cũ (nếu có)
            chart2.Series.Clear();

            // Tạo series mới
            Series series = new Series(name);
            series.ChartType = SeriesChartType.Column;
            // Lặp qua từng dòng trong DataTable và thêm giá trị vào series
            foreach (DataRow row in table.Rows)
            {
                string month = row[x].ToString();
                int quantity = Convert.ToInt32(row[y]);
                series.Points.AddXY(month, quantity);
            }

            if (GetMaximumValue(table, y) != 0)
            {
                // Thêm series vào biểu đồ
                chart2.Series.Add(series);
                // Đặt tên trục x và trục y
                chart2.ChartAreas[0].AxisX.Title = x;
                chart2.ChartAreas[0].AxisY.Title = y;
                chart2.ChartAreas[0].AxisY.Minimum = 0; // Giá trị nhỏ nhất của trục Y
                chart2.ChartAreas[0].AxisY.Maximum = GetMaximumValue(table, y);
                chart2.ChartAreas[0].RecalculateAxesScale();
            }
            else
                chart2.ChartAreas[0].AxisY.Maximum = 0;

        }
        private void bieudocottheonam(DataTable table, string name)
        {
            dataGridView_Data2.DataSource = table;
            bieudocot(table, name, "Tháng", "Số lượng");
        }
        private void bieudotrontheotrangthai(DataTable table, string name, string loai)
        {
            dataGridView_Data.DataSource = table;
            bieudotron(table, name, loai, "Số lượng");
        }
        private void thongke_nguoidung_Load(object sender, EventArgs e)
        {
            comboBox_thongke.SelectedIndex = 0;
            comboBox_nam.SelectedIndex = 0;
        }
        private void comboBox_thongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_thongke.SelectedIndex)
            {
                case 0:// thống kê người dùng
                    comboBox_nam.SelectedIndex = 0;
                    bieudotrontheotrangthai(thongke_BUS.thongkenguoidung(), "Tài khoản theo loại", "Tài khoản");
                    bieudocottheonam(thongke_BUS.thongkenguoidungmoitheothang(int.Parse(comboBox_nam.SelectedItem.ToString())), "Tài khoản mới theo tháng");
                    break;
                case 1:// Thống kê chiến dịch
                    comboBox_nam.SelectedIndex = 0;
                    bieudotrontheotrangthai(thongke_BUS.thongkechiendich(), "Chiến dịch theo trạng thái", "Chiến dịch");
                    bieudocottheonam(thongke_BUS.thongkechiendichtheothangvanam(int.Parse(comboBox_nam.SelectedItem.ToString())), "Chiến dịch bắt đầu theo tháng");
                    break;
                case 2:// Thống kê Voucher
                    comboBox_nam.SelectedIndex = 0;
                    bieudotrontheotrangthai(thongke_BUS.thongkevoucher(), "Voucher theo trạng thái", "Voucher");
                    bieudocottheonam(thongke_BUS.thongkevouchermoitheothang(int.Parse(comboBox_nam.SelectedItem.ToString())), "Voucher mới theo tháng");
                    break;
            }
        }
        private void comboBox_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_thongke.SelectedIndex)
            {
                case 0:
                    bieudocottheonam(thongke_BUS.thongkenguoidungmoitheothang(int.Parse(comboBox_nam.SelectedItem.ToString())), "Tài khoản mới theo tháng");
                    break;
                case 1:
                    bieudocottheonam(thongke_BUS.thongkechiendichtheothangvanam(int.Parse(comboBox_nam.SelectedItem.ToString())), "Chiến dịch bắt đầu theo tháng");
                    break;
                case 2:
                    bieudocottheonam(thongke_BUS.thongkevouchermoitheothang(int.Parse(comboBox_nam.SelectedItem.ToString())), "Voucher mới theo tháng");
                    break;
            }

        }
    }
}

