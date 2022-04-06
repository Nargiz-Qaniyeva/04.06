using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace ConsoleApp3.Inrerfaces.Models
{
    class Users
    {
        public string  Username { get; set; }
        public string  Email { get; set; }
        public Role   Role { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Username:{Username}-Email:{Email}-Role:{Role}");
        }
        public Users()
        {
            this.Role = Role;
            this.Username = Username;
            this.Email = Email;
        }

    }
}
