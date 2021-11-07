using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SSE_TASK_1
{
    [TestClass]
    public class UnitTest1
    {
      
        public int Multiply(int a, int b) {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divide by zero is not allowed");
                return 0;
            }
            return a / b;
        }

        [TestMethod]
        public void testMutiply()
        {
            Assert.AreEqual(6, Multiply(3, 2));
        }

        [TestMethod]
        public void testDivide()
        {
            Assert.AreEqual(2, Divide(4, 2));
        }

        [TestMethod]
        public void testDivideByZero()
        {
            Assert.AreEqual(0, Divide(4, 0));
        }

    }
}
