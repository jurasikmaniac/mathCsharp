using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffApp
{
    public abstract class TRungeKutta
    {
        public int N;
        double t; // текущее время 
        public double[] Y; // искомое решение Y[0] - само решение, Y[i] - i-тая производная решения
        public string func;
        double[] YY, Y1, Y2, Y3, Y4; // внутренние переменные 

        public TRungeKutta(int aN, string f) // aN - размерность системы 
        {
            N = aN; // сохранить размерность системы
            func = f;
            if (N < 1)
            {
                N = -1; // если размерность меньше единицы, то установить флаг ошибки
                return; // и выйти из конструктора
            }

            Y = new double[N]; // создать вектор решения
            YY = new double[N]; // и внутренних решений
            Y1 = new double[N];
            Y2 = new double[N];
            Y3 = new double[N];
            Y4 = new double[N];
        }

        public void SetInit(double t0, double[] Y0) // установить начальные условия.
        {                                           // t0 - начальное время, Y0 - начальное условие
            t = t0;
            int i;
            for (i = 0; i < N; i++)
            {
                Y[i] = Y0[i];
            }
        }

        public double GetCurrent() // вернуть текущее время
        {
            return t;
        }

        public abstract void F(double t, double[] Y, ref double[] FY); // правые части системы.

        public void NextStep(double dt) // следующий шаг метода Рунге-Кутта, dt - шаг по времени (может быть переменным)
        {
            if (dt < 0.0)
            {
                return;
            }

            int i;

            F(t, Y, ref Y1); // расчитать Y1

            for (i = 0; i < N; i++)
            {
                YY[i] = Y[i] + Y1[i] * (dt / 2.0);
            }
            F(t + dt / 2.0, YY, ref Y2); // расчитать Y2

            for (i = 0; i < N; i++)
            {
                YY[i] = Y[i] + Y2[i] * (dt / 2.0);
            }
            F(t + dt / 2.0, YY, ref Y3); // расчитать Y3

            for (i = 0; i < N; i++)
            {
                YY[i] = Y[i] + Y3[i] * dt;
            }
            F(t + dt, YY, ref Y4); // расчитать Y4

            for (i = 0; i < N; i++)
            {
                Y[i] = Y[i] + dt / 6.0 * (Y1[i] + 2.0 * Y2[i] + 2.0 * Y3[i] + Y4[i]); // расчитать решение на новом шаге
            }

            t = t + dt; // увеличить шаг

        }
    }
}
