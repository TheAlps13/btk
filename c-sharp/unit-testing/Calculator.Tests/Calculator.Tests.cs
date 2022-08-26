using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class Calculator_Tests
    {
        Calculator _calculator;
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("AssemblyInitialize method invoked");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("AssemblyCleanup method invoked");
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("ClassInitialize method invoked");
        }
        
        [TestInitialize]
        public void TestInitialize()
        {
            _calculator = new Calculator();
            Debug.WriteLine("TestInitialize method invoked");
        }
        // TEST NAME: ADD
        // TEST DESCRIPTION: Two parameters should be added
        [TestMethod]
        public void Add()
        {
            int expected = 9;
            int actual = _calculator.Add(4, 5);

            Assert.AreEqual(expected, actual, "The result of adding 4 and 5 must be 9");
        }


        // TEST NAME: Multiply
        // TEST DESCRIPTION: Two paramaters should be multiplied
        [TestMethod]
        public void Multiply()
        {
            int expected = 25;
            int actual = _calculator.Multiply(5, 5);

            Assert.AreEqual(expected , actual);
        }

        // TEST NAME : DivideByZeroException
        // TEST DESCRIPTION: Should throw an aritmetic exception
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroException()
        {
            _calculator.Divide(3, 0);
        }


        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("TestCleanup method invoked");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("ClassCleanup method invoked");
        }
    }
}
