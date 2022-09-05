using System;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Returns the specified 16-bit signed integer value as an array of bytes.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>An array of bytes with length 2.</returns>
        public static byte[] GetBytes(this byte value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}