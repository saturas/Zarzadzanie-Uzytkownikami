using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class HistoriaZlecen
    {
        private static HistoriaZlecen _instance = new HistoriaZlecen();

        private  LinkedList<ZlecenieArchiwalne> _listaZlecen = new LinkedList<ZlecenieArchiwalne>(); 

        public  LinkedList<ZlecenieArchiwalne> ListaZlecen
        {
            get { return _listaZlecen; }
            set { _listaZlecen = value; }
        }

        private HistoriaZlecen() { }

        public static HistoriaZlecen GetInstance()
        {
            return _instance;
        }

        public  LinkedList<ZlecenieArchiwalne> ZwrocRekordyKlienta(int numerKlienta)
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
