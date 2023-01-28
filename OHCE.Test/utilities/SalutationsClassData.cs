using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    internal class SalutationsClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrançais()};
            yield return new object[] { new LangueAnglais()};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
