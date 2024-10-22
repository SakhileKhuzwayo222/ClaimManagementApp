using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ClaimManagementApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Default route for the Account controller
            routes.MapRoute(
                name: "Account",
                url: "Account/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            // Route for the Dashboard
            routes.MapRoute(
                name: "Dashboard",
                url: "Dashboard/{action}/{id}",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );

            // Additional routes for other controllers as needed
            // Route for Claims Management (example)
            routes.MapRoute(
                name: "Claims",
                url: "Claims/{action}/{id}",
                defaults: new { controller = "Claims", action = "Index", id = UrlParameter.Optional }
            );

            // Route for Users Management (example)
            routes.MapRoute(
                name: "Users",
                url: "Users/{action}/{id}",
                defaults: new { controller = "Users", action = "Index", id = UrlParameter.Optional }
            );

            // Route for Courses Management (example)
            routes.MapRoute(
                name: "Courses",
                url: "Courses/{action}/{id}",
                defaults: new { controller = "Courses", action = "Index", id = UrlParameter.Optional }
            );

            // Route for Lecturers Management (example)
            routes.MapRoute(
                name: "Lecturers",
                url: "Lecturers/{action}/{id}",
                defaults: new { controller = "Lecturers", action = "Index", id = UrlParameter.Optional }
            );

            // Catch-all route (optional) - fallback route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
