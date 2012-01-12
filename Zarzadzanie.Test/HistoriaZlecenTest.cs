using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NMock2;

namespace Zarzadzanie_Uzytkownikami.Tests
{

     

    /// <summary>
    ///This is a test class for HistoriaZlecenTest and is intended
    ///to contain all HistoriaZlecenTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HistoriaZlecenTest
    {

        private Mockery mockery;

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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            mockery = new Mockery();
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for HistoriaZlecen Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Zarzadzanie uzytkownikami.exe")]
        public void HistoriaZlecenConstructorTest()
        {
            HistoriaZlecen_Accessor target = new HistoriaZlecen_Accessor();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for GetInstance
        ///</summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            HistoriaZlecen expected = HistoriaZlecen.GetInstance();
            HistoriaZlecen actual = HistoriaZlecen.GetInstance();
            Assert.AreSame(expected, actual);
        }

        /// <summary>
        ///A test for ZwrocRekordyKlienta
        ///</summary>
        [TestMethod()]
        public void ZwrocRekordyKlientaTest()   //Nie przechodzi 
        {
            HistoriaZlecen target = HistoriaZlecen.GetInstance();
            int numerKlienta = 0;
            LinkedList<int> lista = null;
            LinkedList<string> lista2 = null;
            LinkedList<ZlecenieArchiwalne> expected = new LinkedList<ZlecenieArchiwalne>();
            ZlecenieArchiwalne zA = new ZlecenieArchiwalne(lista2, lista, numerKlienta);
            expected.AddFirst(zA);
            target.ListaZlecen = expected;

            LinkedList<ZlecenieArchiwalne> actual = target.ZwrocRekordyKlienta(numerKlienta);
            
            Assert.AreEqual(actual,expected);

        }

        /// <summary>
        ///A test for ListaZlecen
        ///</summary>
        [TestMethod()]
        public void ListaZlecenTest()
        {
            HistoriaZlecen target = HistoriaZlecen.GetInstance();

            LinkedList<ZlecenieArchiwalne> expected = new LinkedList<ZlecenieArchiwalne>();

            target.ListaZlecen = expected;

            LinkedList<ZlecenieArchiwalne> actual = target.ListaZlecen;

            Assert.AreEqual(actual, expected);

        
        }
    }
}
