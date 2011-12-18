using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class HistoriaZlecen
    {
        // statyczne jest po to by sobie klient mogl wywolac metode przelgadania historii nie majac referencji do niej
        private static LinkedList<ZlecenieArchiwalne> _listaZlecen = new LinkedList<ZlecenieArchiwalne>(); // tak to rozwiazac czy w konstruktorze tworzcy obiekt?

        public static LinkedList<ZlecenieArchiwalne> ListaZlecen
        {
            get { return _listaZlecen; }
            set { _listaZlecen = value; }
        }

        public static LinkedList<ZlecenieArchiwalne> ZwrocRekordyKlienta(int numerKlienta)
        {
            LinkedList<ZlecenieArchiwalne> wynik = new LinkedList<ZlecenieArchiwalne>();
            foreach (ZlecenieArchiwalne z in _listaZlecen)
            {
                if (z.NumerKlienta == numerKlienta)
                {
                    wynik.AddFirst(z);
                }
            }
            return wynik;
        }
 

    }
}
