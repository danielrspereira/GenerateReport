namespace GenerateReport
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cbReportSelector = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.chDenies = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chDenies)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 246);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(221, 292);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(251, 340);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(90, 51);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(138, 246);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(67, 16);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(142, 292);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 16);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End date:";
            // 
            // cbReportSelector
            // 
            this.cbReportSelector.FormattingEnabled = true;
            this.cbReportSelector.Items.AddRange(new object[] {
            "DSLS usage",
            "DSLS Denies",
            "DSLS Delta",
            "Power Users"});
            this.cbReportSelector.Location = new System.Drawing.Point(222, 198);
            this.cbReportSelector.Margin = new System.Windows.Forms.Padding(4);
            this.cbReportSelector.Name = "cbReportSelector";
            this.cbReportSelector.Size = new System.Drawing.Size(160, 24);
            this.cbReportSelector.TabIndex = 5;
            this.cbReportSelector.SelectedIndexChanged += new System.EventHandler(this.cbReportSelector_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(52, 201);
            this.lblReportType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(150, 16);
            this.lblReportType.TabIndex = 6;
            this.lblReportType.Text = "Select the type of report:";
            // 
            // chDenies
            // 
            chartArea1.Name = "ChartArea1";
            this.chDenies.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chDenies.Legends.Add(legend1);
            this.chDenies.Location = new System.Drawing.Point(428, 9);
            this.chDenies.Name = "chDenies";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chDenies.Series.Add(series1);
            this.chDenies.Size = new System.Drawing.Size(556, 437);
            this.chDenies.TabIndex = 7;
            this.chDenies.Text = "Denies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 461);
            this.Controls.Add(this.chDenies);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cbReportSelector);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CATIA Usage Report Generator";
            ((System.ComponentModel.ISupportInitialize)(this.chDenies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cbReportSelector;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDenies;
    }
}

