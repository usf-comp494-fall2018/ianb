using EmployeeLib;
using System;

namespace EmployeeApp
{
    class EmployeeApp
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                FirstName = "Wilhelm",
                LastName = "Hohenzollern",
                DateHired = new DateTime(1918, 11, 9),
                EmployeeCode = "G1888"
            };
            SalariedEmployee emp2 = new SalariedEmployee
            {
                FirstName = "Nicholas",
                LastName = "Romanov",
                DateHired = new DateTime(1917, 3, 2),
                EmployeeCode = "R1896"
            };
            emp2.AnnualSal = 186_856;
            PartTimeEmployee emp3 = new PartTimeEmployee
            {
                FirstName = "Charles",
                LastName = "Habsburg",
                DateHired = new DateTime(1918, 11, 11),
                EmployeeCode = "A1916"
            };
            emp3.HourlyRate = 18.87;

            Console.WriteLine("Displaying emp1");
            emp1.WriteToConsole();

            Console.WriteLine("\nDisplying emp2");
            emp2.WriteToConsole();

            Console.WriteLine("\nDisplaying emp3");
            emp3.WriteToConsole();
        }
    }
}
