using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimManagementApp.Models
{
    public class ProgramCoordinator
    {
        // Properties
        public int CoordinatorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } // Unique email for each coordinator

        // Constructor
        public ProgramCoordinator(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // CRUD Operations (methods would typically call a repository)

        public void CreateCoordinator()
        {
            // Logic to create the coordinator in the database
        }

        public static ProgramCoordinator ReadCoordinator(int coordinatorID)
        {
            // Logic to read the coordinator from the database
            // Example return statement (this would actually query the database)
            return new ProgramCoordinator("John", "Doe", "john.doe@example.com")
            {
                CoordinatorID = coordinatorID
            };
        }

        public void UpdateCoordinator()
        {
            // Logic to update the coordinator in the database
        }

        public void DeleteCoordinator(int coordinatorID)
        {
            // Logic to delete the coordinator from the database
        }
    }
}
