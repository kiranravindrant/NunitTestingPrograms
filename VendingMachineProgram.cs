using System;

namespace MoneyVendingMachines
{
    class VendingMachineProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Amount");
            Console.WriteLine("Available Denominations : 1, 2, 5, 10, 50, 100, 500 ,1000 ");
            int amount=Convert.ToInt32(Console.ReadLine());
            FindMinNotes.countCurrency(amount);


        }
    }
}
