using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Department
    {
        public int EmployeeLimit { get; set; }

        List<Employee> Employees = new List<Employee>();
        private delegate bool _Predicate<in T>(T obj);

        Predicate<Employee> predicate = IsExistsEmployee();

        private static Predicate<Employee> IsExistsEmployee()
        {
            throw new NotImplementedException();
        }

    }
}
