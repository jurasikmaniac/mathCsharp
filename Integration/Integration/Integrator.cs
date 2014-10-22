using info.lundin.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Integration
{
    public class Integrator
    {
        public Integrator() 
        { 

        }
        public double TropezWithAnEpsilon(string Func, double a, double b, double epsilon)
        {
            int n = 1;
            ResultAndError rae = TropezRunge(Func, a, b, n);
            double prevError = rae.error;
            while (rae.error>epsilon)
            {
                n*=2;
                rae = TropezRunge(Func, a, b, n);
                if (rae.error>=prevError)
                {
                    return Double.NaN;
                }
                prevError = rae.error;
            }
            return rae.result;
        }
        public ResultAndError TropezRunge(string Func, double a, double b, int n)
        {
            double r1 = Tropez(Func, a, b, n);
            double r2 = Tropez(Func, a, b, n*2);
            return new ResultAndError(r1, Math.Abs(r2 - r1) / 3d);
        }
        public double Tropez(string Func, double a, double b, int n)
        {
            double result = 0d;
            double step = (b - a) / n;
            double x = a+step;
            for (int i = 1; i < n; i++)
            {
                result += Function(x, Func);
                x += step;
             
            }
            return (2.0 * result + Function(a, Func) + Function(b, Func)) * step / 2.0;

        }
        
        public double Rectangle(string func, double a, double b, int n)
        {
            double result, h;
            int i;
            

            h = (b - a) / n; //Шаг сетки
            result = 0;

            for (i = 1; i < n; i++)
            {
                result += Function(a + h * i - h / 2, func); //Вычисляем в средней точке и добавляем в сумму
            }
            //Parallel.For<double>(1, n-1, () => 0.0, (j, loop, subtotal) =>
            //{
            //    subtotal += Function(a + h * j - h / 2, func);
            //    return subtotal;
            //},
            //(x) => Add(ref result, x)
            //);
            
            result *= h;

            return result;
        }
        public double Simp(string func, double a, double b, int n)
        {
            double x, h, s;           

            h = (b - a) / n;
            s = 0; x = a + h;
            while (x < b)
            {
                s = s + 4 * Function(x,func);
                x = x + h;
                s = s + 2 * Function(x, func); ;
                x = x + h;
            }
            s = h / 3 * (s + Function(a,func) - Function(b,func));
            return s;
        }

        public static double Add(ref double location1, double value)
        {
            double newCurrentValue = 0;
            while (true)
            {
                double currentValue = newCurrentValue;
                double newValue = currentValue + value;
                newCurrentValue = Interlocked.CompareExchange(ref location1, newValue, currentValue);
                if (newCurrentValue == currentValue)
                    return newValue;
            }
        }

        public static double Function(double x, string func)
        {
            ExpressionParser parser = new ExpressionParser();

            // Create value instances
            DoubleValue xval = new DoubleValue();
            xval.Value = x;
            // Add values for variables x and y
            parser.Values.Add("x", xval);
            return parser.Parse(func);
        }

    }
}