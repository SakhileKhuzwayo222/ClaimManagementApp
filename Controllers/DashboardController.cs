using System.Collections.Generic;
using System.Web.Mvc;
using ClaimManagementApp.Data;
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
            using (var dbContext = new ApplicationDbContext())
            {
                // Fetch total claims for the user from the database
                return dbContext.Claims.Count(c => c.Username == username);
            }
        }

        private int GetPendingTasks(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                // Fetch pending tasks for the user
                return dbContext.Tasks.Count(t => t.Username == username && t.Status == "Pending");
            }
        }

        private List<string> GetNotifications(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                // Fetch notifications for the user
                return dbContext.Notifications
                                .Where(n => n.Username == username)
                                .Select(n => n.Message)
                                .ToList();
            }
        }

        private List<string> GetRecentActivities(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                // Fetch recent activities for the user
                return dbContext.Activities
                                .Where(a => a.Username == username)
                                .OrderByDescending(a => a.Timestamp)
                                .Take(5)  // Get the latest 5 activities
                                .Select(a => a.Description)
                                .ToList();
            }
        }

        // Admin specific data retrieval
        private int GetTotalUsers()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Users.Count();
            }
        }

        private int GetActiveUsers()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Users.Count(u => u.IsActive);
            }
        }

        // Academic Manager data retrieval
        private int GetTotalCourses()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Courses.Count();
            }
        }

        private int GetOngoingCourses()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Courses.Count(c => c.Status == "Ongoing");
            }
        }

        // Program Coordinator data retrieval
        private int GetTotalPrograms()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Programs.Count();
            }
        }

        private int GetActivePrograms()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Programs.Count(p => p.IsActive);
            }
        }

        // Lecturer-specific data retrieval
        private int GetTotalStudents(string lecturerUsername)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Students.Count(s => s.LecturerUsername == lecturerUsername);
            }
        }

        private List<string> GetUpcomingLectures(string lecturerUsername)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Lectures
                                .Where(l => l.LecturerUsername == lecturerUsername && l.StartTime > DateTime.Now)
                                .OrderBy(l => l.StartTime)
                                .Take(5)  // Get the next 5 lectures
                                .Select(l => l.Title)
                                .ToList();
            }
        }

        // Function to retrieve user role
        private string GetUserRole(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    return user.Role;
                }
                return "Guest"; // Default role if user is not found
            }
        }
    }}

