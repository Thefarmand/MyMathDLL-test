using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using MyMathNew;


namespace MathTest
{
    [TestClass]
    public class MyMathUnitTest
    {
        private MyMath m = new MyMath();

        [TestMethod]
        public void AddPLus()
        {
            Assert.IsTrue(m.Add(2,3).Equals(5));
        }

        [TestMethod]
        public void AddPlusMinus()
        {
            Assert.IsTrue(m.Add(-2, 3).Equals(1));
        }

        [TestMethod]
        public void AddNegative()
        {
            Assert.IsTrue(m.Add(-2, -3).Equals(-5));
        }

        [TestMethod]
        public void Divide()
        {
            Assert.IsTrue(m.Divide(10, 5).Equals(2));
        }

        [TestMethod]
        public void DivideNegative()
        {
            Assert.IsTrue(m.Divide(-10, -5).Equals(2));
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.IsTrue(m.Multiply(10, 5).Equals(50));
        }

        [TestMethod]
        public void MultiplyNegative()
        {
            Assert.IsTrue(m.Multiply(-10, 5).Equals(-50));
        }
    }
}
