using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Runge
{
    //    /// <summary>
    //    /// Реализация метода Ру́нге — Ку́тты для обыкновенного дифференциального уравнения
    //    /// </summary>
    //    public abstract class RungeKutta
    //    {
    //        /// <summary>
    //        /// Текущее время
    //        /// </summary>
    //        public double t;
    //        /// <summary>
    //        /// Искомое решение Y[0] - само решение, Y[i] - i-тая производная решения
    //        /// </summary>
    //        public double[] Y;
    //        /// <summary>
    //        /// Внутренние переменные 
    //        /// </summary>
    //        double[] YY, Y1, Y2, Y3, Y4;
    //        protected double[] FY;
    //        /// <summary>
    //        /// Конструктор
    //        /// </summary>
    //        /// <param name="N">размерность системы</param>
    //        public RungeKutta(uint N)
    //        {
    //            Init(N);
    //        }
    //        /// <summary>
    //        /// Конструктор
    //        /// </summary>
    //        public RungeKutta() { }
    //        /// <summary>
    //        /// Выделение памяти под рабочие массивы
    //        /// </summary>
    //        /// <param name="N">Размерность массивов</param>
    //        protected void Init(uint N)
    //        {
    //            Y = new double[N];
    //            YY = new double[N];
    //            Y1 = new double[N];
    //            Y2 = new double[N];
    //            Y3 = new double[N];
    //            Y4 = new double[N];

    //        }
    //        /// <summary>
    //        /// Установка начальных условий
    //        /// </summary>
    //        /// <param name="t0">Начальное время</param>
    //        /// <param name="Y0">Начальное условие</param>
    //        public void SetInit(double t0, double[] Y0)
    //        {
    //            t = t0;
    //            if (Y == null)
    //                Init((uint)Y0.Length);
    //            for (int i = 0; i < Y.Length; i++)
    //                Y[i] = Y0[i];
    //        }
    //        /// <summary>
    //        /// Расчет правых частей системы
    //        /// </summary>
    //        /// <param name="t">текущее время</param>
    //        /// <param name="Y">вектор решения</param>
    //        /// <returns>правая часть</returns>
    //        abstract public double[] F(double t, double[] Y);
    //        /// <summary>
    //        /// Следующий шаг метода Рунге-Кутта
    //        /// </summary>
    //        /// <param name="dt">текущий шаг по времени (может быть переменным)</param>
    //        public void NextStep(double dt)
    //        {
    //            int i;

    //            if (dt < 0) return;

    //            // рассчитать Y1
    //            Y1 = F(t, Y);

    //            for (i = 0; i < Y1.Length; i++)
    //                Y1[i] = dt*Y1[i];

    //            for (i = 0; i < Y.Length; i++)
    //                YY[i] = Y[i] + Y1[i] / 2.0;

    //            // рассчитать Y2
    //            Y2 = F(t + dt / 2.0, YY);
    //            for (i = 0; i < Y2.Length; i++)
    //                Y2[i] = dt * Y2[i];

    //            for (i = 0; i < Y.Length; i++)
    //                YY[i] = Y[i] + Y2[i]  / 2.0;

    //            // рассчитать Y3
    //            Y3 = F(t + dt / 2.0, YY);
    //            for (i = 0; i < Y3.Length; i++)
    //                Y3[i] = dt * Y3[i];

    //            for (i = 0; i < Y.Length; i++)
    //                YY[i] = Y[i] + Y3[i];

    //            // рассчитать Y4
    //            Y4 = F(t + dt, YY);
    //            for (i = 0; i < Y4.Length; i++)
    //                Y4[i] = dt * Y4[i];

    //            // рассчитать решение на новом шаге
    //            for (i = 0; i < Y.Length; i++)
    //                Y[i] = Y[i] + 1 / 6.0 * (Y1[i] + 2.0 * Y2[i] + 2.0 * Y3[i] + Y4[i]);

    //            // рассчитать текущее время
    //            t = t + dt;

    //        }
    //    }
    //    class TMyRK : RungeKutta
    //    {
    //        public TMyRK(uint N) { Init(N); }

    //        /// <summary>
    //        /// пример математический маятник 
    //        /// y''(t)+y(t)=0
    //        /// </summary>
    //        /// <param name="t">Время</param>
    //        /// <param name="Y">Решение</param>
    //        /// <returns>Правая часть</returns>
    //        public override double[] F(double t, double[] Y)
    //        {
    //            FY = new double[Y.Length];
    //            FY[0] =t + Y[0];
    //            return FY;
    //        }
    //        /// <summary>
    //        /// Пример использования
    //        /// </summary>
    //        static public void Test()
    //        {
    //            // Шаг по времени
    //            double dt = 0.1;
    //            // Объект метода
    //            TMyRK task = new TMyRK(1);
    //            // Определеим начальные условия y(0)=0, y'(0)=1 задачи
    //            double[] Y0 = { 1 };
    //            // Установим начальные условия задачи
    //            task.SetInit(0, Y0);
    //            // решаем до 15 секунд
    //            while (task.t <= 1)
    //            {
    //                Console.WriteLine("Time = {0:F5}; Func = {1:F8};  ", task.t, task.Y[0]); // вывести t, y, y'
    //                // расчитать на следующем шаге, шаг интегрирования 
    //                task.NextStep(dt);
    //            }
    //            Console.ReadLine();
    //        }
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            TMyRK.Test();
    //        }
    //    }
    //}

    public abstract class TRungeKutta
    {
        public int N;
        double t; // текущее время 
        public double[] Y; // искомое решение Y[0] - само решение, Y[i] - i-тая производная решения

        double[] YY, Y1, Y2, Y3, Y4; // внутренние переменные 

        public TRungeKutta(int aN) // aN - размерность системы 
        {
            N = aN; // сохранить размерность системы

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
            if (dt < 0)
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

    public class TMyRK : TRungeKutta
    {
        public TMyRK(int aN) : base(aN) { }

        public override void F(double t, double[] Y, ref double[] FY)
        {
            FY[0] = Y[1];
            FY[1] = t - Y[0] - 2.0 * Y[1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TMyRK RK4 = new TMyRK(2);

            double[] Y0 = { 1, 0 }; // зададим начальные условия y(0)=0, y'(0)=1

            RK4.SetInit(0, Y0);

            while (RK4.GetCurrent() < 1) // решаем до 10
            {
                Console.WriteLine("X = {0:F5}; Y = {1:F8}; ", RK4.GetCurrent(), RK4.Y[0]); // вывести t, y, y'

                RK4.NextStep(0.1); // расчитать на следующем шаге, шаг интегрирования dt=0.01
            }
            Console.ReadLine();
        }
    }
}
