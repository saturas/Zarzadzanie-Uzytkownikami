using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Zarzadzanie.Test
{
    
    
    /// <summary>
    ///This is a test class for RolaTlumaczTest and is intended
    ///to contain all RolaTlumaczTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RolaTlumaczTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RolaTlumacz Constructor
        ///</summary>
        [TestMethod()]
        public void RolaTlumaczConstructorTest()
        {
            RolaTlumacz target = new RolaTlumacz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MeldujPostepPracy
        ///</summary>
        [TestMethod()]
        public void MeldujPostepPracyTest()
        {
            RolaTlumacz target = new RolaTlumacz(); // TODO: Initialize to an appropriate value
            Dokument d = null; // TODO: Initialize to an appropriate value
            target.MeldujPostepPracy(d);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ListaWykonywanychZlecen
        ///</summary>
        [TestMethod()]
        public void ListaWykonywanychZlecenTest()
        {
            RolaTlumacz target = new RolaTlumacz(); // TODO: Initialize to an appropriate value
            LinkedList<ZlecenieBiezace> expected = null; // TODO: Initialize to an appropriate value
            LinkedList<ZlecenieBiezace> actual;
            target.ListaWykonywanychZlecen = expected;
            actual = target.ListaWykonywanychZlecen;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Numer
        ///</summary>
        [TestMethod()]
        public void NumerTest()
        {
            RolaTlumacz target = new RolaTlumacz(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Numer = expected;
            actual = target.Numer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Numerator
        ///</summary>
        [TestMethod()]
        public void NumeratorTest()
        {
            RolaTlumacz target = new RolaTlumacz(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Numerator = expected;
            actual = target.Numerator;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
