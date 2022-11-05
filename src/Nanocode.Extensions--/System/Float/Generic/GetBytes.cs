using System;

namespace Nanocode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Returns the specified float value as an array of bytes.
        /// </summary>
        /// <param name="@this">The number to convert.</param>
        /// <returns>An array of bytes.</returns>
        public static byte[] GetBytes(this float @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}