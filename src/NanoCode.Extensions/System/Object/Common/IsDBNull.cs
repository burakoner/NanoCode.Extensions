using System;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Returns an indication whether the specified object is of type .
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">An object.</param>
        /// <returns>true if  is of type ; otherwise, false.</returns>
        public static bool IsDBNull<T>(this T @this) where T : class
        {
            return Convert.IsDBNull(@this);
        }
    }
}