using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise5_ExportReport.Interfaces
{
    public interface IReportExporter
    {
        public void ExportReport(string reportData);
    }
}
