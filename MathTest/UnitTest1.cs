using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using MyMathNew;


namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {
        private MyMath m = new MyMath();

        [TestMethod]
        public void Add()
        {
            Assert.IsTrue(m.Add(2,3).Equals(5));
        }

        [TestMethod]
        public void Negative()
        {
            Assert.IsTrue(m.Add(-2, -3).Equals(-5));
        }

        [TestMethod]
        public void Divide()
        {
            Assert.IsTrue(m.Divide(10, 5).Equals(2));
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.IsTrue(m.Multiply(10, 5).Equals(50));
        }
    }
}
