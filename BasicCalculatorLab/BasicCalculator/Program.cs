using System;

namespace Windchill_and_Dew_Point_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Windchill and Dew Point Calaculator ***");

            Console.WriteLine("Please enter the temperature");

            // int.Parse will take a string data type and convert it to an int data type
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the relative humidity");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the wind speed");
            int thirdNumber = int.Parse(Console.ReadLine());
                
            decimal sum = firstNumber - ((100-secondNumber)/5);

            //decimal sum = 35.74 + 0.6125*firstNumber-35.75*thirdNumber

            Console.WriteLine("The answer is " + sum);
        }
    }
}
