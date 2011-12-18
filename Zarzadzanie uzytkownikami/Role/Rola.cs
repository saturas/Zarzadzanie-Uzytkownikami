using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zarzadzanie_uzytkownikami
{
    abstract class  Rola{
        String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
