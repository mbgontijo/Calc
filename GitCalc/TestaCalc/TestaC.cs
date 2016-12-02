using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitCalc;

namespace TestaCalc
{
    [TestClass]
    public class TestaC
    {
        [TestMethod]
        public void TestSoma()
        {
            Calc c = new Calc();
            int result = c.Soma(3, 4);
            Assert.AreEqual(7, result);
        }
    }
}
