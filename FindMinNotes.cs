using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyVendingMachines
{
    class FindMinNotes
    {// function to count and
     // print currency notes
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 1000, 500,100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[8];

            // count notes using Greedy approach
            for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];     //to prevent further conditional check,
                                                                     //when we have already got the notes

                }
            }
                Console.WriteLine("Currency Count ->");

            for (int i = 0; i < 8; i++)
            {
                if (noteCounter[i] != 0)
                {

                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);

                }
            }
                

            
        }

        

    }





}

