using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Zarzadzanie.Test
{
    
    
    /// <summary>
    ///This is a test class for RolaPracownikTest and is intended
    ///to contain all RolaPracownikTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RolaPracownikTest
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
        ///A test for RolaPracownik Constructor
        ///</summary>
        [TestMethod()]
        public void RolaPracownikConstructorTest()
        {
            RolaPracownik target = new RolaPracownik();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ArchiwizujZlecenie
        ///</summary>
        [TestMethod()]
        public void ArchiwizujZlecenieTest()
        {
            RolaPracownik target = new RolaPracownik(); // TODO: Initialize to an appropriate value
            ZlecenieBiezace z = null; // TODO: Initialize to an appropriate value
            target.ArchiwizujZlecenie(z);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DodajZlecenie
        ///</summary>
        [TestMethod()]
        public void DodajZlecenieTest()
        {
            ZlecenieBiezace z = null; // TODO: Initialize to an appropriate value
            RolaKlient k = null; // TODO: Initialize to an appropriate value
            RolaPracownik.DodajZlecenie(z, k);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PrzydzielZlecenie
        ///</summary>
        [TestMethod()]
        public void PrzydzielZlecenieTest()
        {
            RolaPracownik target = new RolaPracownik(); // TODO: Initialize to an appropriate value
            ZlecenieBiezace zlecenie = null; // TODO: Initialize to an appropriate value
            LinkedList<RolaTlumacz> tlumacze = null; // TODO: Initialize to an appropriate value
            target.PrzydzielZlecenie(zlecenie, tlumacze);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ListaTlumaczy
        ///</summary>
        [TestMethod()]
        public void ListaTlumaczyTest()
        {
            RolaPracownik target = new RolaPracownik(); // TODO: Initialize to an appropriate value
            LinkedList<RolaTlumacz> expected = null; // TODO: Initialize to an appropriate value
            LinkedList<RolaTlumacz> actual;
            target.ListaTlumaczy = expected;
            actual = target.ListaTlumaczy;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListaZlecenBiezacychNieprzydzielonych
        ///</summary>
        [TestMethod()]
        public void ListaZlecenBiezacychNieprzydzielonychTest()
        {
            Hashtable expected = null; // TODO: Initialize to an appropriate value
            Hashtable actual;
            RolaPracownik.ListaZlecenBiezacychNieprzydzielonych = expected;
            actual = RolaPracownik.ListaZlecenBiezacychNieprzydzielonych;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListaZlecenBiezacychPrzydzielonych
        ///</summary>
        [TestMethod()]
        public void ListaZlecenBiezacychPrzydzielonychTest()
        {
            Hashtable expected = null; // TODO: Initialize to an appropriate value
            Hashtable actual;
            RolaPracownik.ListaZlecenBiezacychPrzydzielonych = expected;
            actual = RolaPracownik.ListaZlecenBiezacychPrzydzielonych;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
