using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClaimManagementApp.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Name of the faculty (e.g., "Faculty of Engineering")

        [StringLength(255)]
        public string Description { get; set; } // Optional description of the faculty

        // Navigation property for Lecturers associated with this faculty
        public virtual ICollection<Lecturer> Lecturers { get; set; }
    }
}
