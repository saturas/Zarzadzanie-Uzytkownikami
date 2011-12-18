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
        LinkedList<byte> _listaNumerowTlumaczyKtorzyTlumaczyli;
        int _numerKlienta;

        public LinkedList<String> ListaNazwDokumentow{
            get { return _listaNazwDokumentow; }
            set { _listaNazwDokumentow = value; }
        }

        public DateTime DataRealizacji { 
            get { return _dataRealizacji;}
            set { _dataRealizacji = value; }
        }
        public LinkedList<byte> ListaNumerowTlumaczyKtorzyTlumaczyli {
            get { return _listaNumerowTlumaczyKtorzyTlumaczyli; }
            set { _listaNumerowTlumaczyKtorzyTlumaczyli = value; } 
        }

        public int NumerKlienta{
            get { return _numerKlienta ; }
            set { _numerKlienta = value ;}
        }

}
