using System;
using System.Text;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A string extension method that decode a Base64 String.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The Base64 String decoded.</returns>
        public static string Base64Decode(this string @this)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(@this));
        }
    }
}