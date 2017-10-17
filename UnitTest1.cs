using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGenerator
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void input_knife_should_return_TheKnife()
        {
            AssertBandNameGeneratorShouldBe("The Knife", "knife");
        }

        [TestMethod]
        public void input_tart_should_return_TheKnife()
        {
            AssertBandNameGeneratorShouldBe("Tartart", "tart");
        }

        [TestMethod]
        public void input_sandles_should_return_Sandlesandles()
        {
            AssertBandNameGeneratorShouldBe("Sandlesandles", "sandles");
        }

        [TestMethod]
        public void input_bed_should_return_TheBed()
        {
            AssertBandNameGeneratorShouldBe("The Bed", "bed");
        }

        private static void AssertBandNameGeneratorShouldBe(string expected, string str)
        {
            var kata = new Kata();
            var actual = kata.BandNameGenerator(str);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string BandNameGenerator(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            return str.First() == str.Last() ? CapitalizeFirstLetterOfString(str) + str.Substring(1) : "The " + CapitalizeFirstLetterOfString(str);
        }

        private string CapitalizeFirstLetterOfString(string str)
        {
            return str.ToUpper().First() + str.Substring(1) ;
        }

    }
}
