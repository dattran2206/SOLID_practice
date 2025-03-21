using SOLID_Project.OCP.Exercise5_ExportReport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise5_ExportReport.Context
{
    public class ReportExporterContext
    {
        private readonly IReportExporter _reportExporter;

        public ReportExporterContext(IReportExporter reportExporter)
        {
            _reportExporter = reportExporter;
        }

        public void Export(string reportData)
        {
            _reportExporter.ExportReport(reportData);
        }
    }
}
