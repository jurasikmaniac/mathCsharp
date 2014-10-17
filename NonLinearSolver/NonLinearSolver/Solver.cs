using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearSolver
{
    /// <summary>
    /// Наикрутейший класс, содержащий целых три метода поиска приближенных корней линейных уравнений
    /// </summary>
    public static class Solver
    {
        //интервал для приближенного вычисления производной
        private const double h = 0.01;
        /// <summary>
        /// Метод бисекции
        /// </summary>
        /// <param name="function">Функция</param>
        /// <param name="xl">Левая граница интервала</param>
        /// <param name="xr">Правая граница интервала</param>
        /// <param name="epsilon">Точность</param>
        /// <returns>Приближенный корень</returns>
        public static double bisectionMethod(iFunction function, double xl, double xr, double epsilon)
        {
            //double xd = 0;
            //double fxl = function.getValueInX(xl);
            //double fxr = function.getValueInX(xr);

            //while ((Math.Abs(fxr - fxl) > epsilon)&&(function.getValueInX(xd)!=0D))
            //{
            //    xd = (xr + xl) / 2;

            //    if (Math.Sign(function.getValueInX(xl)) != Math.Sign(function.getValueInX(xd)))
            //        xr = xd;
            //    else
            //        xl = xd;

            //    fxl = function.getValueInX(xl);
            //    fxr = function.getValueInX(xr);
            //}

            //return xd;
            int j = 0;
            double xm;
            double y = Math.Abs(xl - xr);
            while (y > epsilon)
            {
               
                xm = (xl + xr) / 2;
                if (function.getValueInX(xl) * function.getValueInX(xm) > 0)
                    xl = xm;
                else
                    xr = xm;
                y = Math.Abs(xl - xr);
            }
            return xr;
        }
        /// <summary>
        /// Метод хорд
        /// </summary>
        /// <param name="function">Функция</param>
        /// <param name="xl">Левая граница интервала</param>
        /// <param name="xr">Правая граница интервала</param>
        /// <param name="epsilon">Точность</param>
        /// <returns>Приближенный корень</returns>
        public static double hordMethod(iFunction function, double xl, double xr, double epsilon)
        {
            //double fxl = function.getValueInX(xl);
            //double fxr = function.getValueInX(xr);
            //while ((Math.Abs(fxr - fxl) > epsilon)&&(function.getValueInX(xr)>epsilon))
            //{
            //    xl = xr - (xr - xl) * fxr / (fxr - fxl);                
            //    xr = xl - (xl - xr) * fxl / (fxl - fxr);
            //    fxl = function.getValueInX(xl);
            //    fxr = function.getValueInX(xr);
            //}

            //return xr;
            double xlast;
            double x = 0;
                 
            do
            {
                xlast = x;
                x = xr - function.getValueInX(xr) * (xr - xl) / (function.getValueInX(xr) - function.getValueInX(xl));
                if (function.getValueInX(x) * function.getValueInX(xl) > 0)
                    xl = x;
                else
                    xr = x;
                
            }
            while (Math.Abs(x - xlast) > epsilon);
            
            return x;
        }
        /// <summary>
        /// Метод Ньютона
        /// </summary>
        /// <param name="function">Функция</param>
        /// <param name="xl">Левая граница интервала</param>
        /// <param name="xr">Правая граница интервала</param>
        /// <param name="epsilon">Точность</param>
        /// <returns>Приближенный корень</returns>
        public static double newtonMethod(iFunction function, double xl, double xr, double epsilon)
        {
            double x0 = (xl + xr) / 2;
            double x1 = x0 - (function.getValueInX(x0) / derivative(function, x0));
            while ((Math.Abs(x1 - x0) > epsilon)&&(function.getValueInX(x1)!=0D))
            {
                x0 = x1;
                x1 = x0 - (function.getValueInX(x0) / derivative(function, x0));
            }
            return x1;
        }

        /// <summary>
        /// Вычисление производной
        /// </summary>
        /// <param name="function">Функция</param>
        /// <param name="x">Точка, в которой нужно вычислить производную</param>
        /// <returns></returns>
        private static double derivative(iFunction function, double x)
        {
            return (function.getValueInX(x + h) + function.getValueInX(x - h)) / (2 * h);
        }

        public static double NewtonMethod(iFunction Fr, double x,double x2, double d)
        {
            int t = 0;
            double x1, y;
            x = (x + x2) / 2;
            do
            {
                t++;
                x1 = x - Fr.getValueInX(x) / Fr1(x, d,Fr);
                x = x1;
                y = Fr.getValueInX(x);
            }
            while (Math.Abs(y) >= d);
            return x;
        }
        /// <summary>
        /// Description Fr1
        /// </summary>
        /// <param name="x">Initial value</param>
        /// <param name="d">Amount divisions of segment</param>
        /// <param name="Fr">Function to be solved delegate</param>
        public static double Fr1(double x, double d, iFunction Fr)
        {
            return (Fr.getValueInX(x + d) - Fr.getValueInX(x)) / d;
        }

    }
}