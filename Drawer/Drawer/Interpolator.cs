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
    }
}
