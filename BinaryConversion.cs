using System;
using System.Collections.Generic;
using System.Text;

namespace ToBinary
{
    class BinaryConversion
    {
        public static void ToBinary(int n)
        {
            int[] binvalue = new int[n];
            int i=0;

            while (n > 0)
            {
                binvalue[i] = (n % 2);
                n = n / 2;
                i++;
              
            }
            #region                                                     //for printing in reverse order, 
            Console.WriteLine("The binary Equivalent is ");                                                         //as binary code is the opposite order of remainders obtained                                            
            for (int k=i-1;k >=0; k--)
            {
                Console.Write(+binvalue[k]);
            }


            #endregion                                                      

 
        } 


    }



}
