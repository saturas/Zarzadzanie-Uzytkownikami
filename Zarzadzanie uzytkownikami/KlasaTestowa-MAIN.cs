using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class KlasaTestowa_MAIN
    {
        public static void Main()
        {
            Uzytkownik administrator = new Uzytkownik("admin", "admin", "Maksymilian", "Pracowity");

            RolaKlient klient = new RolaKlient();

            Console.WriteLine(klient.Name);
            Console.WriteLine("Nacisnij enter, aby zakonczyc...");
            Console.ReadLine();

        
        }
    
    }
}
