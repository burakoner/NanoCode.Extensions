using System;

namespace Nanocode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static string Between(this string @this, string firstString, string lastString, bool includeFirst = false, bool includeLast = false)
        {
            int posA = @this.IndexOf(firstString) + firstString.Length;
            if (posA > @this.Length) return "";
            string temp = @this.Substring(posA);
            int posB = posA + temp.IndexOf(lastString);

            if (posA == -1) return "";
            if (posB == -1) return "";
            if (posA >= posB) return "";

            string FinalString = @this.Substring(posA, posB - posA);
            if (includeFirst) FinalString = firstString + FinalString;
            if (includeLast) FinalString = FinalString + lastString;
            return FinalString;
        }
    }
}