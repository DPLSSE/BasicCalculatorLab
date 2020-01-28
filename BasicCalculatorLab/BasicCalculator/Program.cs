using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Degrees Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative Humidity");
            int secondNumber = int.Parse(Console.ReadLine());

            decimal sum=firstNumber-9*(100-secondNumber)/25;
            
            Console.WriteLine("The Dew Point is "+sum);

            Console.WriteLine("Enter The Wind Speed");

            int thirdNumber = int.Parse(Console.ReadLine());

           Double sum2 = 35.74 + .6215 * firstNumber - 35.75 * (Math.Pow(thirdNumber,.16)) + .4275 *firstNumber*(Math.Pow(thirdNumber,.16));
          

            Console.WriteLine("The Wind Chill is " + sum2);
        }
    }
}
