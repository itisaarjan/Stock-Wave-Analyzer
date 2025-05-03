/*
Name: Arjan Subedi
Unumber: U81857374
*/

namespace Project_2
{
    partial class ChartDisplayForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.chart_stockData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_updateStockData = new System.Windows.Forms.Button();
            this.label_updateStartDate = new System.Windows.Forms.Label();
            this.label_updateEndDate = new System.Windows.Forms.Label();
            this.hScrollBar_margin = new System.Windows.Forms.HScrollBar();
            this.label_margin = new System.Windows.Forms.Label();
            this.comboBox_upWaves = new System.Windows.Forms.ComboBox();
            this.comboBox_downWaves = new System.Windows.Forms.ComboBox();
            this.label_upWaves = new System.Windows.Forms.Label();
            this.label_downWaves = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stockData)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(1066, 12);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerStartDate.TabIndex = 4;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.DateTimePickerStartDate_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(1066, 45);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerEndDate.TabIndex = 5;
            // 
            // chart_stockData
            // 
            chartArea1.Name = "area_OHLC";
            chartArea2.Name = "area_Volume";
            this.chart_stockData.ChartAreas.Add(chartArea1);
            this.chart_stockData.ChartAreas.Add(chartArea2);
            this.chart_stockData.Location = new System.Drawing.Point(1, 278);
            this.chart_stockData.Name = "chart_stockData";
            series1.ChartArea = "area_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceUpColor=Green, PriceDownColor=Red";
            series1.IsXValueIndexed = true;
            series1.Name = "series_OHLC";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "area_Volume";
            series2.IsXValueIndexed = true;
            series2.Name = "series_Volume";
            this.chart_stockData.Series.Add(series1);
            this.chart_stockData.Series.Add(series2);
            this.chart_stockData.Size = new System.Drawing.Size(1502, 541);
            this.chart_stockData.TabIndex = 9;
            this.chart_stockData.Text = "chart1";
            this.chart_stockData.Click += new System.EventHandler(this.chart_stockData_Click);
            // 
            // button_updateStockData
            // 
            this.button_updateStockData.Location = new System.Drawing.Point(1324, 16);
            this.button_updateStockData.Name = "button_updateStockData";
            this.button_updateStockData.Size = new System.Drawing.Size(179, 61);
            this.button_updateStockData.TabIndex = 10;
            this.button_updateStockData.Text = "Update Stock Data (Refresh)";
            this.button_updateStockData.Click += new System.EventHandler(this.button_updateStockData_Click);
            // 
            // label_updateStartDate
            // 
            this.label_updateStartDate.AutoSize = true;
            this.label_updateStartDate.Location = new System.Drawing.Point(945, 17);
            this.label_updateStartDate.Name = "label_updateStartDate";
            this.label_updateStartDate.Size = new System.Drawing.Size(114, 16);
            this.label_updateStartDate.TabIndex = 13;
            this.label_updateStartDate.Text = "Update Start Date";
            // 
            // label_updateEndDate
            // 
            this.label_updateEndDate.AutoSize = true;
            this.label_updateEndDate.Location = new System.Drawing.Point(945, 51);
            this.label_updateEndDate.Name = "label_updateEndDate";
            this.label_updateEndDate.Size = new System.Drawing.Size(111, 16);
            this.label_updateEndDate.TabIndex = 14;
            this.label_updateEndDate.Text = "Update End Date";
            this.label_updateEndDate.Click += new System.EventHandler(this.LabelUpdateEndDate_Click);
            // 
            // hScrollBar_margin
            // 
            this.hScrollBar_margin.LargeChange = 1;
            this.hScrollBar_margin.Location = new System.Drawing.Point(386, 12);
            this.hScrollBar_margin.Maximum = 4;
            this.hScrollBar_margin.Minimum = 1;
            this.hScrollBar_margin.Name = "hScrollBar_margin";
            this.hScrollBar_margin.Size = new System.Drawing.Size(145, 17);
            this.hScrollBar_margin.TabIndex = 5;
            this.hScrollBar_margin.Value = 1;
            this.hScrollBar_margin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarMargin_Scroll);
            // 
            // label_margin
            // 
            this.label_margin.AutoSize = true;
            this.label_margin.Location = new System.Drawing.Point(335, 12);
            this.label_margin.Name = "label_margin";
            this.label_margin.Size = new System.Drawing.Size(61, 16);
            this.label_margin.TabIndex = 16;
            this.label_margin.Text = "Margin: 1";
            // 
            // comboBox_upWaves
            // 
            this.comboBox_upWaves.Location = new System.Drawing.Point(665, 10);
            this.comboBox_upWaves.Name = "comboBox_upWaves";
            this.comboBox_upWaves.Size = new System.Drawing.Size(242, 24);
            this.comboBox_upWaves.TabIndex = 17;
            this.comboBox_upWaves.SelectedIndexChanged += new System.EventHandler(this.comboBox_upWaves_SelectedIndexChanged);
            // 
            // comboBox_downWaves
            // 
            this.comboBox_downWaves.Location = new System.Drawing.Point(665, 43);
            this.comboBox_downWaves.Name = "comboBox_downWaves";
            this.comboBox_downWaves.Size = new System.Drawing.Size(242, 24);
            this.comboBox_downWaves.TabIndex = 18;
            this.comboBox_downWaves.SelectedIndexChanged += new System.EventHandler(this.comboBox_downWaves_SelectedIndexChanged);
            // 
            // label_upWaves
            // 
            this.label_upWaves.AutoSize = true;
            this.label_upWaves.Location = new System.Drawing.Point(585, 17);
            this.label_upWaves.Name = "label_upWaves";
            this.label_upWaves.Size = new System.Drawing.Size(74, 16);
            this.label_upWaves.TabIndex = 19;
            this.label_upWaves.Text = "Up Waves:";
            this.label_upWaves.Click += new System.EventHandler(this.LabelUpWaves_Click);
            // 
            // label_downWaves
            // 
            this.label_downWaves.AutoSize = true;
            this.label_downWaves.Location = new System.Drawing.Point(569, 46);
            this.label_downWaves.Name = "label_downWaves";
            this.label_downWaves.Size = new System.Drawing.Size(90, 16);
            this.label_downWaves.TabIndex = 20;
            this.label_downWaves.Text = "Down Waves:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confirmations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChartDisplayForm
            // 
            this.ClientSize = new System.Drawing.Size(1506, 822);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_downWaves);
            this.Controls.Add(this.label_upWaves);
            this.Controls.Add(this.comboBox_downWaves);
            this.Controls.Add(this.comboBox_upWaves);
            this.Controls.Add(this.label_margin);
            this.Controls.Add(this.hScrollBar_margin);
            this.Controls.Add(this.label_updateEndDate);
            this.Controls.Add(this.label_updateStartDate);
            this.Controls.Add(this.button_updateStockData);
            this.Controls.Add(this.chart_stockData);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Name = "ChartDisplayForm";
            this.Text = "Chart Data";
            this.Load += new System.EventHandler(this.ChartDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_stockData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stockData;
        private System.Windows.Forms.Button button_updateStockData;
        private System.Windows.Forms.Label label_updateStartDate;
        private System.Windows.Forms.Label label_updateEndDate;
        private System.Windows.Forms.HScrollBar hScrollBar_margin;
        private System.Windows.Forms.Label label_margin;
        private System.Windows.Forms.ComboBox comboBox_upWaves;
        private System.Windows.Forms.ComboBox comboBox_downWaves;
        private System.Windows.Forms.Label label_upWaves;
        private System.Windows.Forms.Label label_downWaves;
        private System.Windows.Forms.Label label1;
    }
}