using System;

namespace Nanocode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Get string value after [last] a.
        /// </summary>
        public static string After(this string @this, string value)
        {

            if (@this.IndexOf(value) == -1)
            {
                return "";
            }
            return @this.Substring(@this.IndexOf(value) + value.Length);
        }
    }
}