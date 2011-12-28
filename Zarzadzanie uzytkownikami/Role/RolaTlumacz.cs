using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami.Role
{
    class RolaTlumacz : Rola
    {
        LinkedList<ZlecenieBiezace> _listaWykonywanychZlecen = new LinkedList<ZlecenieBiezace>();

        public LinkedList<ZlecenieBiezace> ListaWykonywanychZlecen
        {
            get { return _listaWykonywanychZlecen; }
            set { _listaWykonywanychZlecen = value; }
        }

        // meldunek nastepuje dla dokumentu będącego częścią pewnego zlecenia bieżącego
        public void MeldujPostepPracy(Dokument d)
        {
            // tą metodę obsługuje inny zespół
        }

    }
}
