using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Zarzadzanie.Test
{
    
    
    /// <summary>
    ///This is a test class for ZlecenieBiezaceTest and is intended
    ///to contain all ZlecenieBiezaceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ZlecenieBiezaceTest
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
        ///A test for ZlecenieBiezace Constructor
        ///</summary>
        [TestMethod()]
        public void ZlecenieBiezaceConstructorTest()
        {
            LinkedList<Dokument> dok = null; // TODO: Initialize to an appropriate value
            DateTime data = new DateTime(); // TODO: Initialize to an appropriate value
            int numerKlienta = 0; // TODO: Initialize to an appropriate value
            ZlecenieBiezace target = new ZlecenieBiezace(dok, data, numerKlienta);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Archiwizuj
        ///</summary>
        [TestMethod()]
        public void ArchiwizujTest()
        {
            LinkedList<Dokument> dok = null; // TODO: Initialize to an appropriate value
            DateTime data = new DateTime(); // TODO: Initialize to an appropriate value
            int numerKlienta = 0; // TODO: Initialize to an appropriate value
            ZlecenieBiezace target = new ZlecenieBiezace(dok, data, numerKlienta); // TODO: Initialize to an appropriate value
            target.Archiwizuj();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for StopienRealizacji
        ///</summary>
        [TestMethod()]
        public void StopienRealizacjiTest()
        {
            LinkedList<Dokument> dok = null; // TODO: Initialize to an appropriate value
            DateTime data = new DateTime(); // TODO: Initialize to an appropriate value
            int numerKlienta = 0; // TODO: Initialize to an appropriate value
            ZlecenieBiezace target = new ZlecenieBiezace(dok, data, numerKlienta); // TODO: Initialize to an appropriate value
            Hashtable expected = null; // TODO: Initialize to an appropriate value
            Hashtable actual;
            actual = target.StopienRealizacji();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DokumentyDoPrzetlumaczenia
        ///</summary>
        [TestMethod()]
        public void DokumentyDoPrzetlumaczeniaTest()
        {
            LinkedList<Dokument> dok = null; // TODO: Initialize to an appropriate value
            DateTime data = new DateTime(); // TODO: Initialize to an appropriate value
            int numerKlienta = 0; // TODO: Initialize to an appropriate value
            ZlecenieBiezace target = new ZlecenieBiezace(dok, data, numerKlienta); // TODO: Initialize to an appropriate value
            LinkedList<Dokument> expected = null; // TODO: Initialize to an appropriate value
            LinkedList<Dokument> actual;
            target.DokumentyDoPrzetlumaczenia = expected;
            actual = target.DokumentyDoPrzetlumaczenia;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumerKlienta
        ///</summary>
        [TestMethod()]
        public void NumerKlientaTest()
        {
            LinkedList<Dokument> dok = null; // TODO: Initialize to an appropriate value
            DateTime data = new DateTime(); // TODO: Initialize to an appropriate value
            int numerKlienta = 0; // TODO: Initialize to an appropriate value
            ZlecenieBiezace target = new ZlecenieBiezace(dok, data, numerKlienta); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumerKlienta = expected;
            actual = target.NumerKlienta;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
