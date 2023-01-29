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

            stringBuilder.Append(this.DireBonjour());

            stringBuilder.Append(" " + this.Miroir(mot) + " ");

            stringBuilder.Append(this.DireAuRevoir());

            return stringBuilder.ToString();
        }

        public string DireBonjour()
        {
            return (langue.Bonjour + " " + periode).Trim();
        }

        public string Miroir(string mot)
        {
            var stringBuilder = new StringBuilder();

            var miroir = new string(mot.Reverse().ToArray());
            stringBuilder.Append(miroir);

            if (miroir == mot)
            {
                stringBuilder.Append(" " + langue.BienDit);
            }

            return stringBuilder.ToString();
        }

        public string DireAuRevoir ()
        {
            return (langue.AuRevoir + " " + periode).Trim();
        }
    }
}
