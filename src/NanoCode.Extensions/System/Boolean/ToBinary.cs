using System;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A bool extension method that convert this object into a binary representation.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A binary represenation of this object.</returns>
        public static byte ToBinary(this bool @this)
        {
            return Convert.ToByte(@this);
        }
    }
}