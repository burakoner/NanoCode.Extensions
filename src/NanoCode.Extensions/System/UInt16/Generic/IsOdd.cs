using System;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     An Int16 extension method that query if '@this' is odd.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if odd, false if not.</returns>
        public static bool IsOdd(this UInt16 @this)
        {
            return @this % 2 != 0;
        }
    }
}