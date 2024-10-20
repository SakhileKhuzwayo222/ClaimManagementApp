using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaimManagementApp.Controllers
{
    public class HomeController : Controller
    {
        // Action for the main dashboard or homepage
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Contractor Claims Management System.";
            return View();
        }

        // Action for displaying general information about the app
        public ActionResult About()
        {
            ViewBag.Message = "This application is designed to manage contractor claims efficiently.";
            return View();
        }

        // Action for displaying the contact page with a contact form
        public ActionResult Contact()
        {
            ViewBag.Message = "If you have any questions, feel free to reach out to us.";
            return View();
        }

        // Action for submitting a claim (for lecturers)
        [Authorize(Roles = "Lecturer")]
        public ActionResult SubmitClaim()
        {
            // Logic for submitting a new claim will go here
            ViewBag.Message = "Submit your claim by filling out the form below.";
            return View();
        }

        // Action for approving claims (for program coordinators and academic managers)
        [Authorize(Roles = "ProgramCoordinator, AcademicManager")]
        public ActionResult ApproveClaims()
        {
            // Logic for approving/rejecting claims will go here
            ViewBag.Message = "Review pending claims for approval or rejection.";
            return View();
        }

        // Action for tracking claims (for lecturers and coordinators/managers)
        [Authorize(Roles = "Lecturer, ProgramCoordinator, AcademicManager")]
        public ActionResult TrackClaims()
        {
            // Logic for tracking the status of claims
            ViewBag.Message = "Track the status of your submitted claims.";
            return View();
        }
    }
}
