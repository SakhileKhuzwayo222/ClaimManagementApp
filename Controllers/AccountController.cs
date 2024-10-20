using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClaimManagementApp.Models; // Assuming you have a User model or similar

namespace ClaimManagementApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Assuming you have a method to authenticate the user
                var user = AuthenticateUser(model.Username, model.Password); // Replace with your authentication logic

                if (user != null)
                {
                    // Check the user's role and redirect accordingly
                    switch (user.RoleID)
                    {
                        case 1: // Admin
                            return RedirectToAction("AdminDashboard", "Dashboard");
                        case 2: // Academic Manager
                            return RedirectToAction("AcademicManagerDashboard", "Dashboard");
                        case 3: // Program Coordinator
                            return RedirectToAction("ProgramCoordinatorDashboard", "Dashboard");
                        case 4: // Lecturer
                            return RedirectToAction("LecturerDashboard", "Dashboard");
                        default:
                            return RedirectToAction("Login", "Account");
                    }
                }
                else
                {
                    // If authentication fails, add an error message
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }

            // If we get to this point, something failed, so return the view with errors
            return View(model);
        }

        // POST: Account/Logout
        [HttpPost]
        public ActionResult Logout()
        {
            // Clear authentication data (e.g., sign out)
            Session.Clear(); // This could be more complex depending on how you're handling authentication
            return RedirectToAction("Login");
        }

        // Other CRUD actions you have already implemented...

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // Helper method for user authentication
        private UserModel AuthenticateUser(string username, string password)
        {
            // Add logic to authenticate the user, such as checking credentials from the database
            // This is a placeholder; replace it with real authentication logic
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }
    }
}

