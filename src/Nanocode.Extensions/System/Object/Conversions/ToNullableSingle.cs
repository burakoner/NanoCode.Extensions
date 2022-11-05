using System;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable single.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a float?</returns>
        public static float? ToNullableSingle(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToSingle(@this);
        }
    }
}