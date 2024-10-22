using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClaimManagementApp.Models;

namespace ClaimManagementApp.ViewModels
{
    public class DashboardViewModel
    {
        public List<ClaimViewModel> Claims { get; set; }
        public int TotalClaims { get; set; }
        public int ApprovedClaims { get; set; }
        public int RejectedClaims { get; set; }
        public int PendingClaims { get; set; }

        public DashboardViewModel(List<Claim> claims)
        {
            Claims = claims.Select(c => new ClaimViewModel(c)).ToList();
            TotalClaims = claims.Count;
            ApprovedClaims = claims.Count(c => c.Status == "Approved");
            RejectedClaims = claims.Count(c => c.Status == "Rejected");
            PendingClaims = claims.Count(c => c.Status == "Pending");
        }
    }
    
}