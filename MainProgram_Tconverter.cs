using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("-----Choose the Conversion------");
            Console.WriteLine("1:Celsius to Fahrenheit: ");
            Console.WriteLine("2:Fahrenheit to Celsius: ");
            option=Convert.ToInt32(Console.ReadLine());

      #region
            //for displaying unit correctly
            char u;
            if (option == 2)
            {
                u ='C'; 
            }
            else
            {
                 u= 'F';
            }                          
      #endregion   

            Console.WriteLine("The value in "+ u +"  is "+ Tconverter.ConvertTo(option));
            Console.ReadLine();
            

         
        }


    }
}
