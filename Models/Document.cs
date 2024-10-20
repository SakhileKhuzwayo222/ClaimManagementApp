using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClaimManagementApp.Models
{
    public class Document
    {
        [Key]
        public int DocumentID { get; set; }

        [Required]
        public int ClaimID { get; set; } // Foreign key to the Claim table

        [Required]
        [StringLength(255)]
        public string FileName { get; set; } // Name of the uploaded file

        [Required]
        public string FilePath { get; set; } // Physical or relative path to the document

        [Required]
        public DateTime UploadedDate { get; set; } // Timestamp for when the file was uploaded

        [Required]
        public string UploadedBy { get; set; } // The user who uploaded the document (lecturer, admin, etc.)

        // Navigation property
        public virtual Claim Claim { get; set; }
    }
}
