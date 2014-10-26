/*
 * Author: Patrik Lundin, patrik@lundin.info
 * Web: http://www.lundin.info
 * 
 * Source code released under the Microsoft Public License (Ms-PL) 
 * http://www.microsoft.com/en-us/openness/licenses.aspx#MPL
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using info.lundin.math;
using System.IO;

namespace MathParserUnitTests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void Serialize_Deserialize_Evaluate_38()
        {
            ExpressionParser parser = new ExpressionParser();

            string func = "x+y+z";
            double expected = 38;

            // Values
            parser.Values.Add("x", 5);
            parser.Values.Add("y", 10);
            parser.Values.Add("z", 23);

            // Parse
            double value = parser.Parse(func);
            Assert.AreEqual(expected, value);
            
            // Get expression
            Expression expression = parser.Expressions[func];

            MemoryStream stream = new MemoryStream();

            // Serialize
            expression.Save(stream);

            stream.Flush();
            stream.Position = 0;

            // Deserialize
            expression = new Expression();
            expression.Load(stream);

            value = parser.EvalExpression(expression);
            Assert.AreEqual(expected, value);
        }
    }
}
