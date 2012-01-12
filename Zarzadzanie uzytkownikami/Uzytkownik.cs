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

        HashSet<String> _roleOczekujace = new HashSet<String>();

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

        public HashSet<String> RoleOczekujace
        {
            get { return _roleOczekujace; }
            set { _roleOczekujace = value; }
        }

        public Uzytkownik(String login, String haslo, String imie, String nazwisko)
        {
            Login = login;
            Haslo = haslo;
            Imie = imie;
            Nazwisko = nazwisko;
        }


        // trzeba zaklepac metode weryfikująca ktora najpierw wysle prosbe dodania roli do administratora i dopiero wywola tą metodę
        public void DodajRole(String nazwa)
        {
            _roleOczekujace.Add(nazwa);
            ManagerLogowania.getInstance().ListaUzytkownikowZNowymiRolami.AddFirst(this);
        }

        public void UsunRole(String nazwa)
        {
            // uzupelnic
        }
    }
}
