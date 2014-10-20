﻿using info.lundin.math;
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
            double x = a+step;
            for (int i = 1; i < n; i++)
            {
                result += Function(x, Func);
                x += step;
             
            }
            return (2.0 * result + Function(a, Func) + Function(b, Func)) * step / 2.0;

        }
        
        public static double Rectangle(string func, double a, double b, int n)
        {
            double result, h;
            int i;
            

            h = (b - a) / n; //Шаг сетки
            result = 0;

            for (i = 1; i <= n; i++)
            {
                result += Function(a + h * i - h / 2,func); //Вычисляем в средней точке и добавляем в сумму
            }
            result *= h;

            return result;
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