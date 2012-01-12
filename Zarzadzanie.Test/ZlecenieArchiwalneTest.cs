using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Zarzadzanie.Test
{
    
    
    /// <summary>
    ///This is a test class for ZlecenieArchiwalneTest and is intended
    ///to contain all ZlecenieArchiwalneTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ZlecenieArchiwalneTest
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
        ///A test for NumerKlienta
        ///</summary>
        [TestMethod()]
        public void NumerKlientaTest()
        {
            LinkedList<string> listaNazwDok = new LinkedList<string>();
            LinkedList<int> listaNumerowTlumaczy = new LinkedList<int>();
            int numerKlienta = 0;
            ZlecenieArchiwalne target = new ZlecenieArchiwalne(listaNazwDok, listaNumerowTlumaczy, numerKlienta);
            Assert.AreEqual(target.NumerKlienta, numerKlienta);
        }

        /// <summary>
        ///A test for ListaNumerowTlumaczyKtorzyTlumaczyli
        ///</summary>
        [TestMethod()]
        public void ListaNumerowTlumaczyKtorzyTlumaczyliTest()
        {
            LinkedList<string> listaNazwDok = new LinkedList<string>();
            LinkedList<int> listaNumerowTlumaczy = new LinkedList<int>();
            int numerKlienta = 0;
            ZlecenieArchiwalne target = new ZlecenieArchiwalne(listaNazwDok, listaNumerowTlumaczy, numerKlienta);
            Assert.AreEqual(target.ListaNumerowTlumaczyKtorzyTlumaczyli, listaNumerowTlumaczy);

        }

        /// <summary>
        ///A test for ListaNazwDokumentow
        ///</summary>
        [TestMethod()]
        public void ListaNazwDokumentowTest()
        {
            LinkedList<string> listaNazwDok = new LinkedList<string>();
            LinkedList<int> listaNumerowTlumaczy = new LinkedList<int>();
            int numerKlienta = 0;
            ZlecenieArchiwalne target = new ZlecenieArchiwalne(listaNazwDok, listaNumerowTlumaczy, numerKlienta);
            Assert.AreEqual(target.ListaNazwDokumentow, listaNazwDok);
            
        }

        /// <summary>
        ///A test for DataRealizacji
        ///</summary>
        [TestMethod()]
        public void DataRealizacjiTest()
        {
            LinkedList<string> listaNazwDok = new LinkedList<string>();
            LinkedList<int> listaNumerowTlumaczy = new LinkedList<int>();
            int numerKlienta = 0;
            ZlecenieArchiwalne target = new ZlecenieArchiwalne(listaNazwDok, listaNumerowTlumaczy, numerKlienta);
            DateTime expected = new DateTime(); 
            DateTime actual;
            target.DataRealizacji = expected;
            actual = target.DataRealizacji;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for ZlecenieArchiwalne Constructor
        ///</summary>
        [TestMethod()]
        public void ZlecenieArchiwalneConstructorTest()
        {
            LinkedList<string> listaNazwDok = new LinkedList<string>(); 
            LinkedList<int> listaNumerowTlumaczy = new LinkedList<int>(); 
            int numerKlienta = 0; 
            ZlecenieArchiwalne target = new ZlecenieArchiwalne(listaNazwDok, listaNumerowTlumaczy, numerKlienta);
            Assert.AreEqual(target.ListaNazwDokumentow, listaNazwDok);
            Assert.AreEqual(target.ListaNumerowTlumaczyKtorzyTlumaczyli,listaNumerowTlumaczy);
            Assert.AreEqual(target.NumerKlienta, numerKlienta);
        }
    }
}
