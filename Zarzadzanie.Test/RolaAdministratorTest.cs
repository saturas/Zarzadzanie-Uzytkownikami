using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Zarzadzanie_Uzytkownikami.Tests
{


    /// <summary>
    ///This is a test class for RolaAdministratorTest and is intended
    ///to contain all RolaAdministratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RolaAdministratorTest
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
        ///A test for RolaAdministrator Constructor
        ///</summary>
        [TestMethod()]
        public void RolaAdministratorConstructorTest()
        {

            RolaAdministrator target = new RolaAdministrator();
            Assert.IsNotNull(target.Name);
        }

        /// <summary>
        ///A test for DodajAdministratora
        ///</summary>
        [TestMethod()]
        public void DodajAdministratoraTest()
        {
            RolaAdministrator target = new RolaAdministrator();
            string login = "admin2";
            string haslo = "admin12";
            string imie = "maciek";
            string nazwisko = "asd";
            target.DodajAdministratora(login, haslo, imie, nazwisko);

            ManagerLogowania man = ManagerLogowania.getInstance();
            Assert.IsTrue(man.ListaUzytkownikowNiezalogowanych.Count > 0);
        }

        /// <summary>
        ///A test for DodajPraocwnika
        ///</summary>
        [TestMethod()]
        public void DodajPracownikaTest()
        {
            RolaAdministrator target = new RolaAdministrator();
            string login = "admin2";
            string haslo = "admin12";
            string imie = "maciek";
            string nazwisko = "asd";
            target.DodajPracownika(login, haslo, imie, nazwisko);

            ManagerLogowania man = ManagerLogowania.getInstance();
            Assert.IsTrue(man.ListaUzytkownikowNiezalogowanych.Count > 0);

        }

        /// <summary>
        ///A test for WeryfikujPoprawnosc
        ///</summary>
        [TestMethod()]
        public void WeryfikujPoprawnoscTest()
        {
            string login = "admin2";
            string haslo = "admin12";
            string imie = "maciek";
            string nazwisko = "asd";

            Uzytkownik user = new Uzytkownik(login, haslo, imie, nazwisko);
            RolaAdministrator target = new RolaAdministrator(); // TODO: Initialize to an appropriate value
            LinkedList<Uzytkownik> users = new LinkedList<Uzytkownik>(); // TODO: Initialize to an appropriate value
            users.AddFirst(user);

            ManagerLogowania man = ManagerLogowania.getInstance();
            man.ListaUzytkownikowNiezweryfikowanych.AddFirst(user);

            Assert.IsTrue(man.ListaUzytkownikowNiezweryfikowanych.Contains(user));
            Assert.IsFalse(man.ListaUzytkownikowNiezalogowanych.Contains(user));

            target.WeryfikujPoprawnosc(users);

            Assert.IsTrue(man.ListaUzytkownikowNiezalogowanych.Contains(user));
            Assert.IsFalse(man.ListaUzytkownikowNiezweryfikowanych.Contains(user));

        }

        /// <summary>
        ///A test for WeryfikujPrzydzialRoli
        ///</summary>
        [TestMethod()]
        public void WeryfikujPrzydzialRoliTest()
        {
            RolaAdministrator target = new RolaAdministrator();
            LinkedList<Uzytkownik> users = null; // TODO: Initialize to an appropriate value
            target.WeryfikujPrzydzialRoli(users);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }


    }
}
