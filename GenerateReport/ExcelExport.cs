using OfficeOpenXml;
using System.IO;

namespace GenerateReport
{
    public class ExcelExport
    {
        public static void ExportToExcel(Denies[] denies, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                // Add a new worksheet
                var worksheet = package.Workbook.Worksheets.Add("DeniesSheet");

                // Set column names and format
                worksheet.Cells[1, 1].Value = "Date";
                worksheet.Cells[1, 2].Value = "Number of Denies";

                worksheet.Column(1).Width = 15;
                worksheet.Column(2).Width = 15;

                // Centralize text in cells
                worksheet.Cells[1, 1, denies.Length + 1, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Populate data
                for (int i = 0; i < denies.Length; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = denies[i].RunDate;
                    worksheet.Cells[i + 2, 2].Value = denies[i].Count;
                }

                // Save the Excel package
                package.SaveAs(new FileInfo(filePath));
            }
        }
    }
}
