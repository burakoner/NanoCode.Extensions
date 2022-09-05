using System;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Indicates whether a specified string is not null, not empty, or not consists only of white-space characters.
        /// </summary>
        /// <param name="@this">The string to test.</param>
        /// <returns>true if the  parameter is null or , or if  consists exclusively of white-space characters.</returns>
        public static bool IsNullOrWhiteSpace(this string @this)
        {
            return String.IsNullOrWhiteSpace(@this);
        }
    }
}