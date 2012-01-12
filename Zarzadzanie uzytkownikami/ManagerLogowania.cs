using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class ManagerLogowania
    {
        LinkedList<Uzytkownik> _listaUzytkownikowZalogowanych = new LinkedList<Uzytkownik>();
        LinkedList<Uzytkownik> _listaUzytkownikowNiezalogowanych = new LinkedList<Uzytkownik>();
        LinkedList<Uzytkownik> _listaUzytkownikowNiezweryfikowanych = new LinkedList<Uzytkownik>();

        LinkedList<Uzytkownik> _listaUzytkownikowZNowymiRolami = new LinkedList<Uzytkownik>(); //kolekcja nowych rol do dodania

        private static ManagerLogowania _instance = new ManagerLogowania();

        private ManagerLogowania() { }

        public static ManagerLogowania getInstance()
        {
            return _instance;
        }


        public LinkedList<Uzytkownik> ListaUzytkownikowZNowymiRolami
        {
            get { return _listaUzytkownikowZNowymiRolami; }
            set { _listaUzytkownikowZNowymiRolami = value; }
        }

        public LinkedList<Uzytkownik> ListaUzytkownikowZalogowanych
        {
            get { return _listaUzytkownikowZalogowanych; }
            set { _listaUzytkownikowZalogowanych = value; }
        }

        public LinkedList<Uzytkownik> ListaUzytkownikowNiezalogowanych
        {
            get { return _listaUzytkownikowNiezalogowanych; }
            set { _listaUzytkownikowNiezalogowanych = value; }
        }

        public LinkedList<Uzytkownik> ListaUzytkownikowNiezweryfikowanych
        {
            get { return _listaUzytkownikowNiezweryfikowanych; }
            set { _listaUzytkownikowNiezweryfikowanych = value; }
        }


        public Uzytkownik Weryfikuj(String login, String haslo)
        {
            foreach (Uzytkownik u in ListaUzytkownikowNiezweryfikowanych)
            {
                if (u.Login == login && u.Haslo == haslo)
                {
                    ListaUzytkownikowNiezweryfikowanych.Remove(u);
                    _listaUzytkownikowNiezalogowanych.AddLast(u);
                    return u;
                }
            }
            throw  new Exception(); // tak jest dobrze?
        }

        // jesli zwroci false to znaczy ze uzytkownik o tym samym loginie juz istnieje
        public Boolean RejestrujNowegoKlienta(String login, String haslo, String imie, String nazwisko)
        {
            foreach (Uzytkownik u in ListaUzytkownikowNiezalogowanych)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            foreach (Uzytkownik u in ListaUzytkownikowZNowymiRolami)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            Uzytkownik user = new Uzytkownik(login, haslo, imie, nazwisko);
            ListaUzytkownikowNiezweryfikowanych.AddFirst(user);
            user.DodajRole("klient");
            return true;

        }
        // jesli zwroci false to znaczy ze uzytkownik o tym samym loginie juz istnieje
        public Boolean RejestrujNowegoTlumacza(String login, String haslo, String imie, String nazwisko)
        {
            foreach (Uzytkownik u in ListaUzytkownikowNiezalogowanych)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            foreach (Uzytkownik u in ListaUzytkownikowZNowymiRolami)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            Uzytkownik user = new Uzytkownik(login, haslo, imie, nazwisko);
            ListaUzytkownikowNiezweryfikowanych.AddFirst(user);
            user.DodajRole("tlumacz");
            return true;
        }
        // ta metode wywoluje tylko Administrator, od razu dodanie powoduje dodanie do niezalogowanych a nie niezweryfikowanych jak wczseniej
        public Boolean DodajNowegoAdministratora(String login, String haslo, String imie, String nazwisko)
        {
            foreach (Uzytkownik u in ListaUzytkownikowNiezalogowanych)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            foreach (Uzytkownik u in ListaUzytkownikowZNowymiRolami)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            Uzytkownik user = new Uzytkownik(login, haslo, imie, nazwisko);
            ListaUzytkownikowNiezalogowanych.AddFirst(user);
            user.DodajRole("administrator");
            return true;
        }

        public Boolean DodajNowegoPracownika(String login, String haslo, String imie, String nazwisko)
        {
            foreach (Uzytkownik u in ListaUzytkownikowNiezalogowanych)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            foreach (Uzytkownik u in ListaUzytkownikowZNowymiRolami)
            {
                if (u.Login == login)
                {
                    return false;
                }
            }
            Uzytkownik user = new Uzytkownik(login, haslo, imie, nazwisko);
            ListaUzytkownikowNiezalogowanych.AddFirst(user);
            user.DodajRole("pracownik");
            return true;
        }

    }
}
