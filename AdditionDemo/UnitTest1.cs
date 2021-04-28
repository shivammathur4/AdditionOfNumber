using AdditionOfNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdditionDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //Arrange
            Program program = new Program();

            //Act
            int result = program.Add(5, 10);

            //Assert
            Assert.AreEqual(15, result);
        }
    }
}
