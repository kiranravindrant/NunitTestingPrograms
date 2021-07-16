using System;

namespace MonthlyPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            double p, r;

            Console.Write("Enter years 'Y' : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter principal loan amount 'P' : ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Enter percent interest compounded monthly 'R' : ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("The monthly Payment would be: "+EMI.MonthlyPay(y, p, r)+" Rupees");  //passing arguments 
                                                                                                    //to method.





        }
    }
}
