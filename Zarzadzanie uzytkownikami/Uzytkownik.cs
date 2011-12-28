using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class Uzytkownik
    {
        String _imie;
        String _nazwisko;
        String _login;
        String _haslo;

        HashSet<Rola> _role = new HashSet<Rola>();

        public String Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        public String Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Haslo
        {
            get { return _haslo; }
            set { _haslo = value; }
        }

        public HashSet<Rola> Role{
            get { return _role ; }
            set { _role = value ; }
        }
                

        public Uzytkownik(String login, String haslo, String imie, String nazwisko)
        {
            Login = login;
            Haslo = haslo;
            Imie = imie;
            Nazwisko = nazwisko;
        }


        public void DodajRole(String nazwa, ManagerLogowania man)
        {
            if(nazwa=="klient")
            {
                Role.Add(new RolaKlient());
            }
            else if (nazwa == "pracownik")
            {
                Role.Add(new RolaPracownik());
            }
            else if (nazwa == "tlumacz")
            {
                Role.Add(new RolaTlumacz());
            }
            else if (nazwa == "administrator")
            {
                Role.Add(new RolaAdministrator(man));
            }


        }

        public void UsunRole(String nazwa)
        {
            // uzupelnic
        }
    }
}
