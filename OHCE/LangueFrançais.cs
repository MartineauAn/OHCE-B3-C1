using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class LangueFrançais : ILangue
    {
        public string BienDit => "Bien dit !";

        public string Bonjour => "Bonjour";

        public string AuRevoir => "Au revoir";

        public string Saisie => "Veuillez saisir une chaine de caractère";
    }
}
