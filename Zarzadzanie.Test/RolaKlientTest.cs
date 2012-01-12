using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Zarzadzanie_Uzytkownikami.Tests
{


    /// <summary>
    ///This is a test class for RolaKlientTest and is intended
    ///to contain all RolaKlientTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RolaKlientTest
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
        ///A test for RolaKlient Constructor
        ///</summary>
        [TestMethod()]
        public void RolaKlientConstructorTest()
        {

            RolaKlient target = new RolaKlient();
            Assert.IsNotNull(target.Name);
        }

        /// <summary>
        ///A test for PrzegladajHistorieZLecen
        ///</summary>
        [TestMethod()]
        public void PrzegladajHistorieZLecenTest() // bylo testowane 
        {
            RolaKlient target = new RolaKlient();
            LinkedList<ZlecenieArchiwalne> expected = null;
            LinkedList<ZlecenieArchiwalne> actual;
            actual = target.PrzegladajHistorieZLecen();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PrzegladajPostepBiezacychZLecen
        ///</summary>
        [TestMethod()]
        public void PrzegladajPostepBiezacychZLecenTest()
        {
            RolaKlient target = new RolaKlient(); // TODO: Initialize to an appropriate value
            LinkedList<Hashtable> expected = null; // TODO: Initialize to an appropriate value
            LinkedList<Hashtable> actual;
            actual = target.PrzegladajPostepBiezacychZLecen();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ZlozZlecenie
        ///</summary>
        [TestMethod()]
        public void ZlozZlecenieTest()
        {
            RolaKlient target = new RolaKlient(); // TODO: Initialize to an appropriate value
            LinkedList<Dokument> dokumenty = null; // TODO: Initialize to an appropriate value
            DateTime terminUkonczenia = new DateTime(); // TODO: Initialize to an appropriate value
            target.ZlozZlecenie(dokumenty, terminUkonczenia);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ListaZlecenBiezacych
        ///</summary>
        [TestMethod()]
        public void ListaZlecenBiezacychTest()
        {
            RolaKlient target = new RolaKlient(); // TODO: Initialize to an appropriate value
            LinkedList<ZlecenieBiezace> expected = null; // TODO: Initialize to an appropriate value
            LinkedList<ZlecenieBiezace> actual;
            target.ListaZlecenBiezacych = expected;
            actual = target.ListaZlecenBiezacych;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Numer
        ///</summary>
        [TestMethod()]
        public void NumerTest()
        {
            RolaKlient target = new RolaKlient(); // TODO: Initialize to an appropriate value
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
            RolaKlient target = new RolaKlient(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Numerator = expected;
            actual = target.Numerator;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
