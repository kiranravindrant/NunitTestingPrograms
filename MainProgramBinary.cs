using System;

namespace ToBinary
{
    class MainProgramBinary
    {
        static void Main(string[] args)
        {   
            int n;
            Console.WriteLine("Enter the Number to convert to Binary"  );
            n = Convert.ToInt32(Console.ReadLine());

            BinaryConversion.ToBinary(n);
            
            
            Console.ReadLine();




        }
    }
}
