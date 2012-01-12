using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class RolaTlumacz : Rola
    {
        static int _numerator; // uzyjemy tego do dynamicznego nadawania numerow Tlumaczom

        // numery tlumaczy przydzadza sie do przypisywania ich kazdeomu dokumentowi. ?
        int _numer; // numer indywidualny dla kazdego egzemplarza


        LinkedList<ZlecenieBiezace> _listaWykonywanychZlecen = new LinkedList<ZlecenieBiezace>();

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int Numer
        {
            get { return _numer; }
            set { _numer = value; }
        }

        public RolaTlumacz() : base("tlumacz") { }

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
