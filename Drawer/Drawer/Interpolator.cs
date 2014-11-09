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
            if (points.Count == 0)
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
        public static double Newton(double t, PointPairList points)
        {

            if (points.Count == 0)
            {
                return 0;
            }
            double res = points[0].Y, F, den;
            int i, j, k;
            for (i = 1; i < points.Count; i++)
            {
                F = 0;
                for (j = 0; j <= i; j++)
                {//следующее слагаемое полинома
                    den = 1;
                    //считаем знаменатель разделенной разности
                    for (k = 0; k <= i; k++)
                    {
                        if (k != j) den *= (points[j].X - points[k].X);
                    }
                    //считаем разделенную разность
                    F += points[j].Y / den;
                }
                //домножаем разделенную разность на скобки (x-x[0])...(x-x[i-1])
                for (k = 0; k < i; k++) F *= (t - points[k].X);
                res += F;//полином
            }
            return res;
        }

        public static double NewtonFront(double x, PointPairList points, double step)
        //для равноудаленных узлов
        {
            int n = points.Count;
            if (n < 3) return 0D;
            double[,] mas = new double[n + 2, n + 1];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == 0 && j < n)
                        mas[i, j] = points[j].X;
                    else if (i == 1 && j < n)
                        mas[i, j] = points[j].Y;
                }
            }
            int m = n;
            for (int i = 2; i < n + 2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = mas[i - 1, j + 1] - mas[i - 1, j];
                }
                m--;
            }

            double[] dy0 = new double[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                dy0[i] = mas[i + 1, 0];
            }

            double res = dy0[0];
            double[] xn = new double[n];
            xn[0] = x - mas[0, 0];

            for (int i = 1; i < n; i++)
            {
                double ans = xn[i - 1] * (x - mas[0, i]);
                xn[i] = ans;
                ans = 0;
            }

            int m1 = n + 1;
            int fact = 1;
            for (int i = 1; i < m1; i++)
            {
                fact = fact * i;
                res = res + (dy0[i] * xn[i - 1]) / (fact * Math.Pow(step, i));
            }
            return res;
        }



    }
}
