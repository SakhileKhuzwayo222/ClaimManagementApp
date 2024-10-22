using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimManagementApp
{
    public class LoginViewModel
    {
        public string Username { get; internal set; }

        public string Password { get; internal set; } // Added Password property
    }
}
}