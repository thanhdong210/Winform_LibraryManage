
namespace _2
{
    partial class ThongKeLoaiSachForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewLoaiSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLS.Legends.Add(legend1);
            this.chartLS.Location = new System.Drawing.Point(475, 12);
            this.chartLS.Name = "chartLS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "ChartLS";
            series1.YValuesPerPoint = 2;
            this.chartLS.Series.Add(series1);
            this.chartLS.Size = new System.Drawing.Size(582, 445);
            this.chartLS.TabIndex = 0;
            this.chartLS.Text = "chart1";
            // 
            // dataGridViewLoaiSach
            // 
            this.dataGridViewLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewLoaiSach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiSach.Location = new System.Drawing.Point(3, 12);
            this.dataGridViewLoaiSach.Name = "dataGridViewLoaiSach";
            this.dataGridViewLoaiSach.RowHeadersWidth = 51;
            this.dataGridViewLoaiSach.RowTemplate.Height = 24;
            this.dataGridViewLoaiSach.Size = new System.Drawing.Size(465, 445);
            this.dataGridViewLoaiSach.TabIndex = 1;
            // 
            // ThongKeLoaiSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1070, 469);
            this.Controls.Add(this.dataGridViewLoaiSach);
            this.Controls.Add(this.chartLS);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKeLoaiSachForm";
            this.Text = "ThongKeLoaiSachForm";
            this.Load += new System.EventHandler(this.ThongKeLoaiSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewLoaiSach;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartLS;
    }
}