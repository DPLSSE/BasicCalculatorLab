using System;

namespace BasicCalculator
{
    class Progeam
    {
        static void Main()
        {
           
            Console.WriteLine("Enter the Temperature in Fahrenheit");
            int Temperature = Int32.Parse(Console.ReadLine());
            const int MyConstant = 50;
            bool TemperatureOverFifty = Temperature > MyConstant;
            if(TemperatureOverFifty)
            {
                Console.WriteLine("Enter the relative humidity:");
                int Humidity = Int32.Parse(Console.ReadLine());
                double HeatIndex = .5 * (Temperature + 61 + ((Temperature-68) * 1.2) + (Humidity * .094)) ; //Heat Equation
                Console.WriteLine("Heat Index Is " + HeatIndex);
            } else
            {
                Console.WriteLine("Enter the Wind Speed");
                int WindSpeed = Int32.Parse(Console.ReadLine());
                Double WindChill = 35.74 + (.6215 * Temperature) - (35.75 * Math.Pow(WindSpeed, .16)) + (.4275 * Temperature * Math.Pow(WindSpeed, .16));
                Console.WriteLine("Wind Chill is " + WindChill);

            }
            
          
        }
    }
}





