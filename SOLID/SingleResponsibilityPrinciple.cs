using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesSOLID
{
    public class ReportGenerator
    {
        public string GenerateReport()
        {
            // Generate the report
            return "Report content";
        }
    }

    public class ReportSaver
    {
        public void SaveReport(string reportContent)
        {
            // Save the report to a file
            System.IO.File.WriteAllText("report.txt", reportContent);
        }
    }

}
