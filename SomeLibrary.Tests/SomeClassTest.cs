using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SomeLibrary.Tests
{
    [TestClass]
    public class SomeClassTest
    {
        /// <summary>
        /// Unit test for the Normal case of the Random method
        /// </summary>
        [TestMethod]
        public void Unit_Random_Normal()
        {
            SomeClass target = new SomeClass();

            int actual = target.Random();
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }
    }
}
