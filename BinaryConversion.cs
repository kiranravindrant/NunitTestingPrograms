using System;
using System.Collections.Generic;
using System.Text;

namespace ToBinary
{
    class BinaryConversion
    {
        public static string ToBinary(int n)
        { string binvalue=" ";
            int Length;

            while (n >= 1)
            {
              
                int remainder = n % 2;
                n = n / 2;

                binvalue += Convert.ToString(remainder);            //storing the remainders as string

               

            }
                #region                                                        
            string Revbinvalue = " ";                            //to reverse the string as the binary equivalent is opposite

            Length = binvalue.Length - 1;

            while (Length >= 0)                //loops the given string length
            {

                Revbinvalue = Revbinvalue + binvalue[Length];  //performimg a reverse string according to length of given string
                Length--;

            }
            #endregion                                                      

            return Revbinvalue;         //returning the reversed string

          
        } 


    }



}
