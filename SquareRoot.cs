using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRootEpsilonMethod
{
    class SquareRoot
    {
        public static double SqRoot(double c,double t, double epsilon)
        {
            
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;

            }


            return t;
        }

    }
}
