using System;
using System.Text;

namespace Nanocode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A string extension method that encode the string to Base64.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The encoded string to Base64.</returns>
        public static string Base64Encode(this string @this)
        {
            return Convert.ToBase64String(Activator.CreateInstance<UTF8Encoding>().GetBytes(@this));
        }
    }
}