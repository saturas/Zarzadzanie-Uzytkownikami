using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami.Role
{
    class RolaKlient : Rola
    {
        LinkedList<ZlecenieBiezace> _listaZLecenBiezacych;
        static int _numerator; // uzyjemy tego do dynamicznego nadawania numerow klientom

        int _numer; // numer indywidualny dla kazdego egzemplarza

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


        public LinkedList<ZlecenieBiezace> ListaZlecenBiezacych
        {
            get { return _listaZLecenBiezacych; }
            set { _listaZLecenBiezacych = value; }
        }


        public RolaKlient()
        {
            Numerator++;
            Numer = Numerator;

        }


        public void ZlozZlecenie()
        {
        }

        public LinkedList<ZlecenieArchiwalne> PrzegladajHistorieZLecen()
        {
            return HistoriaZlecen.ZwrocRekordyKlienta(Numer);
        }
        
    }
}
