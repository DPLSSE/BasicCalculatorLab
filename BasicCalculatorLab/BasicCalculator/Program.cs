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
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the relative humidity");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the wind speed");
            int windSpeed = int.Parse(Console.ReadLine());
                
            int dewPoint = temperature - 9 * (100-secondNumber)/25;

            Console.WriteLine("The dew point is " + dewPoint);

            double windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 *temperature * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);
        }
    }
}
