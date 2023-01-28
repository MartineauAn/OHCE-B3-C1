using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class OHCE
    {
        public ILangue langue;
        public OHCE (ILangue langue)
        {
            this.langue = langue;
        }

        public string Traitement(string mot)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Bonjour");

            var miroir = new string(mot.Reverse().ToArray());
            stringBuilder.Append(miroir);

            if (miroir == mot)
            {
                stringBuilder.Append(langue.BienDit);
            }

            stringBuilder.Append("Au revoir");

            return stringBuilder.ToString();
        }
    }
}
