using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary;
namespace Project
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator cal = new SimpleCalculator();
        [SetUp]
        public void setup() 
        {
            double result=cal.GetResult;
        }
        [Test]
        public void Additiontest() 
        {
            double r=cal.Addition(1.00, 2.00);
            Assert.That(Does.Equals(r,3.00),Is.True);
        }
        [Test]
        [TestCase(1,2,2)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 10)]
        public void multiplication(double a,double b,double c) 
        {
            double r = cal.Multiplication(a,b);
            Assert.AreEqual(c,r);
        }

        [Test]
        [TestCase(2, 1, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(10, 2, 8)]
        public void sub(double a, double b, double c)
        {
            double r = cal.Subtraction(a, b);
            Assert.AreEqual(c, r);
        }

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(8, 2, 4)]
        [TestCase(8, 4, 2)]
        public void division(double a,double b,double e) 
        {
            try
            {
                double r = cal.Division(a, b);
                Assert.AreEqual(e, r);
            }
            catch (AssertionException) 
            {
                Assert.Fail("Division by zero");
            }
        }
        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 4)]
        public void TestAddAndClear(double a,double b,double e) 
        {
            double r = cal.Addition(a, b);
            Assert.AreEqual(e, r);
            cal.AllClear();
            Assert.AreEqual(0,cal.GetResult);
        }

        [TearDown]
        public void cleanup() 
        {
            cal.AllClear();
        }
    }
}
