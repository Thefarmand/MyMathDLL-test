using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathNew
{
    /// <summary>
    /// basis funktioner for en MyMath-class
    /// </summary>
    public class MyMath
    {
        /// <summary>
        /// plus two int'ergers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// plus Three int'ergers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }


        /// <summary>
        /// minus two int'ergers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Substract(int a, int b)
        {
            return a - b;
        }


        /// <summary>
        /// devides two int'ergers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }



        /// <summary>
        /// Multiplies two int'ergers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}
