using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PrintNameTest
{
    [TestClass]
    public class PrintNameTest
    {
        [TestMethod]
        public void PrintTest()
        {
            // apply the method to test
            string actual = SayHello.PrintName("Katya");
            // assume expected output
            string expected = "Hello, Katya!";

            // assert if actual and expected are equal
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void PrintTestFailed()
        {
            string actual = SayHello.PrintName("Katya");
            // just for testing purposes, assume that the method failed to add the input name
            string expected = "Hello!";

            // when you run the Unit Test from the Visual Studio menu: 
            // TEST -> Windows -> Test Explorer (you will see in the Test Explorer window: Not Run Tests (2)
            // and above it:  Run All, click on Run All
            // and you should get the following results listed under Run All
            // Failed Tests (1)
            // PrintTestFailed
            // Passed Tests (1)
            // PrintTest
            // as we can see, the expected output in the PrintTestFailed
            // checkes if the method has failed to add the inut name
            // it hasn't so the failed test fails
            Assert.AreEqual(expected, actual);
        }
    }
}
