using System;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Returns the specified decimal value as an array of bytes.
        /// </summary>
        /// <param name="@this">The number to convert.</param>
        /// <returns>An array of bytes.</returns>
        public static byte[] GetBytes(this double @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}