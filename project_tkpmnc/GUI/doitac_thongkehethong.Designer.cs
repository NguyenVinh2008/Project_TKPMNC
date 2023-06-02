namespace project_tkpmnc.GUI
{
    partial class doitac_thongkehethong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_Data2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_trangthai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(402, 278);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(878, 334);
            this.chart2.TabIndex = 57;
            this.chart2.Text = "chart1";
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
            this.dataGridView_Data2.Location = new System.Drawing.Point(402, 3);
            this.dataGridView_Data2.Name = "dataGridView_Data2";
            this.dataGridView_Data2.ReadOnly = true;
            this.dataGridView_Data2.RowHeadersVisible = false;
            this.dataGridView_Data2.RowTemplate.ReadOnly = true;
            this.dataGridView_Data2.ShowEditingIcon = false;
            this.dataGridView_Data2.Size = new System.Drawing.Size(877, 269);
            this.dataGridView_Data2.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Thống kê trạng thái";
            // 
            // comboBox_trangthai
            // 
            this.comboBox_trangthai.FormattingEnabled = true;
            this.comboBox_trangthai.Items.AddRange(new object[] {
            "Voucher",
            "Chiến dịch"});
            this.comboBox_trangthai.Location = new System.Drawing.Point(109, 37);
            this.comboBox_trangthai.Name = "comboBox_trangthai";
            this.comboBox_trangthai.Size = new System.Drawing.Size(97, 21);
            this.comboBox_trangthai.TabIndex = 54;
            this.comboBox_trangthai.SelectedIndexChanged += new System.EventHandler(this.comboBox_trangthai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thống kê hệ thống";
            // 
            // chart
            // 
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(3, 278);
            this.chart.Name = "chart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(393, 334);
            this.chart.TabIndex = 52;
            this.chart.Text = "chart1";
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToAddRows = false;
            this.dataGridView_Data.AllowUserToDeleteRows = false;
            this.dataGridView_Data.AllowUserToResizeRows = false;
            this.dataGridView_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Location = new System.Drawing.Point(3, 91);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.ReadOnly = true;
            this.dataGridView_Data.RowHeadersVisible = false;
            this.dataGridView_Data.Size = new System.Drawing.Size(393, 181);
            this.dataGridView_Data.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Thống kê theo năm";
            // 
            // comboBox_nam
            // 
            this.comboBox_nam.FormattingEnabled = true;
            this.comboBox_nam.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.comboBox_nam.Location = new System.Drawing.Point(109, 64);
            this.comboBox_nam.Name = "comboBox_nam";
            this.comboBox_nam.Size = new System.Drawing.Size(97, 21);
            this.comboBox_nam.TabIndex = 54;
            this.comboBox_nam.SelectedIndexChanged += new System.EventHandler(this.comboBox_nam_SelectedIndexChanged);
            // 
            // doitac_thongkehethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridView_Data2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_nam);
            this.Controls.Add(this.comboBox_trangthai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView_Data);
            this.Name = "doitac_thongkehethong";
            this.Size = new System.Drawing.Size(1283, 615);
            this.Load += new System.EventHandler(this.doitac_thongkehethong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView dataGridView_Data2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_trangthai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridView_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_nam;
    }
}
