using System;
using System.IO;

namespace CalcConsoleApp
{
    class CalcConsoleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Looking for CalcInput.txt.");

            if (!(File.Exists("CalcInput.txt")))
            {//Terminates the program if CalcInput.txt does not exist.
                Console.WriteLine("CalcInput.txt could not be found.");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Opening CalcInput.txt and reading in values.");
            StreamReader textReader = File.OpenText("CalcInput.txt");
            //This program will only read in up to 100 lines
            double[] arr = new double[100];
            int count = 0;
            while(!textReader.EndOfStream)
            {
                try
                {//This try catch block converts each line to a double
                    arr[count] = Convert.ToDouble(textReader.ReadLine());
                }
                catch(Exception ex)
                {//If the line cannot be converted, the program terminates.
                    Console.WriteLine($"{ex.GetType()} cannot be converted to a double. Terminating program.");
                    System.Environment.Exit(1);
                }
                count++;
            }
            textReader.Close();
            Array.Resize<double>(ref arr, count);

            var calc = new CalculatorLib.Calculator();

            //Any file called "CalcOutput.txt" will be overwritten by this program.
            StreamWriter textWriter = File.CreateText("CalcOutput.txt");
            textWriter.WriteLine("The following array of doubles \"arr\" was read in: ");
            for (int i = 0; i < arr.Length; i++)
            {
                textWriter.Write($"{arr[i]}\t");
            }

            textWriter.WriteLine();
            textWriter.WriteLine();

            Console.WriteLine("Finding the mean.");
            textWriter.WriteLine($"The mean of arr is {Math.Round(calc.Mean(arr),2)}");
            textWriter.WriteLine();

            Console.WriteLine("Finding the median.");
            textWriter.WriteLine($"The median of arr is {calc.Median(arr)}");
            textWriter.Close();
            Console.WriteLine("Please see CalcOutput.txt for mean and median.");
        }
    }
}
