using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
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


        public void ZlozZlecenie(LinkedList<Dokument> dokumenty, DateTime terminUkonczenia)
        {
            ZlecenieBiezace zlecenie = new ZlecenieBiezace(dokumenty, terminUkonczenia, Numer);
            ListaZlecenBiezacych.AddLast(zlecenie);
            RolaPracownik.DodajZlecenie(zlecenie, this);

        }

        public LinkedList<ZlecenieArchiwalne> PrzegladajHistorieZLecen()
        {
            return HistoriaZlecen.GetInstance().ZwrocRekordyKlienta(Numer);
        }
        

        // Dla kazdego zlecenia(robi z nich liste) zwraca mape <dokument, postep w jego tlumaczeniu>
        public LinkedList<System.Collections.Hashtable> PrzegladajPostepBiezacychZLecen()
        {
            LinkedList<System.Collections.Hashtable> lista = new LinkedList<System.Collections.Hashtable>();

            foreach ( ZlecenieBiezace z in ListaZlecenBiezacych)
            {
                lista.AddLast(z.StopienRealizacji());
            }

            return lista;
        }

    }
}
