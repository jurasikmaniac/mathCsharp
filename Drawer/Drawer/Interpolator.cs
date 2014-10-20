using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Drawer
{
    public static class Interpolator
    {
        public static double lagrange(double x, PointPairList points)
        {
            double lagrange_pol = 0;
            double basics_pol;

            for (int i = 0; i < points.Count; i++)
            {
                basics_pol = 1;
                for (int j = 0; j < points.Count; j++)
                {
                    if (j != i)
                    {
                        basics_pol *= (x - points[j].X) / (points[i].X - points[j].X);
                    }
                }
                lagrange_pol += basics_pol * points[i].Y;
            }
            return lagrange_pol;
        }

        public static double NewtonInterpolator(double t, PointPairList points)
        {
            double F, LN, XX, X = 1;
            int i, j, k;
            if (points.Count==0)
            {
                return 0;
            }
            for (i = 1, LN = points[0].Y; i < points.Count; i++)
            {
                X *= (t - points[i - 1].X);
                for (j = 0, F = 0; j <= i; j++)
                {
                    for (k = 0, XX = 1; k <= i; k++)
                    {
                        if (k != j)
                            XX *= points[j].X - points[k].X;
                    }
                    F += points[j].Y / XX;
                }
                LN += X * F;
            }
            return LN;
        }
    }

    

        
        
        
    
}
