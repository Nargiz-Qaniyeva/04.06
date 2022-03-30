using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Inrerfaces.Models
{
    class Users
    {
        public string  Username { get; set; }
        public string  Email { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Username:{Username}-Email:{Email}");
        }

    }
}
