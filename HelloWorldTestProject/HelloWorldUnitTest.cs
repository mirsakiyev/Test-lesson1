using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            // Arrange
            string expectedResult = "Hello World";
            // Act
            string result = test.Program.HelloWorldToConsole();
            // Asert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
