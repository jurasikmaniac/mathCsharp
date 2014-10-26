using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffApp
{
    public class ResultRow
    {
        public ResultRow(double X, double[] Y)
        {
            this.X = X;
            this.Y = (double[])Y.Clone();
        }
        public double X { get; set; }
        public double[] Y { get; set; }
        public string[] toStringArray()
        {
            string[] s = new string[Y.Length + 1];
            s[0] = X.ToString();
            for (int i = 0; i < Y.Length; i++)
            {
                s[i + 1] = Y[i].ToString();
            }
            return s;
        }
    }
}
