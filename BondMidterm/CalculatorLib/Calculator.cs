using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public double Add(double a, double b)
        {//Addition
            return a + b;
        }

        public double Sub(double a, double b)
        {//Subtraction
            return a - b;
        }

        public double Mul(double a, double b)
        {//Multiplication
            return a * b;
        }

        public double Div(double a, double b)
        {//Division
            return a / b;
        }

        public double Mean(double[] arr)
        {//This finds the mean of an array of doubles
            double total = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                total = Add(total, arr[i]);
            }
            return total / arr.Length;
        }

        public double Median(double[] arr)
        {//This finds the median of an array of doubles after it is sorted
            arr = Sort(arr);
            if(arr.Length%2==0)
            {//If arr is even, the mean of the middle values is returned
                return (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
            }
            else
            {
                return arr[arr.Length / 2];
            }
        }

        private double[] Sort(double[] arr)
        {//This is a selection sort
           double temp;
           for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
