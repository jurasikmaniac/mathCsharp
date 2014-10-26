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
using System.Globalization;

namespace MathParserUnitTests
{
    [TestClass]
    public class OperatorTests
    {
        ExpressionParser parser;
        string currencyDecimalSeparator;
        double delta;

        [TestInitialize]
        public void Initialize()
        {
             parser = new ExpressionParser();
             currencyDecimalSeparator = CultureInfo.InvariantCulture.NumberFormat.CurrencyDecimalSeparator;
             delta = 1.22460635382238E-16;
        }

        [TestMethod]
        public void Parser_PowerOperator_4()
        {
            Assert.AreEqual(4, parser.Parse("2^2"));
        }
        [TestMethod]
        public void Parser_PlusOperator_3()
        {
            Assert.AreEqual(3, parser.Parse("1+2"));
        }
        [TestMethod]
        public void Parser_MinusOperator_3()
        {
            Assert.AreEqual(3, parser.Parse("5-2"));
        }
        [TestMethod]
        public void Parser_DivisionOperator_3()
        {
            Assert.AreEqual(3, parser.Parse("6/2"));
        }
        [TestMethod]
        public void Parser_MultiplicationOperator_6()
        {
            Assert.AreEqual(6, parser.Parse("2*3"));
        }
        [TestMethod]
        public void Parser_CosOperator_NegOne()
        {
            Assert.AreEqual(-1, parser.Parse("cos(pi)"));
        }
        [TestMethod]
        public void Parser_SinOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("sin(pi)"), delta);
        }

        [TestMethod]
        public void Parser_ExpOperator_MathE()
        {
            Assert.AreEqual(Math.E, parser.Parse("exp(1)"));
        }
        [TestMethod]
        public void Parser_LnOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("ln(euler)"));
        }
        [TestMethod]
        public void Parser_TanOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("tan(pi)"), delta);
        }
        [TestMethod]
        public void Parser_AcosOperator_PI()
        {
            Assert.AreEqual(Math.PI, parser.Parse("acos(-1)"));
        }
        [TestMethod]
        public void Parser_AsinOperator_NegPiHalf()
        {
            Assert.AreEqual(-Math.PI/2, parser.Parse("asin(-1)"));
        }
        [TestMethod]
        public void Parser_AtanOperator_PiDiv4()
        {
            Assert.AreEqual(Math.PI/4, parser.Parse("atan(1)"));
        }
        [TestMethod]
        public void Parser_CoshOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("cosh(0)"));
        }
        [TestMethod]
        public void Parser_SinhOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("sinh(0)"));
        }
        [TestMethod]
        public void Parser_TanhOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("tanh(0)"));
        }
        [TestMethod]
        public void Parser_SqrtOperator_2()
        {
            Assert.AreEqual(2, parser.Parse("sqrt(4)"));
        }
        [TestMethod]
        public void Parser_CotanOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("cotan(PI/2)"), delta);
        }
        [TestMethod]
        public void Parser_FpartOperator_OneHalf()
        {
            Assert.AreEqual(0.5, parser.Parse(String.Format("fpart(3{0}5)", currencyDecimalSeparator)));
        }
        [TestMethod]
        public void Parser_AcotanOperator_PiHalf()
        {
            Assert.AreEqual(Math.PI / 2, parser.Parse("acotan(0)"));
        }

        [TestMethod]
        public void Parser_RoundOperator_3()
        {
            Assert.AreEqual(3, parser.Parse(String.Format("round(3{0}3)", currencyDecimalSeparator)));
        }
        [TestMethod]
        public void Parser_CeilOperator_4()
        {
            Assert.AreEqual(4, parser.Parse(String.Format("ceil(3{0}3)", currencyDecimalSeparator)));
        }
        [TestMethod]
        public void Parser_FloorOperator_3()
        {
            Assert.AreEqual(3, parser.Parse(String.Format("floor(3{0}3)", currencyDecimalSeparator)));
        }
        [TestMethod]
        public void Parser_FacOperator_120()
        {
            Assert.AreEqual(120, parser.Parse("fac(5)"));
        }
        [TestMethod]
        public void Parser_SfacOperator_15()
        {
            Assert.AreEqual(15, parser.Parse("sfac(5)"));
        }
        [TestMethod]
        public void Parser_AbsOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("abs(-1)"));
        }
        [TestMethod]
        public void Parser_LogOperator_3()
        {
            Assert.AreEqual(3, parser.Parse("log(1000)"));
        }
        [TestMethod]
        public void Parser_ModuloOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("4%2"));
        }
        [TestMethod]
        public void Parser_LargerThanOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("2>1"));
        }
        [TestMethod]
        public void Parser_LessThanOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("1<2"));
        }
        [TestMethod]
        public void Parser_AndOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("true&&true"));
        }
        [TestMethod]
        public void Parser_EqualsOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("1==1"));
        }
        [TestMethod]
        public void Parser_NotEqualOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("1!=2"));
        }
        [TestMethod]
        public void Parser_OrOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("true||false"));
        }
        [TestMethod]
        public void Parser_NotOperator_0()
        {
            Assert.AreEqual(0, parser.Parse("!true"));
        }
        [TestMethod]
        public void Parser_LargerEqualOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("2>=1"));
        }
        [TestMethod]
        public void Parser_LessEqualOperator_1()
        {
            Assert.AreEqual(1, parser.Parse("1<=2"));
        }
    }
}
