using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimManagementApp.Models
{
    public class DashboardModel
    {
        public string UserName { get; set; }
        public string Role { get; set; }

        // General Dashboard Information (applicable to all roles)
        public int TotalClaims { get; set; }
        public int PendingTasks { get; set; }
        public List<string> Notifications { get; set; }
        public List<string> RecentActivities { get; set; }

        // Admin-Specific Data
        public int TotalUsers { get; set; }
        public int ActiveUsers { get; set; }

        // Academic Manager-Specific Data
        public int TotalCourses { get; set; }
        public int OngoingCourses { get; set; }

        // Program Coordinator-Specific Data
        public int TotalPrograms { get; set; }
        public int ActivePrograms { get; set; }

        // Lecturer-Specific Data
        public int TotalStudents { get; set; }
        public List<string> UpcomingLectures { get; set; }

        // Constructor
        public DashboardModel()
        {
            // Initialize lists
            Notifications = new List<string>();
            RecentActivities = new List<string>();
            UpcomingLectures = new List<string>();
        }
    }
}
