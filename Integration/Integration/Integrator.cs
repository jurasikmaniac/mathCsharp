using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public static class Integrator
    {
        public static double Rectangle() 
        {
            return 0;
        }
        public static double Tropez(string Func, double a, double b, int n)
        {
            double result = 0d;
            double step = (b - a) / n;
            double x1 = a;
            double x2 = x1 + step;
            for (int i = 1; i < n; i++)
            {
                
            }
            return result;
        }
    }
}
