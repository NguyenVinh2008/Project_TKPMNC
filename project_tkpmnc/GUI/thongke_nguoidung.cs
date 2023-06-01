using project_tkpmnc.BUS;
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using project_tkpmnc.DTO;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using System.Linq;

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

            // Thêm series vào biểu đồ
            chart2.Series.Add(series);

            // Đặt tên trục x và trục y
            chart2.ChartAreas[0].AxisX.Title = x;
            chart2.ChartAreas[0].AxisY.Title = y;           

            chart2.ChartAreas[0].AxisY.Minimum = 0; // Giá trị nhỏ nhất của trục Y
            chart2.ChartAreas[0].AxisY.Maximum = GetMaximumValue(table, y);
            chart2.ChartAreas[0].RecalculateAxesScale();

        }
        private void thongke_nguoidung_Load(object sender, EventArgs e)
        {
            comboBox_thongke.SelectedIndex = 0;
            dataGridView_Data.DataSource = thongke_BUS.thongkenguoidung();
            bieudotron(thongke_BUS.thongkenguoidung(), "Tài khoản theo loại", "Tài khoản", "Số lượng");
            dataGridView_Data2.DataSource = thongke_BUS.thongkenguoidungmoitheothang();
            bieudocot(thongke_BUS.thongkenguoidungmoitheothang(), "Tài khoản mới theo tháng", "Tháng", "Số lượng");
        }
        private void button_xem_Click(object sender, EventArgs e)
        {
            switch(comboBox_thongke.SelectedIndex)
            {
                case 0:
                    dataGridView_Data.DataSource = thongke_BUS.thongkenguoidung();
                    bieudotron(thongke_BUS.thongkenguoidung(), "Tài khoản theo loại", "Tài khoản", "Số lượng");
                    dataGridView_Data2.DataSource = thongke_BUS.thongkenguoidungmoitheothang();
                    bieudocot(thongke_BUS.thongkenguoidungmoitheothang(), "Tài khoản mới theo tháng", "Tháng", "Số lượng");
                    break;
                case 1:
                    dataGridView_Data.DataSource = thongke_BUS.thongkechiendich();
                    bieudotron(thongke_BUS.thongkechiendich(), "Chiến dịch theo trạng thái", "Chiến dịch", "Số lượng");
                    dataGridView_Data2.DataSource = thongke_BUS.thongkechiendichtheothang();
                    bieudocot(thongke_BUS.thongkechiendichtheothang(), "Chiến dịch bắt đầu theo tháng", "Tháng", "Số lượng");
                    break;
                case 2:
                    dataGridView_Data.DataSource = thongke_BUS.thongkevoucher();
                    bieudotron(thongke_BUS.thongkevoucher(), "Voucher theo trạng thái", "Voucher", "Số lượng");
                    dataGridView_Data2.DataSource = thongke_BUS.thongkevouchermoitheothang();
                    bieudocot(thongke_BUS.thongkevouchermoitheothang(), "Voucher mới theo tháng", "Tháng", "Số lượng");
                    break;
            }    
        }
        private void comboBox_thongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_thongke.SelectedIndex)
            {
                case 0:
                    dataGridView_Data.DataSource = thongke_BUS.thongkenguoidung();
                    bieudotron(thongke_BUS.thongkenguoidung(), "Tài khoản theo loại", "Tài khoản", "Số lượng");
                    dataGridView_Data2.DataSource = thongke_BUS.thongkenguoidungmoitheothang();
                    bieudocot(thongke_BUS.thongkenguoidungmoitheothang(), "Tài khoản mới theo tháng", "Tháng", "Số lượng");
                    break;
                case 1:
                    dataGridView_Data.DataSource = thongke_BUS.thongkechiendich();
                    bieudotron(thongke_BUS.thongkechiendich(), "Chiến dịch theo trạng thái", "Chiến dịch", "Số lượng");
                    dataGridView_Data2.DataSource = thongke_BUS.thongkechiendichtheothang();
                    bieudocot(thongke_BUS.thongkechiendichtheothang(), "Chiến dịch bắt đầu theo tháng", "Tháng", "Số lượng");
                    break;
                case 2:
                    dataGridView_Data.DataSource = thongke_BUS.thongkevoucher();
                    bieudotron(thongke_BUS.thongkevoucher(), "Voucher theo trạng thái", "Voucher", "Số lượng");
                    dataGridView_Data2.DataSource = thongke_BUS.thongkevouchermoitheothang();
                    bieudocot(thongke_BUS.thongkevouchermoitheothang(), "Voucher mới theo tháng", "Tháng", "Số lượng");
                    break;
            }
        }
    }
}

