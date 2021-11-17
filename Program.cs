using System;

namespace classesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime coleDateTime = new DateTime(1999, 10, 08);
            DateTime compDateTime = new DateTime(2005, 05, 22);
            DateTime cobyDateTime = new DateTime(1974, 11, 12);
            DateTime dwightDateTime = new DateTime(1985, 05, 20);

            // Create an instance of a company. Name it whatever you like.
            Company whateverILike = new Company("Nashville Software School", compDateTime);
            // Create three employees
            Employee Cole = new Employee("Brady", "Williams", "Da Realest", coleDateTime);
            Employee Coby = new Employee("Coby", "Wyan", "Professor Lame", cobyDateTime);
            Employee Dwight = new Employee("Dwight", "Schrute", "Assistant to the Regional Manager", dwightDateTime);
            // Assign the employees to the company
            whateverILike.Employees.Add(Cole);
            whateverILike.Employees.Add(Coby);
            whateverILike.Employees.Add(Dwight);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            whateverILike.listEmployees();
        }
    }
}
