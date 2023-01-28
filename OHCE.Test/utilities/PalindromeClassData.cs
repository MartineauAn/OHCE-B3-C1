using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    public class PalindromeClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrançais(), "laval", new LangueFrançais().BienDit };
            yield return new object[] { new LangueAnglais(), "radar", new LangueAnglais().BienDit };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
