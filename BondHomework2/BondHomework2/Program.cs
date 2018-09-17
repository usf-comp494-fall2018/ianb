using System;

namespace BondHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {//This informs the user no arguments have been passed.
                Console.WriteLine("string[] args is an empty array.");
                Console.WriteLine("The program will still run, but it needs arguments to be passed to work properly.");
            }
            string[] names = args;
            int iWaldoLocation = -1;
            //^ iWaldoLocation = -1 until Waldo has been found.

            for(int i = 0; i < names.Length; i++)
            {//This loop will run through the entire array even if Waldo has been found.
                if(names[i] == "Waldo")
                {//iWaldoLocation will the last Waldo in the last if there is more than one occurance.
                    iWaldoLocation = i;
                }
            }

            if(iWaldoLocation > -1)
            {//Waldo has been found when iWaldoLocation is no -1.
                Console.WriteLine($"Waldo was found at position {iWaldoLocation}.");
            }
            else
            {
                Console.WriteLine("Waldo could not be found.");
            }
        }
    }
}
