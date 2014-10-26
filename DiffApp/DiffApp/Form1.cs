using info.lundin.math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            valuePanel.Controls.Add(new ValueY("y" + Convert.ToString(valuePanel.Controls.Count)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valuePanel.Controls.Count == 0) return;

            valuePanel.Controls.RemoveAt(valuePanel.Controls.Count - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TMyRK RK4 = new TMyRK(valuePanel.Controls.Count, textBoxFunc.Text);

            double[] Y0 = new double[valuePanel.Controls.Count];

            int count = 0;
            foreach (Control c in valuePanel.Controls)
            {
                ValueY varVal = c as ValueY;

                if (varVal == null) continue;
                if (String.IsNullOrEmpty(varVal.Variable)
                    || String.IsNullOrEmpty(varVal.Value)) continue;

                double val = 0;
                Double.TryParse(varVal.Value, out val);
                Y0[count] = val;
                count++;
            }

            if (Y0.Length == 0)
            {
                return;
            }

            RK4.SetInit(Convert.ToDouble(textBoxA.Text), Y0);

            while (RK4.GetCurrent() < Convert.ToDouble(textBoxB.Text)) // решаем до 10
            {
                Console.WriteLine("X = {0:F5}; Y = {1:F8}; ", RK4.GetCurrent(), RK4.Y[0]); // вывести t, y, y'                
                RK4.NextStep(Convert.ToDouble(textBoxH.Text)); // расчитать на следующем шаге, шаг интегрирования dt=0.01                
            }
            Form result = new ResultForm( ref RK4.Y);            
            result.ShowDialog();
            Console.ReadLine();
        }
    }

    public class TMyRK : TRungeKutta
    {
        public TMyRK(int aN, string f) : base(aN, f) { }

        public override void F(double t, double[] Y, ref double[] FY)
        {
            ExpressionParser oParser = new ExpressionParser();

            oParser.RequireParentheses = true;
            oParser.ImplicitMultiplication = true;
            oParser.Values.Add("x", t);
            for (int i = 0; i < Y.Length; i++)
            {
                oParser.Values.Add("y" + i, Y[i]);
            }

            int count = Y.Length;
            for (int i = 0; i < Y.Length; i++)
            {
                FY[i] = Y[count - 1];
                count--;
            }
            FY[Y.Length-1] = oParser.Parse(func); ;
        }
    }
}
