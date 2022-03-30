using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string  Email { get; set; }



        public override void ShowInfo()
        {
            throw new NotImplementedException();

            Console.WriteLine($"Name:{Name}-Surname:{Surname}- Age:{Age}-Id:{Id}- Salary{Salary}-E-mail{Email}");
        }

        public Employee(int salary, string email,string name, string surname, int age):base(name,surname , age)
        {
            this.Salary = Salary;
            this.Email = Email;
        }
    }
}
