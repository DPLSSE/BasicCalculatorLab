using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int tF = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the relative humidity");
            int RH = int.Parse(Console.ReadLine());

            int sum = tF-(9)*(100- RH)/25;

            Console.WriteLine("The dewpoint is " + sum);

            Console.WriteLine("Enter the wind speed");
            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74
                + (0.6125 * tF)
                - 35.75 * Math.Pow(windSpeed, 0.16)
                + 0.4275 * tF * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);

        

           
        }
    }
}
