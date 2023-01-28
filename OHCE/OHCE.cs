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
        public string periode;
        public OHCE (ILangue langue, string periode)
        {
            this.langue = langue;
            this.periode = periode;
        }

        public string Traitement(string mot)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(langue.Bonjour);
            stringBuilder.Append(periode);

            var miroir = new string(mot.Reverse().ToArray());
            stringBuilder.Append(miroir);

            if (miroir == mot)
            {
                stringBuilder.Append(langue.BienDit);
            }

            stringBuilder.Append(langue.AuRevoir);

            return stringBuilder.ToString();
        }
    }
}
