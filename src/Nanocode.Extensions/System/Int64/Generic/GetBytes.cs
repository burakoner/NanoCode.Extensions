using System;

namespace Nanocode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Returns the specified 64-bit signed integer value as an array of bytes.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>An array of bytes with length 2.</returns>
        public static byte[] GetBytes(this Int64 value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}