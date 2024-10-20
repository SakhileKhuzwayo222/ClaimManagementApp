using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimManagementApp.Models
{
    public class Approval
    {
        // Properties
        public int ApprovalID { get; set; }
        public int ClaimID { get; set; } // Foreign Key to Claim
        public string ApproverType { get; set; } // e.g., "Coordinator" or "Manager"
        public int ApproverID { get; set; } // ID of the Approver
        public DateTime ApprovalDate { get; set; } = DateTime.Now; // Default to current date
        public string Status { get; set; } // e.g., "Approved", "Rejected"

        // Constructor
        public Approval(int claimID, string approverType, int approverID, string status)
        {
            ClaimID = claimID;
            ApproverType = approverType;
            ApproverID = approverID;
            Status = status;
        }

        // CRUD Operations (methods would typically call a repository)

        public void CreateApproval()
        {
            // Logic to create the approval in the database
        }

        public static Approval ReadApproval(int approvalID)
        {
            // Logic to read the approval from the database
            // Example return statement (this would actually query the database)
            return new Approval(1, "Coordinator", 1, "Approved");
        }

        public void UpdateApproval()
        {
            // Logic to update the approval in the database
        }

        public void DeleteApproval(int approvalID)
        {
            // Logic to delete the approval from the database
        }
    }
}
