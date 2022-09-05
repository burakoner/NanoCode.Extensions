using System;
using System.Text;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A string extension method that converts the @this to a byte array.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a byte[].</returns>
        public static byte[] ToByteArray(this string @this)
        {
            return Encoding.UTF8.GetBytes(@this);
        }
    }
}