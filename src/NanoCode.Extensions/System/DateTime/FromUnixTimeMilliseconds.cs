using System;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        public static DateTime FromUnixTimeMilliseconds(this int @this)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(@this);
        }
        public static DateTime FromUnixTimeMilliseconds(this long @this)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(@this);
        }
    }
}