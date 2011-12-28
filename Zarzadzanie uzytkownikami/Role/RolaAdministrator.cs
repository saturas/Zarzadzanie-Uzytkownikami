using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class RolaAdministrator : Rola
    {
        ManagerLogowania _m;
        
        public RolaAdministrator(ManagerLogowania m)
        {
            _m = m;
        }

        public void DodajAdministratora(String login, String haslo, String imie, String nazwisko)
        {
            _m.DodajNowegoAdministratora(login, haslo, imie, nazwisko);                    
        }

        public void DodajPraocwnika(String login, String haslo, String imie, String nazwisko)
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


    }
}
