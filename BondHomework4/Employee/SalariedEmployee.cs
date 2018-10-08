using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib
{
    public class SalariedEmployee : Employee
    {
        public override void WriteToConsole()
        {
            Console.WriteLine($"Name: {LastName}, {FirstName}\tEmployee Code: {EmployeeCode}\tAnnual Salary: {AnnualSal:C}");
        }

        public int AnnualSal { get; set; }
    }
}
