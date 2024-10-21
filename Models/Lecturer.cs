using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClaimManagementApp.Models
{
    public class Lecturer
    {
        // Primary Key
        [Key] // Marks this property as the primary key
        public int LecturerID { get; set; }

        // First Name of the Lecturer
        [Required(ErrorMessage = "First name is required")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FirstName { get; set; }

        // Last Name of the Lecturer
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(100, ErrorMessage = "Last name cannot be longer than 100 characters.")]
        public string LastName { get; set; }

        // Email of the Lecturer
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        // Hourly rate for the Lecturer (used for calculating payment in claims)
        [Range(0, double.MaxValue, ErrorMessage = "Hourly rate must be positive")]
        public decimal HourlyRate { get; set; }

        // Faculty ID (Foreign Key or identifier for the faculty the Lecturer belongs to)
        [Required(ErrorMessage = "Faculty ID is required")]
        public int FacultyID { get; set; }

        // Hours worked by the Lecturer (could be used for claim submission)
        public double HoursWorked { get; set; }

        // Any additional notes related to the Lecturer
        public string Notes { get; set; }
    }
}

