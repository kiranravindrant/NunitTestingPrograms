using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfWeek
{
    class DayOfWeek
    {
        public static void daysOfWeek()
        {
            int m, d, y;

            Console.Write("Enter month [ 1-12 :: Jan-Dec ] ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year in yyyy format: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (m <= 12 && d <= 31 && d != 0)
            {
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;

                switch (d0)
                {
                    case 0:
                        Console.WriteLine(" It's Sunday");
                        break;

                    case 1:
                        Console.WriteLine("It's Monday");
                        break;

                    case 2:
                        Console.WriteLine("It's Tuesday");
                        break;

                    case 3:
                        Console.WriteLine(" It's Wednesday");
                        break;

                    case 4:
                        Console.WriteLine(" It's Thursday");
                        break;

                    case 5:
                        Console.WriteLine(" It's Friday");
                        break;

                    case 6:
                        Console.WriteLine(" It's Saturday");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Invalid Indput");
            }
                    Console.ReadLine();
            



            


        }
    }
}