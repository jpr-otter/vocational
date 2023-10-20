using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace schule
{
    internal class Calculator 

    {
        public Calculator() { }
        
        public static double Mul(double x, double y)
        {
            return x * y;
        }
        public static double Div(double x, double y)
        {
            return x / y;
        }
        public static int Fac(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
