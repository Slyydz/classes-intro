using System;
using System.Collections.Generic;

namespace classesIntro
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        public void listEmployees()
        {
            foreach (Employee Emp in Employees)
            {
                Console.WriteLine($"{Emp.FirstName} {Emp.LastName} works for {Name} as {Emp.Title} since {CreatedOn}");
            }
        }

        public Company(string companyName, DateTime date)
        {
            Name = companyName;
            CreatedOn = date;
            Employees = new List<Employee>();
        }
    }
}