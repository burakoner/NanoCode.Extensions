using System;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Returns the  for the specified object.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <returns>The  for , or  if  is null.</returns>
        public static TypeCode GetTypeCode(this object value)
        {
            return Convert.GetTypeCode(value);
        }
    }
}