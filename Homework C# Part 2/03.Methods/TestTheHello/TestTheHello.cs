using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SayHello;

namespace TestTheHello
{
    [TestClass]
    public class TestTheHello
    {
        [TestMethod]
        public void NotGhoshoPesho()
        {
            string test = SayIt.PrintHello("Pesho");
            Assert.AreEqual("Pesho", test);
        }
    }
}
