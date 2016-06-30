using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneASP.Tests
{
  [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = 10;

            Assert.AreEqual(6, x);
        }
    }
}
