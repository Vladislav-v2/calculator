using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 3, 4)]
        [TestCase(-2, -3, -5)]
        public void TestSumMethod(double numb1, double numb2, double expRes)
        {
            double act = new Calculations().Sum(numb1, numb2);
            Assert.AreEqual(expRes, act);
        }

        [TestCase(9, 3, 3)]
        [TestCase(0, 3, 0)]
        [TestCase(-12, -3, 4)]
        [TestCase(7, 1, 7)]
        public void TestDivMethod(double numb1, double numb2, double expRes)
        {
            double actRes = new Calculations().Division(numb1, numb2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(2, "∞")]
        [TestCase(4, "∞")]
        [TestCase(24, "∞")]
        public void TestDivByZeroMethod(double numb1, string expRes)
        {
            double actRes = new Calculations().Division(numb1, 0);
            Assert.AreEqual(expRes, actRes.ToString());
        }

        [TestCase(9, 3, 6)]
        [TestCase(0, 3, -3)]
        [TestCase(14.6, 2.6, 12.0)]
        [TestCase(136.21, 1.12, 135.09)]
        public void TestDiffMethod(double numb1, double numb2, double expRes)
        {
            double actRes = new Calculations().Diff(numb1, numb2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(-9, 3, -27)]
        [TestCase(0, 3, 0)]
        [TestCase(11.6, 1.5, 17.4)]
        [TestCase(15, -3, -45)]
        public void TestMiltiplyMethod(double numb1, double numb2, double expRes)
        {
            double actRes = new Calculations().Multiply(numb1, numb2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(5, 3, 2)]
        [TestCase(11, 3.5, 0.5)]
        [TestCase(6, 8.2, 6)]
        [TestCase(9, 6.0, 3.0)]
        public void TestModMEthod(double numb1, double numb2, double expRes)
        {
            double actRes = new Calculations().Mod(numb1, numb2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(5, "NaN")]
        [TestCase(-4.57, "NaN")]
        [TestCase(0, "NaN")]
        public void TestModByZeroMEthod(double numb1, string expRes)
        {
            double actRes = new Calculations().Mod(numb1, 0);
            Assert.AreEqual(expRes, actRes.ToString());
        }

    }
}