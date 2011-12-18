using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class ZlecenieArchiwalne : Zlecenie
    {
        LinkedList<String> _listaNazwDokumentow;
        DateTime _dataRealizacji;

        // chyba lepiej po numerach niz po stringu?
        LinkedList<int> _listaNumerowTlumaczyKtorzyTlumaczyli;
        int _numerKlienta;

        public ZlecenieArchiwalne(LinkedList<String> listaNazwDok, LinkedList<int> listaNumerowTlumaczy, int numerKlienta)
        {
            _listaNazwDokumentow = listaNazwDok;
            _dataRealizacji = DateTime.Today;
            _listaNumerowTlumaczyKtorzyTlumaczyli = listaNumerowTlumaczy;
            _numerKlienta = numerKlienta;

        }


        public LinkedList<String> ListaNazwDokumentow
        {
            get { return _listaNazwDokumentow; }
            set { _listaNazwDokumentow = value; }
        }

        public DateTime DataRealizacji
        {
            get { return _dataRealizacji; }
            set { _dataRealizacji = value; }
        }
        public LinkedList<int> ListaNumerowTlumaczyKtorzyTlumaczyli
        {
            get { return _listaNumerowTlumaczyKtorzyTlumaczyli; }
            set { _listaNumerowTlumaczyKtorzyTlumaczyli = value; }
        }

        public int NumerKlienta
        {
            get { return _numerKlienta; }
            set { _numerKlienta = value; }
        }
    }

}
