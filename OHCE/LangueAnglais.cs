using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class LangueAnglais : ILangue
    {
        public string BienDit => "Well said !";

        public string Bonjour => "Hello";

        public string AuRevoir => "GoodBye";

        public string Saisie => "Please enter a string of characters";
    }
}
