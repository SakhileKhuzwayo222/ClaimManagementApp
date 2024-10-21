using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClaimManagementApp.Models
{
    public class Account
    {
        // Primary Key
        [Key] // Marks this property as the primary key
        public int AccountID { get; set; }

        // First Name of the user
        [Required(ErrorMessage = "First name is required")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FirstName { get; set; }

        // Last Name of the user
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(100, ErrorMessage = "Last name cannot be longer than 100 characters.")]
        public string LastName { get; set; }

        // Username for the account (can be derived from First Name and Last Name)
        public string Username
        {
            get
            {
                return $"{FirstName}.{LastName}".ToLower(); // Combine first and last names for username
            }
        }

        // Password for the account (store hashed, not plain text in real applications)
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password cannot be longer than 100 characters.")]
        public string PasswordHash { get; set; }

        // Email associated with the account
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        // Role of the user (could be 'Lecturer', 'Coordinator', 'Manager', etc.)
        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        // Additional information related to the user account
        public string Notes { get; set; }
    }
}

