using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Zarzadzanie_Uzytkownikami.Tests
{


    /// <summary>
    ///This is a test class for ManagerLogowaniaTest and is intended
    ///to contain all ManagerLogowaniaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ManagerLogowaniaTest
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
        ///A test for DodajNowegoAdministratora
        ///</summary>
        [TestMethod()]
        public void DodajNowegoAdministratoraTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            string login = "new";
            string haslo = "user";
            string imie = "ma";
            string nazwisko = "ts";  
            bool actual;
            Assert.IsTrue(target.ListaUzytkownikowNiezweryfikowanych.Count == 0);
            actual = target.DodajNowegoAdministratora(login, haslo, imie, nazwisko);
            Assert.IsTrue(actual);
            actual = target.DodajNowegoAdministratora(login, haslo, imie, nazwisko);
            Assert.IsFalse(actual);
        }

        /// <summary>
        ///A test for DodajNowegoPracownika
        ///</summary>
        [TestMethod()]
        public void DodajNowegoPracownikaTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            string login = "new";
            string haslo = "user";
            string imie = "ma";
            string nazwisko = "ts";
            bool actual;
            actual = target.DodajNowegoPracownika(login, haslo, imie, nazwisko);
            Assert.IsTrue(target.ListaUzytkownikowNiezalogowanych.Count > 0);
            Assert.IsTrue(actual);
            actual = target.DodajNowegoPracownika(login, haslo, imie, nazwisko);
            Assert.IsFalse(actual);
        }

        /// <summary>
        ///A test for RejestrujNowegoKlienta
        ///</summary>
        [TestMethod()]
        public void RejestrujNowegoKlientaTest() 
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            string login = "mowy";
            string haslo = "user2";
            string imie = "ma2";
            string nazwisko = "ts2";
            bool actual;
            

            actual = target.RejestrujNowegoKlienta(login, haslo, imie, nazwisko);
            Assert.IsTrue(actual);
           actual = target.RejestrujNowegoKlienta(login, haslo, imie, nazwisko);
           Assert.IsFalse(actual);

        }


        /// <summary>
        ///A test for RejestrujNowegoTlumacza
        ///</summary>
        [TestMethod()]
        public void RejestrujNowegoTlumaczaTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            string login = "mowy";
            string haslo = "user2";
            string imie = "ma2";
            string nazwisko = "ts2";
            bool actual;

            Assert.IsTrue(target.ListaUzytkownikowNiezweryfikowanych.Count == 0);
            actual = target.RejestrujNowegoKlienta(login, haslo, imie, nazwisko);
            Assert.IsTrue(actual);
            actual = target.RejestrujNowegoKlienta(login, haslo, imie, nazwisko);
            Assert.IsFalse(actual);
        }

        /// <summary>
        ///A test for Weryfikuj
        ///</summary>
        [TestMethod()]
        public void WeryfikujTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            string login = "mowy";
            string haslo = "user2";
            string imie = "ma2";
            string nazwisko = "ts2";
            Uzytkownik user =  new Uzytkownik(login,haslo,imie,nazwisko);
            target.ListaUzytkownikowNiezweryfikowanych.AddFirst(user);
            int liczbaNiezweryfikowanych = target.ListaUzytkownikowNiezweryfikowanych.Count;
            int liczbaNIezalogowanych = target.ListaUzytkownikowNiezalogowanych.Count;

           target.Weryfikuj(login, haslo);

            Assert.AreEqual(target.ListaUzytkownikowNiezweryfikowanych.Count, liczbaNiezweryfikowanych -1);
            Assert.AreEqual(target.ListaUzytkownikowNiezalogowanych.Count, liczbaNIezalogowanych+1);

        }

        /// <summary>
        ///A test for getInstance
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {
            ManagerLogowania expected = ManagerLogowania.getInstance();
            ManagerLogowania actual = ManagerLogowania.getInstance();

            Assert.AreSame(expected, actual);
        }

        /// <summary>
        ///A test for ListaUzytkownikowNiezalogowanych
        ///</summary>
        [TestMethod()]
        public void ListaUzytkownikowNiezalogowanychTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            LinkedList<Uzytkownik> expected = new LinkedList<Uzytkownik>(); // TODO: Initialize to an appropriate value
            LinkedList<Uzytkownik> actual;
            target.ListaUzytkownikowNiezalogowanych = expected;
            actual = target.ListaUzytkownikowNiezalogowanych;
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for ListaUzytkownikowNiezweryfikowanych
        ///</summary>
        [TestMethod()]
        public void ListaUzytkownikowNiezweryfikowanychTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            LinkedList<Uzytkownik> expected = new LinkedList<Uzytkownik>(); 
            LinkedList<Uzytkownik> actual;
            target.ListaUzytkownikowNiezweryfikowanych = expected;
            actual = target.ListaUzytkownikowNiezweryfikowanych;
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for ListaUzytkownikowZNowymiRolami
        ///</summary>
        [TestMethod()]
        public void ListaUzytkownikowZNowymiRolamiTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            LinkedList<Uzytkownik> expected = new LinkedList<Uzytkownik>();
            LinkedList<Uzytkownik> actual;
            target.ListaUzytkownikowZNowymiRolami = expected;
            actual = target.ListaUzytkownikowZNowymiRolami;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for ListaUzytkownikowZalogowanych
        ///</summary>
        [TestMethod()]
        public void ListaUzytkownikowZalogowanychTest()
        {
            ManagerLogowania target = ManagerLogowania.getInstance();
            LinkedList<Uzytkownik> expected = new LinkedList<Uzytkownik>();
            LinkedList<Uzytkownik> actual;
            target.ListaUzytkownikowZalogowanych = expected;
            actual = target.ListaUzytkownikowZalogowanych;
            Assert.AreEqual(expected, actual);

        }
    }
}
