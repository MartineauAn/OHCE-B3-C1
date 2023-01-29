using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class PeriodeSystème
    {
        public string RecupererPeriode(ILangue langue)
        {

            int heure = DateTime.Now.Hour;

            if (heure >= 6 && heure <= 12)
            {
                return langue is LangueAnglais ? new PeriodeAnglais().matin : new PeriodeFrançais().matin;
            }
            else if (heure >= 13 && heure <= 17)
            {
                return langue is LangueAnglais ? new PeriodeAnglais().apresMidi : new PeriodeFrançais().apresMidi;
            }
            else if (heure >= 18 && heure <= 21)
            {
                return langue is LangueAnglais ? new PeriodeAnglais().soiree : new PeriodeFrançais().soiree;
            }
            else
            {
                return langue is LangueAnglais ? new PeriodeAnglais().nuit : new PeriodeFrançais().nuit;
            }

        }
    }
}
