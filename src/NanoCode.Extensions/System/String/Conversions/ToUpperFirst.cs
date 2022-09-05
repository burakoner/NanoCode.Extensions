using System;
using System.Linq;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static string ToUpperFirst(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return string.Empty;
            }

            char[] theChars = @this.ToCharArray();
            theChars[0] = char.ToUpper(theChars[0]);

            return new string(theChars);
        }
    }
}