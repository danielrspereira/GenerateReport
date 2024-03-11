using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GenerateReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chDenies.Visible = false;
        }

        private void cbReportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            List<Denies> denies = new List<Denies>();
            for (int i = 0; i < 20; i++)
            {
                denies.Add(new Denies
                {
                    Count = i + 1,
                    RunDate = DateTime.ParseExact(CreateDateTimeString(i+1), "dd.MM.yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture)
            });
            }
            DisplayHistogram(denies.ToArray(), dateTimePicker1.Value, dateTimePicker2.Value);

            //ExcelExport.ExportToExcel(denies.ToArray(), $"C:\\Users\\{Environment.UserName.ToLower()}\\export_{DateTime.Now.ToString("dd.MM.yyyy")}.xlsx");
        }

        public string CreateDateTimeString(int i)
        {
            if (i<10)
            {
                return "0" + i.ToString() + ".03.2024";
            }
            return i.ToString() + ".03.2024";
        }

        private void DisplayHistogram(Denies[] denies, DateTime start, DateTime end)
        {
            // Clear any existing series in the chart
            chDenies.Series.Clear();
            chDenies.Visible = true;

            // Add a new series for the histogram
            Series histogramSeries = new Series("Histogram");
            histogramSeries.ChartType = SeriesChartType.Column;

            denies = denies.Where(x=>x.RunDate>=start && x.RunDate <= end).ToArray();

            // Populate the series with data
            foreach (var deny in denies)
            {
                histogramSeries.Points.AddXY(deny.RunDate, deny.Count);
            }

            // Add the series to the chart
            chDenies.Series.Add(histogramSeries);

            // Set chart properties
            chDenies.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Format X-axis labels
            chDenies.ChartAreas[0].AxisX.Interval = 2; // Display every date

            // Set axis titles
            chDenies.ChartAreas[0].AxisX.Title = "RunDate";
            chDenies.ChartAreas[0].AxisY.Title = "Count";

            // Remove the legend
            chDenies.Legends.Clear();

            // Refresh the chart
            chDenies.Refresh();
        }
    }
}
