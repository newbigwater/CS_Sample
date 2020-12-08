using System;
using AddLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        int a = 10;
        int b = 5;

        int addRet = 15;
        int miRet  = 5;
        int mulRet = 50;
        
        [TestMethod]
        public void TestAdd()
        {
            using (var calc = new AddClass())
            {
                var ret = calc.add(a, b);
                Assert.AreEqual(addRet, ret);
            }
        }

        [TestMethod]
        public void TestMinus()
        {
            using (var calc = new AddClass())
            {
                var ret = calc.minus(a, b);
                Assert.AreEqual(miRet, ret);
            }

        }

        [TestMethod]
        public void TestMultiply()
        {
            using (var calc = new AddClass())
            {
                var ret = calc.Multiply(a, b);
                Assert.AreEqual(mulRet, ret);
            }

        }
    }
}
