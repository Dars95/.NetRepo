using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoGithub.Models
{
    public class Register
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime Created { get; set; }

        = DateTime.Now;

            

        public DateTime Updated { get; set; }
        = DateTime.Now;
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        = string.Empty;
        public string PasswordHash { get; set; }
        = string.Empty;
            
        public string EmailHash { get; set; }
            
        public string PasswordSalt { get; set; }
        public string PasswordSaltHash { get; set;
        
            
        
    }
    }
}