namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A T extension method that query if '@this' is not null.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if not null, false if not.</returns>
        public static bool IsNotNull(this string @this)
        {
            return @this != null;
        }
    }
}