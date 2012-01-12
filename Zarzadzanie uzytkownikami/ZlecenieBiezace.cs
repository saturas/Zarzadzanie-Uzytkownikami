using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class ZlecenieBiezace : Zlecenie
    {
        LinkedList<Dokument> _dokumentyDoPrzetlumaczenia;
        // w pierwotnej wersji tu powinien byc stopien realizacji no ale skoro jest lista dokumentow to stopien realizacji bedzie wizany z poszczegolnym dokumentem
        // tlumacz rowniez dopisany do konkretnego dokumentu
        DateTime _wymaganyTerminUkonczenia;
        int _numerKlienta;

        public LinkedList<Dokument> DokumentyDoPrzetlumaczenia
        {
            get { return _dokumentyDoPrzetlumaczenia; }
            set { _dokumentyDoPrzetlumaczenia = value; }
        }

        public int NumerKlienta
        {
            get { return _numerKlienta; }
            set { _numerKlienta = value; }
        }

        public ZlecenieBiezace(LinkedList<Dokument> dok, DateTime data, int numerKlienta)
        {
            _dokumentyDoPrzetlumaczenia = dok;
            _wymaganyTerminUkonczenia = data;
            _numerKlienta = numerKlienta;

        }

        public void Archiwizuj()
        {
            LinkedList<String> nazwyDokumentow = new LinkedList<string>(); // ta liste trzeba uzupelnic nazwami ale to musimy znac nazwy dokumentow z klasy dokument
            
            LinkedList<int> numeryTlumaczow = new LinkedList<int>(); // to samo co wyzej

            ZlecenieArchiwalne z = new ZlecenieArchiwalne(nazwyDokumentow, numeryTlumaczow, NumerKlienta );
            
            HistoriaZlecen.GetInstance().ListaZlecen.AddLast(z);

        }


        // zwroci mape Nazwa, progres. to trzeba uaktualnic jak nam dostarcza ten obiekt dokuemnt
        public System.Collections.Hashtable StopienRealizacji()
        {
            System.Collections.Hashtable mapa = new System.Collections.Hashtable();
            foreach (Dokument d in DokumentyDoPrzetlumaczenia)
            {
                mapa.Add(d.Name, d.Progres);
            }
            return mapa;
        }

    }
}
