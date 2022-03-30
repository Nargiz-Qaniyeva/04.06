using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    abstract class Person
    {
        public int Id { get;  }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public abstract void ShowInfo();
       
        public Person(string name, string surname, int age )
        {
            Id++;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
    }
}
