using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testUnit;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static void TestCosH()
        {
            // Arrange

            // Act
            // Assert
            Assert.AreEqual(testUnit.Program.cosh(1), Math.Cosh(1), 0.001);
        }
    }
}
