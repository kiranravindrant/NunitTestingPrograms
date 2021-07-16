using System;

namespace SquareRootEpsilonMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double c = double.Parse(Console.ReadLine());
            double t = c;
        
            double epsilon = 1e-15;

            Console.WriteLine("Square root of "+c+" is "+SquareRoot.SqRoot(c, t, epsilon));    //displaying the return value of
                                                                                            //the method Sqroot



        }

    }
}
