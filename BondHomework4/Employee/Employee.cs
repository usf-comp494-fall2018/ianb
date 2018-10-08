using System;

namespace EmployeeLib
{
    public class Employee
    {
        //Constructor
        public Employee()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateHired = new DateTime();
            EmployeeCode = string.Empty;
        }

        //Display Method
        public virtual void WriteToConsole()
        {
            Console.WriteLine($"Name:{LastName}, {FirstName}\tEmployee Code:{EmployeeCode}\tDate Hired:{DateHired:dd/MM/yyyy}");
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateHired { get; set; }
        public string EmployeeCode { get; set; }
    }
}
