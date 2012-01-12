using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class RolaPracownik : Rola
    {
        static System.Collections.Hashtable _listaZlecenBiezacychPrzydzielonych = new System.Collections.Hashtable();

        static System.Collections.Hashtable _listaZlecenBiezacychNieprzydzielonych = new System.Collections.Hashtable();

        private LinkedList<RolaTlumacz> _listaTlumaczy = new LinkedList<RolaTlumacz>();

        public static System.Collections.Hashtable ListaZlecenBiezacychNieprzydzielonych
        {
            get { return _listaZlecenBiezacychNieprzydzielonych; }
            set { _listaZlecenBiezacychNieprzydzielonych = value; }
        }

        public static System.Collections.Hashtable ListaZlecenBiezacychPrzydzielonych
        {
            get { return _listaZlecenBiezacychPrzydzielonych; }
            set { _listaZlecenBiezacychPrzydzielonych = value; }
        }

        public LinkedList<RolaTlumacz> ListaTlumaczy
        {
            get { return _listaTlumaczy; }
            set { _listaTlumaczy = value; }
        }

        public RolaPracownik() : base("pracownik") { }

        // GUI ma wyciągnąć zlecenia nie przydzielone, dlakazdego wyświetlić liste dokumentow i tłumaczy z listy. wyswietlic je pracownikowi, pracownik ma wybrac które chce przydzielić
        // i nastepnie Controller zwroci mi pare, zlecenieBiezace, Tlumacz
        public void PrzydzielZlecenie(ZlecenieBiezace zlecenie, LinkedList<RolaTlumacz> tlumacze)
        {

            // jak wyjac obiekt po kluczu z mapy? zrobilem to Enumeratorem ale na to powinna byc jedna metoda
            System.Collections.IDictionaryEnumerator enumerator;
            enumerator =  ListaZlecenBiezacychNieprzydzielonych.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Key.Equals(zlecenie))
                {
                    ListaZlecenBiezacychPrzydzielonych.Add(enumerator.Key, enumerator.Value);
                    ListaZlecenBiezacychNieprzydzielonych.Remove(enumerator.Key);

                    // dodajemy tlumaczom referencje do zlecenia, bardziej szczegolowym podzialem dokuemntu i przydzialem dokumentow zajmie sie inna grupa
                    foreach (RolaTlumacz t in tlumacze)
                    {
                        t.ListaWykonywanychZlecen.AddLast(zlecenie);
                    }
                    
                }
            }
            
               
        }


        // metoda wykonywana na koncu metody "ZlozZlecenie" w kliencie. Dzieki jej param
        public static void DodajZlecenie(ZlecenieBiezace z, RolaKlient k)
        {
            ListaZlecenBiezacychNieprzydzielonych.Add(z, k);
        }

        // czysci referencje u siebie, w kliencie i w tlumaczu.
        public void ArchiwizujZlecenie(ZlecenieBiezace z)
        {

            /////////////////////
            if (ListaZlecenBiezacychPrzydzielonych.Contains(z))
            {
           //     ListaZlecenBiezacychPrzydzielonych.
            }


            // ... uzupełnic funkcje usuwajaca referencje u klienta
            /////////////////////////


            // usuwa w tlumaczach referencje do zlecenia
            foreach (RolaTlumacz t in ListaTlumaczy)
            {
                if (t.ListaWykonywanychZlecen.Contains(z))
                {
                    t.ListaWykonywanychZlecen.Remove(z);
                }
            }

            
            z.Archiwizuj();

            // usuwamy referencje u siebie
            ListaZlecenBiezacychPrzydzielonych.Remove(z); 
            
        }
    }
}
