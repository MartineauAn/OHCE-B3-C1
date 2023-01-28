using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class OHCE
    {

        public string Traitement(string mot)
        {
            return new string(mot.Reverse().ToArray()) + "Bien dit !";
        }
    }
}
