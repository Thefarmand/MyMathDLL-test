using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using MyMathNew;


namespace MathTest
{
    [TestClass]
    public class MyMathUnitTest
    {

        //laver et objekt af MyMath klassen, som bruges til test

        private MyMath m = new MyMath();


        /// <summary>
        /// simple add method. takes int parameters
        /// </summary>
        [TestMethod]

        public void AddPLus()
        {
            Assert.IsTrue(m.Add(2,3).Equals(5));
        }

        [TestMethod]

        /// <summary>
        /// Test for negativt og positvt tal
        /// </summary>
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
