using System.Data.Entity; // Ensure you have the Entity Framework reference
using System.Threading.Tasks;
using ClaimManagementApp.Models; // Namespace for your models

namespace ClaimManagementApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor specifying the connection string name
        // Ensure the connection string name matches the one in your Web.config or appsettings.json
        public ApplicationDbContext()
            : base("ContractorClaimsManagementDB") 
        {
        }

        // Define DbSet properties for your models (tables)
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<ProgramCoordinator> ProgramCoordinators { get; set; }
        public DbSet<AcademicManager> AcademicManagers { get; set; }
        public DbSet<CoordinatorManagerAssignment> CoordinatorManagerAssignments { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Task> Tasks { get; set; }

        // Override the OnModelCreating method to configure model relationships or custom table mapping
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Optional: Customize table names, keys, relationships, etc.

            // Example: Rename a table
            modelBuilder.Entity<Claim>().ToTable("ClaimsTable");

            // Example: Configure a relationship between ProgramCoordinator and CoordinatorManagerAssignment
            modelBuilder.Entity<CoordinatorManagerAssignment>()
                .HasRequired(c => c.ProgramCoordinator)
                .WithMany(p => p.CoordinatorManagerAssignments)
                .HasForeignKey(c => c.ProgramCoordinatorId);

            // Further customization can be added here as needed

            base.OnModelCreating(modelBuilder); // Call base method
        }

        // Optional: You can include asynchronous methods for handling data access (e.g., for CRUD operations)
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}



