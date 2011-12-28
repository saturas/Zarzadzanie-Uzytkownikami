using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    class RolaAdministrator : Rola
    {
        ManagerLogowania _m;
        public RolaAdministrator(ManagerLogowania m)
        {
            _m = m;
        }

    }
}
