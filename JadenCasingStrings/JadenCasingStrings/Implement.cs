using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JadenCasingStrings
{
    public class Implement
    {
        public string ToJadenCase(string phrase)
        {
            var chars = phrase.ToCharArray();
            var res = new StringBuilder(phrase.Length);
            bool previousWhitespace = true;

            foreach (var c in chars)
            {
                if (char.IsWhiteSpace(c))
                {
                    previousWhitespace = true;
                    res.Append(c);
                }
                else if (previousWhitespace && Char.IsLetter(c))
                {
                    res.Append(Char.ToUpper(c));
                    previousWhitespace = false;
                }
                else
                {
                    res.Append(c);
                }
            }
            return res.ToString();
        }
    }
}
