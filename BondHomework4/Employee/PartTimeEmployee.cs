using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib
{
    public class PartTimeEmployee : Employee
    {
        public override void WriteToConsole()
        {
            Console.WriteLine($"Name: {LastName}, {FirstName}\tEmployee Code: {EmployeeCode}\tHourly Rate: {HourlyRate:C}");
        }
        public double HourlyRate { get; set; }
    }
}
