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

        public ZlecenieBiezace(LinkedList<Dokument> dok, DateTime data)
        {
            _dokumentyDoPrzetlumaczenia = dok;
            _wymaganyTerminUkonczenia = data;


        }
    }
}
