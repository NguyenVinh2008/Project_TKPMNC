namespace project_tkpmnc.GUI
{
    partial class thongke_nguoidung
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_thongke = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Data2 = new System.Windows.Forms.DataGridView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToAddRows = false;
            this.dataGridView_Data.AllowUserToDeleteRows = false;
            this.dataGridView_Data.AllowUserToResizeRows = false;
            this.dataGridView_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Location = new System.Drawing.Point(3, 64);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.ReadOnly = true;
            this.dataGridView_Data.RowHeadersVisible = false;
            this.dataGridView_Data.Size = new System.Drawing.Size(479, 208);
            this.dataGridView_Data.TabIndex = 43;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 278);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(479, 334);
            this.chart.TabIndex = 44;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Thống kê hệ thống";
            // 
            // comboBox_thongke
            // 
            this.comboBox_thongke.FormattingEnabled = true;
            this.comboBox_thongke.Items.AddRange(new object[] {
            "Người dùng",
            "Chiến dịch",
            "Voucher"});
            this.comboBox_thongke.Location = new System.Drawing.Point(81, 37);
            this.comboBox_thongke.Name = "comboBox_thongke";
            this.comboBox_thongke.Size = new System.Drawing.Size(121, 21);
            this.comboBox_thongke.TabIndex = 46;
            this.comboBox_thongke.SelectedIndexChanged += new System.EventHandler(this.comboBox_thongke_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Loại thống kê";
            // 
            // dataGridView_Data2
            // 
            this.dataGridView_Data2.AllowUserToAddRows = false;
            this.dataGridView_Data2.AllowUserToDeleteRows = false;
            this.dataGridView_Data2.AllowUserToResizeRows = false;
            this.dataGridView_Data2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Data2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data2.Location = new System.Drawing.Point(488, 3);
            this.dataGridView_Data2.Name = "dataGridView_Data2";
            this.dataGridView_Data2.ReadOnly = true;
            this.dataGridView_Data2.RowHeadersVisible = false;
            this.dataGridView_Data2.RowTemplate.ReadOnly = true;
            this.dataGridView_Data2.ShowEditingIcon = false;
            this.dataGridView_Data2.Size = new System.Drawing.Size(791, 269);
            this.dataGridView_Data2.TabIndex = 49;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(488, 278);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(792, 334);
            this.chart2.TabIndex = 50;
            this.chart2.Text = "chart1";
            // 
            // thongke_nguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridView_Data2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_thongke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView_Data);
            this.Name = "thongke_nguoidung";
            this.Size = new System.Drawing.Size(1283, 615);
            this.Load += new System.EventHandler(this.thongke_nguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Data;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_thongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Data2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
