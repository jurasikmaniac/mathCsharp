using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public class ResultAndError
    {
        public ResultAndError(double result, double error)
        {
            this.result = result;
            this.error = error;
        }
        public double result { get; set; }
        public double error { get; set; }
    }
}
