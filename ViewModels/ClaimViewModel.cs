using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ClaimManagementApp.Models;

namespace ClaimManagementApp.ViewModels
{
    public class ClaimViewModel
    {
        public int ClaimId { get; set; }
        public string ClaimantName { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        // Adding a constructor that takes one argument
        public ClaimViewModel(Claim claim)
        {
            ClaimId = claim.ClaimID;
            ClaimantName = ""; // Assuming you will set this value appropriately
            ClaimDate = DateTime.Now; // Assuming you will set this value appropriately
            ClaimAmount = claim.TotalAmount;
            Status = claim.Status;
            Description = ""; // Assuming you will set this value appropriately
            Notes = claim.AdditionalNotes;
        }
    }
}
