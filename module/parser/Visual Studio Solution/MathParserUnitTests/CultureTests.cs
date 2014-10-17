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
    public class CultureTests
    {
        [TestMethod]
        public void CurrentCulture_Parse_Success()
        {
            CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            
            ExpressionParser parser = new ExpressionParser();
            parser.Culture = culture;

            string decimalSeparator = culture.NumberFormat.NumberDecimalSeparator;

            Assert.AreEqual(3, parser.Parse(String.Format("round(3{0}3)", decimalSeparator)));
        }

        [TestMethod]
        public void AllCultures_Correct_DecimalSeparator_Success()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            ExpressionParser parser = new ExpressionParser();

            foreach(var culture in cultures)
            {
                string decimalSeparator = culture.NumberFormat.NumberDecimalSeparator;

                try
                {
                    parser.Culture = culture;
                }
                catch (ArgumentOutOfRangeException) 
                {  
                    // If unsupported decimal or group separator, see documentation 
                    continue;
                }

                Assert.AreEqual(
                    4300.40, 
                    parser.Parse(String.Format(culture, "3300{0}3+2100{0}2-1100{0}1", decimalSeparator)), 
                    "Failed, Culture " + culture.Name
                );
            }
        }

        [TestMethod]
        public void AllCultures_Correct_GroupSeparator_Success()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            ExpressionParser parser = new ExpressionParser();

            foreach (var culture in cultures)
            {
                string separator = culture.NumberFormat.CurrencyGroupSeparator;

                try
                {
                    parser.Culture = culture;
                }
                catch (ArgumentOutOfRangeException)
                {
                    // If unsupported decimal or group separator, see documentation 
                    continue;
                }

                Assert.AreEqual(
                    2469134,
                    parser.Parse(String.Format(culture, "1{0}234{0}567+1{0}234{0}567", separator)),
                    "Failed, Culture " + culture.EnglishName
                );
            }
        }

        [TestMethod]
        public void AllCultures_Correct_GroupAndDecimalSeparator_Success()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            ExpressionParser parser = new ExpressionParser();

            foreach (var culture in cultures)
            {
                string separator = culture.NumberFormat.CurrencyGroupSeparator;
                string decimalSeparator = culture.NumberFormat.NumberDecimalSeparator;

                // At least one culture uses / for decimal separator, this is not allowed
                // and documented as not allowed.
                if (decimalSeparator == "/") continue;

                // At least one culture uses the same grouping and decimal separator,
                // this is NotFiniteNumberException allowed and documented
                if (separator == decimalSeparator) continue;

                try
                {
                    parser.Culture = culture;
                }
                catch (ArgumentOutOfRangeException)
                {
                    // If unsupported decimal or group separator, see documentation 
                    continue;
                }

                Assert.AreEqual(
                    2469134.46,
                    parser.Parse(String.Format(culture, "1{0}234{0}567{1}23+1{0}234{0}567{1}23", separator, decimalSeparator)),
                    "Failed, Culture " + culture.EnglishName
                );
            }
        }
    }
}
