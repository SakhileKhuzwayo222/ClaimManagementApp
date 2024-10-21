using System.Collections.Generic;
using System.Web.Mvc;
using ClaimManagementApp.Models;

namespace ClaimManagementApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            var userRole = GetUserRole(User.Identity.Name);

            DashboardModel dashboardData = new DashboardModel
            {
                UserName = User.Identity.Name,
                Role = userRole,
                TotalClaims = GetTotalClaims(User.Identity.Name),
                PendingTasks = GetPendingTasks(User.Identity.Name),
                Notifications = GetNotifications(User.Identity.Name),
                RecentActivities = GetRecentActivities(User.Identity.Name)
            };

            switch (userRole)
            {
                case "Admin":
                    dashboardData.TotalUsers = GetTotalUsers();
                    dashboardData.ActiveUsers = GetActiveUsers();
                    break;

                case "Academic Manager":
                    dashboardData.TotalCourses = GetTotalCourses();
                    dashboardData.OngoingCourses = GetOngoingCourses();
                    break;

                case "Program Coordinator":
                    dashboardData.TotalPrograms = GetTotalPrograms();
                    dashboardData.ActivePrograms = GetActivePrograms();
                    break;

                case "Lecturer":
                    dashboardData.TotalStudents = GetTotalStudents(User.Identity.Name);
                    dashboardData.UpcomingLectures = GetUpcomingLectures(User.Identity.Name);
                    break;
            }

            return View(dashboardData);
        }

        // Example methods to retrieve data based on user role
        private int GetTotalClaims(string username)
        {
            // Logic to fetch total claims for the user
            return 10; // Placeholder value
        }

        private int GetPendingTasks(string username)
        {
            // Logic to fetch pending tasks for the user
            return 5; // Placeholder value
        }

        private List<string> GetNotifications(string username)
        {
            // Logic to fetch notifications for the user
            return new List<string> { "Notification 1", "Notification 2" }; // Placeholder values
        }

        private List<string> GetRecentActivities(string username)
        {
            // Logic to fetch recent activities for the user
            return new List<string> { "Activity 1", "Activity 2" }; // Placeholder values
        }

        private int GetTotalUsers()
        {
            // Logic to get total users for admin
            return 50; // Placeholder value
        }

        private int GetActiveUsers()
        {
            // Logic to get active users for admin
            return 45; // Placeholder value
        }

        private int GetTotalCourses()
        {
            // Logic to get total courses for academic manager
            return 20; // Placeholder value
        }

        private int GetOngoingCourses()
        {
            // Logic to get ongoing courses for academic manager
            return 5; // Placeholder value
        }

        private int GetTotalPrograms()
        {
            // Logic to get total programs for program coordinator
            return 10; // Placeholder value
        }

        private int GetActivePrograms()
        {
            // Logic to get active programs for program coordinator
            return 8; // Placeholder value
        }

        private int GetTotalStudents(string lecturerUsername)
        {
            // Logic to get total students for lecturer
            return 30; // Placeholder value
        }

        private List<string> GetUpcomingLectures(string lecturerUsername)
        {
            // Logic to get upcoming lectures for lecturer
            return new List<string> { "Lecture 1", "Lecture 2" }; // Placeholder values
        }

        // ...

        private string GetUserRole(string username)
        {
            // Logic to retrieve user role based on username
            // Replace this with your actual logic to determine the user's role
            // For example, you can query a database or use a predefined mapping
            // between usernames and roles
            if (username == "admin")
            {
                return "Admin";
            }
            else if (username == "manager")
            {
                return "Academic Manager";
            }
            else if (username == "coordinator")
            {
                return "Program Coordinator";
            }
            else if (username == "lecturer")
            {
                return "Lecturer";
            }
            else
            {
                return "Guest";
            }
        }
    }
}

