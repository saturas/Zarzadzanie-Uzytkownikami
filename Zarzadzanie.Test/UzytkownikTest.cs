using Zarzadzanie_uzytkownikami;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Zarzadzanie_Uzytkownikami.Tests
{


    /// <summary>
    ///This is a test class for UzytkownikTest and is intended
    ///to contain all UzytkownikTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UzytkownikTest
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
        ///A test for Uzytkownik Constructor
        ///</summary>
        [TestMethod()]
        public void UzytkownikConstructorTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            Assert.AreEqual(login, target.Login);
            Assert.AreEqual(haslo, target.Haslo);
            Assert.AreEqual(imie, target.Imie);
            Assert.AreEqual(nazwisko, target.Nazwisko);

        }

        /// <summary>
        ///A test for DodajRole
        ///</summary>
        [TestMethod()]
        public void DodajRoleTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            string nazwa = "name";
            target.DodajRole(nazwa);
            Assert.IsTrue(target.RoleOczekujace.Contains(nazwa));
        }


        /// <summary>
        ///A test for Haslo
        ///</summary>
        [TestMethod()]
        public void HasloTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            string expected = "adminek";
            string actual;
            target.Haslo = expected;
            actual = target.Haslo;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Imie
        ///</summary>
        [TestMethod()]
        public void ImieTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            string expected = "krzysztof";
            string actual;
            target.Imie = expected;
            actual = target.Imie;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for Login
        ///</summary>
        [TestMethod()]
        public void LoginTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            string expected = "admin2";
            string actual;
            target.Login = expected;
            actual = target.Login;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for Nazwisko
        ///</summary>
        [TestMethod()]
        public void NazwiskoTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            string expected = "sikora";
            string actual;
            target.Nazwisko = expected;
            actual = target.Nazwisko;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for Role
        ///</summary>
        [TestMethod()]
        public void RoleTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            HashSet<Rola> expected = new HashSet<Rola>();
            HashSet<Rola> actual;
            target.Role = expected;
            actual = target.Role;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for RoleOczekujace
        ///</summary>
        [TestMethod()]
        public void RoleOczekujaceTest()
        {
            string login = "admin";
            string haslo = "admin12";
            string imie = "mateusz";
            string nazwisko = "okarmus";
            Uzytkownik target = new Uzytkownik(login, haslo, imie, nazwisko);
            HashSet<string> expected = new HashSet<string>();
            HashSet<string> actual;
            target.RoleOczekujace = expected;
            actual = target.RoleOczekujace;
            Assert.AreEqual(expected, actual);
        }
    }
}
