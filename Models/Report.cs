using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace ClaimManagementApp.Models
{
    public class Report
    {
        public int ReportID { get; set; }

        [Required]
        public DateTime GeneratedOn { get; set; } // Date the report was generated

        [Required]
        public string ReportType { get; set; } // e.g., "Claims Report", "Lecturer Report"

        [Required]
        public string GeneratedBy { get; set; } // Who generated the report (admin, coordinator)

        public string DataSummary { get; set; } // JSON or CSV data summary of the report

        public string FilePath { get; set; } // Path to a generated report file (if needed)
    }
}