using SOLID_Project.OCP.Exercise5_ExportReport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise5_ExportReport.StrategyPattern
{
    public class ExcelReportExporter : IReportExporter
    {
        public void ExportReport(string reportData)
        {
            Console.WriteLine($"Exporting Excel Report: {reportData}");
        }
    }
}
