using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity; // Ensure you have the Entity Framework reference
using ClaimManagementApp.Models; // Namespace for your models

namespace ClaimManagementApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection") // Use the name of your connection string
        {
        }

        public DbSet<Claim> Claims { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<ProgramCoordinator> ProgramCoordinators { get; set; }
        public DbSet<AcademicManager> AcademicManagers { get; set; }
        public DbSet<CoordinatorManagerAssignment> CoordinatorManagerAssignments { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
