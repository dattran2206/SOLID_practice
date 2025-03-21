using SOLID_Project.OCP.Exercise5_ExportReport.Context;
using SOLID_Project.OCP.Exercise5_ExportReport.FactoryPattern;
using SOLID_Project.OCP.Exercise5_ExportReport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise5_ExportReport
{
    public static class OCP_Excute5_Process
    {
        public static void Process()
        {
            Console.Write("Enter report type (PDF, Excel, CSV): ");
            string reportType = Console.ReadLine();

            try
            {
                IReportExporter exporter = ReportExporterFactory.GetExporter(reportType);
                ReportExporterContext context = new ReportExporterContext(exporter);

                string reportData = "Sales Report Q1 2025";
                context.Export(reportData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}
