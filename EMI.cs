using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyPayment
{
    class EMI
    {
        
        public static double MonthlyPay(int y,double p,double r)
        {
            int n;

            n = 12 * y;
            r /= (12 * 100);

            double payment = (p * r) / (1 - Math.Pow((1 + r), (-n)));


            return Math.Round(payment);

        }


    }
}
