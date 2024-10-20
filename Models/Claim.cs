using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimManagementApp.Models
{
    public class Claim
    {
        // Properties
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public int? CoordinatorID { get; set; } // Nullable if not all claims need a coordinator
        public int? ManagerID { get; set; } // Nullable if not all claims need a manager
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string AdditionalNotes { get; set; }
        public decimal TotalAmount => CalculateTotalAmount(); // Calculated property
        public string Status { get; set; } // e.g., "Pending", "Approved", "Rejected"

        // Constructor
        public Claim(int lecturerID, decimal hoursWorked, decimal hourlyRate, string additionalNotes, string status)
        {
            LecturerID = lecturerID;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            AdditionalNotes = additionalNotes;
            Status = status;
        }

        // Method to calculate the total amount
        private decimal CalculateTotalAmount()
        {
            return HoursWorked * HourlyRate;
        }

        // CRUD Operations (methods would typically call a repository)

        public void CreateClaim()
        {
            // Logic to create the claim in the database
        }

        public static Claim ReadClaim(int claimId)
        {
            // Logic to read the claim from the database
            // Example return statement (this would actually query the database)
            return new Claim(1, 10, 20, "Test Notes", "Pending");
        }

        public void UpdateClaim()
        {
            // Logic to update the claim in the database
        }

        public void DeleteClaim(int claimId)
        {
            // Logic to delete the claim from the database
        }
    }
}
