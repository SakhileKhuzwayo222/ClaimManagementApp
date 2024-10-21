using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimManagementApp.Models
{
    public class CoordinatorManagerAssignment
    {
        // Properties
        public int AssignmentID { get; set; }
        public int CoordinatorID { get; set; } // Foreign Key to ProgramCoordinator
        public int ManagerID { get; set; } // Foreign Key to AcademicManager

        // Constructor
        public CoordinatorManagerAssignment(int coordinatorID, int managerID)
        {
            CoordinatorID = coordinatorID;
            ManagerID = managerID;
        }

        // CRUD Operations (methods would typically call a repository)

        public void CreateAssignment()
        {
            // Logic to create the coordinator-manager assignment in the database
        }

        public static CoordinatorManagerAssignment ReadAssignment(int assignmentID)
        {
            // Logic to read the assignment from the database
            // Example return statement (this would actually query the database)
            return new CoordinatorManagerAssignment(1, 1)
            {
                AssignmentID = assignmentID
            };
        }

        public void UpdateAssignment()
        {
            // Logic to update the coordinator-manager assignment in the database
        }

        public void DeleteAssignment(int assignmentID)
        {
            // Logic to delete the coordinator-manager assignment from the database
        }
    }
}
