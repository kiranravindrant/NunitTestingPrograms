using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {  int m, d, y;

            Console.Write("Enter month [ 1-12 :: Jan-Dec ] ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year in yyyy format: ");
            y = Convert.ToInt32(Console.ReadLine());


            DayOfWeek.DaysOfWeek(m,d,y);       //calling & Passing arguments m,d,y to the method.
            
            
            
           
        }
    }
}
