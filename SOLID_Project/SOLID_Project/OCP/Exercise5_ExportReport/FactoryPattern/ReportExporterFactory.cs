using SOLID_Project.OCP.Exercise5_ExportReport.Interfaces;
using SOLID_Project.OCP.Exercise5_ExportReport.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise5_ExportReport.FactoryPattern
{
    public static class ReportExporterFactory
    {
        public static IReportExporter GetExporter(string type)
        {
            return type.ToLower() switch
            {
                "pdf" => new PdfReportExporter(),
                "excel" => new ExcelReportExporter(),
                "csv" => new CsvReportExporter(),
                _ => throw new ArgumentException("Unsupported report type.")
            };
        }
    }
}
