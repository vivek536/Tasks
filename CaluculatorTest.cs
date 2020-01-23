using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Caluculator.Test
{
    [TestClass]
    public class CaluculatorTest
    {
         /// <summary>
         /// It contains test case for add method
         /// </summary>
        [TestMethod]
        public void Test_Add()
        {
            //Arrange
            int expected = 10;
            int a = 4;
            int b = 6;
            int actual = Caluculator.Library.Caluculator.Add(a, b);
            Assert.AreEqual(expected, actual);
           
        }
        /// <summary>
        /// It contains test case for subract method
        /// </summary>
        [TestMethod]
        public void Test_Subract()
        {
            //Arrange
            int expected =-2;
            int a = 4;
            int b = 6;
            int actual = Caluculator.Library.Caluculator.Subract(a, b);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// It contains test case for multiply method
        /// </summary>
        [TestMethod]
        public void Test_Multiply()
        {
            //Arrange
            int expected =24;
            int a = 4;
            int b = 6;
            int actual = Caluculator.Library.Caluculator.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// It contains test case for divide method
        /// </summary>
        [TestMethod]
        public void Test_Divide()
        {
            //Arrange
            int expected =0;
            int a = 4;
            int b = 6;
            int actual = Caluculator.Library.Caluculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// It contains test case for add  method when it throws exception
        /// </summary>
        [TestMethod]
        public void Test_Add_Exception()
        {
            //Arrange
            //int expected = 10;
            int a = int.MaxValue;
            int b = 1;
            //int actual = Caluculator.Library.Caluculator.Add(a, b);
            //Assert.AreEqual(expected, actual);
           Assert.ThrowsException<System.OverflowException>(() => Caluculator.Library.Caluculator.Add(a,b));
        }
        /// <summary>
        /// It contains test case for subract  method when it throws exception
        /// </summary>
        [TestMethod]
        public void Test_Subract_Exception()
        {
            //Arrange
            //int expected = 10;
            int a = int.MaxValue;
            int b =-1;
            //int actual = Caluculator.Library.Caluculator.Add(a, b);
            //Assert.AreEqual(expected, actual);
            Assert.ThrowsException<System.OverflowException>(() => Caluculator.Library.Caluculator.Subract(a, b));
        }
        /// <summary>
        /// It contains test case for multiply  method when it throws exception
        /// </summary>
        [TestMethod]
        public void Test_Multiply_Exception()
        {
            //Arrange
            //int expected = 10;
            int a = int.MaxValue;
            int b = 2;
            //int actual = Caluculator.Library.Caluculator.Add(a, b);
            //Assert.AreEqual(expected, actual);
            Assert.ThrowsException<System.OverflowException>(() => Caluculator.Library.Caluculator.Add(a, b));
        }
        /// <summary>
        /// It contains test case for divide  method when it throws exception
        /// </summary>
        [TestMethod]
        public void Test_Divide_Exception()
        {
            //Arrange
            //int expected = 10;
            int a = int.MaxValue;
            int b = 0;
            //int actual = Caluculator.Library.Caluculator.Add(a, b);
            //Assert.AreEqual(expected, actual);
            Assert.ThrowsException<System.DivideByZeroException>(() => Caluculator.Library.Caluculator.Add(a, b));
        }
    }
}
