using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    class Tconverter
    {
        public static double ConvertTo(int option)
        {
            double value;
            double result = 0;

            switch (option)
            { 
                case 1: Console.WriteLine("Enter value in Celsius");
                    value=Convert.ToDouble(Console.ReadLine());
                    result = value * (9 / 5) + 32;
                    break;

                case 2: Console.WriteLine("Enter value in Fahrenhiet ");
                    value = Convert.ToDouble(Console.ReadLine());
                    result = (value - 32) * (5 / 9);
                    break;


            }
            return result;













        }


    }
}


        
