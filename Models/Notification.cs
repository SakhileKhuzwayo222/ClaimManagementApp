﻿using System;

namespace ClaimManagementApp.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
        public string UserId { get; set; } // This can be linked to the user who should receive the notification

        // Additional properties can be added as per requirements
    }
}
