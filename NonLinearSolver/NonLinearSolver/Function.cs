using info.lundin.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearSolver
{
    public class Function:iFunction
    {
        private string formula;
        public Function(string formula)
        {
            this.formula = formula;
        }
        public double getValueInX(double x)
        {
            ExpressionParser parser = new ExpressionParser();

            // Create value instances
            DoubleValue xval = new DoubleValue();
            xval.Value = x;
            // Add values for variables x and y
            parser.Values.Add("x", xval);
            return parser.Parse(formula);
        }
    }
}
