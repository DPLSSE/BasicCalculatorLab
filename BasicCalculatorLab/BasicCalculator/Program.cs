using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            Console.WriteLine("Enter the Temperature");

            // int.Parse will take a string data type and convert it to an int data type
            int Temperature = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Relative Humidity");
            int Humidity = int.Parse(Console.ReadLine());

            decimal Dewpoint = Temperature - 9 * (100 - Humidity) / 25;

            Console.WriteLine("The Dew Point is " + Dewpoint);

            Console.WriteLine("Enter The Wind Speed");

            int WindSpeed = int.Parse(Console.ReadLine());

            Double WindChill = 35.74 + .6215 * Temperature - 35.75 * (Math.Pow(WindSpeed, .16)) + .4275 * Temperature * (Math.Pow(WindSpeed, .16));


            Console.WriteLine("The Wind Chill is " + WindChill);
        }
    }
}





