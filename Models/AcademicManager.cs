using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ClaimManagementApp.Models
{
    public class AcademicManager
    {
        // Properties
        public int ManagerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } // Unique email for each manager

        // Constructor
        public AcademicManager(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // CRUD Operations (methods would typically call a repository)

        public void CreateManager()
        {
            // Logic to create the academic manager in the database
        }

        public static AcademicManager ReadManager(int managerID)
        {
            // Logic to read the academic manager from the database
            // Example return statement (this would actually query the database)
            return new AcademicManager("Jane", "Smith", "jane.smith@example.com")
            {
                ManagerID = managerID
            };
        }

        public void UpdateManager()
        {
            // Logic to update the academic manager in the database
        }

        public void DeleteManager(int managerID)
        {
            // Logic to delete the academic manager from the database
        }
    }
}
