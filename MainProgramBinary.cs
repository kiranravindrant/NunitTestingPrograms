using System;

namespace ToBinary
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n;
            Console.WriteLine("Enter the Number to convert to Binary"  );
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The binary Equivalent is " + BinaryConversion.ToBinary(n));
            
            
            Console.ReadLine();




        }
    }
}
