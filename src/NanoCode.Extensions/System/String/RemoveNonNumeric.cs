using System;
using System.Linq;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static string RemoveNonNumeric(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => Char.IsNumber(x)).ToArray());
        }
    }
}