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

namespace MathParserUnitTests
{
    /// <summary>
    /// Tests evaluation of constants such as PI, Euler, True, False
    /// </summary>
    [TestClass]
    public class ConstantTests
    {
        ExpressionParser parser;

        [TestInitialize]
        public void Initialize()
        {
             parser = new ExpressionParser();
        }
        [TestMethod]
        public void Parser_Euler_MathE()
        {
            Assert.AreEqual(Math.E , parser.Parse("euler"));
        }
        [TestMethod]
        public void Parser_PI_MathPI()
        {
            Assert.AreEqual(Math.PI , parser.Parse("pi"));
        }
        [TestMethod]
        public void Parser_NaN_DoubleNaN()
        {
            Assert.AreEqual(Double.NaN , parser.Parse("nan"));
        }
        [TestMethod]
        public void Parser_Infinity_DoublePositiveInfinity()
        {
            Assert.AreEqual(Double.PositiveInfinity , parser.Parse("infinity"));
        }
        [TestMethod]
        public void Parser_True_1()
        {
            Assert.AreEqual(1 , parser.Parse("true"));
        }
        [TestMethod]
        public void Parser_False_0()
        {
            Assert.AreEqual(0, parser.Parse("false"));
        }
    }
}
