/*
 * Author: Patrik Lundin, patrik@lundin.info
 * Web: http://www.lundin.info
 * 
 * Source code released under the Microsoft Public License (Ms-PL) 
 * http://www.microsoft.com/en-us/openness/licenses.aspx#MPL
*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using info.lundin.math;
using System.Diagnostics;
using System.Linq;

namespace MathParserTestNS
{
    public partial class MathParserTest : Form
    {
        public MathParserTest()
        {
            InitializeComponent();

            variableValue1.Variable = "x";
            variableValue1.Value = "2";

            variableValue2.Variable = "y";
            variableValue2.Value = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExpressionParser oParser = new ExpressionParser();

            oParser.RequireParentheses = chkParant.Checked;
            oParser.ImplicitMultiplication = chkImplicit.Checked;

            int iIterations = 1000;

            try
            {
                iIterations = Int32.Parse(textBox4.Text.Trim());
            }
            catch 
            {
                textBox4.Text = iIterations.ToString();
            }

            foreach (Control c in valuePanel.Controls)
            {
                VariableValue varVal = c as VariableValue;

                if (varVal == null) continue;
                if (String.IsNullOrEmpty(varVal.Variable)
                    || String.IsNullOrEmpty(varVal.Value)) continue;

                double val = 0;
                if (Double.TryParse(varVal.Value, out val))
                {
                    oParser.Values.Add(varVal.Variable, val);
                }
                else
                {
                    oParser.Values.Add(varVal.Variable, varVal.Value);
                }
            }
            
            string sFunction = textBox1.Text.Trim();
            double fResult = 0f;

            try
            {
                Cursor = Cursors.WaitCursor;
                Stopwatch watch = new Stopwatch();
                watch.Start();

                // Parse expression once
                fResult = oParser.Parse(sFunction);

                // Fetch parsed tree
                Expression expression = oParser.Expressions[sFunction];

                // Iterate and evaluate tree
                for (int i = 0; i < iIterations; i++)
                {
                    fResult = oParser.EvalExpression(expression);
                    //fResult = oParser.Parse(sFunction);
                }

                watch.Stop();

                textBox2.Text = "Result: " + fResult + "\r\n";
                textBox2.Text += "Iterations: " + iIterations + "\r\n";
                textBox2.Text += "Time consumed: " + watch.ElapsedMilliseconds + " milliseconds.\r\n\r\n";

                try
                {
                    Assembly oAssembly = Assembly.LoadFrom("info.lundin.math.dll");
                    textBox2.Text += String.Format("Assembly: {0}\r\n.NET Runtime: {1}", oAssembly.FullName, oAssembly.ImageRuntimeVersion);
                }
                catch { }

            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valuePanel.Controls.Add(new VariableValue());
        }

        private void variableValue1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valuePanel.Controls.Count == 0) return;

            valuePanel.Controls.RemoveAt(valuePanel.Controls.Count - 1);
        }
    }
}
