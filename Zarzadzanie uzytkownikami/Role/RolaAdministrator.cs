using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class RolaAdministrator : Rola
    {
        ManagerLogowania _m;

        public RolaAdministrator(): base("administrator")
        {
            _m = ManagerLogowania.getInstance();
        }

        public void DodajAdministratora(String login, String haslo, String imie, String nazwisko)
        {
            _m.DodajNowegoAdministratora(login, haslo, imie, nazwisko);                    
        }

        public void DodajPracownika(String login, String haslo, String imie, String nazwisko)
        {
            _m.DodajNowegoPracownika(login, haslo, imie, nazwisko);
        }

        //zakladamy ze procedura wyglada tak: 1. GUI wyswietla liste niezweryfikowanych uzytkownikow. 2. Uzytkownik zaznacza te ktore maja byc potwierdzone
        // 3. dostajemyd o tej metody liste i ta liste przekladamy do niezalogowanych.
        public void WeryfikujPoprawnosc(LinkedList<Uzytkownik> users)
        {
            foreach (Uzytkownik u in users)
            {
                _m.ListaUzytkownikowNiezweryfikowanych.Remove(u);
                _m.ListaUzytkownikowNiezalogowanych.AddFirst(u);
            }
        }

        public void WeryfikujPrzydzialRoli(LinkedList<Uzytkownik> users)
        {
            foreach (Uzytkownik u in users)
            {
                _m.ListaUzytkownikowZNowymiRolami.Remove(u);

                foreach (String rola in u.RoleOczekujace)
                {
                    if (rola == "klient")
                    {
                        u.Role.Add(new RolaKlient());
                    }
                    else if (rola == "pracownik")
                    {
                        u.Role.Add(new RolaPracownik());
                    }
                    else if (rola == "tlumacz")
                    {
                        u.Role.Add(new RolaTlumacz());
                    }
                    else if (rola == "administrator")
                    {
                        u.Role.Add(new RolaAdministrator());
                    }
                
                }
            
            }
        
        }
    }
}
