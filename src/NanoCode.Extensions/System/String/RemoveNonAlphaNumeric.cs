using System;
using System.Linq;

namespace Nanocode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static string RemoveNonAlphaNumeric(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => Char.IsLetter(x) || Char.IsNumber(x)).ToArray());
        }
    }
}