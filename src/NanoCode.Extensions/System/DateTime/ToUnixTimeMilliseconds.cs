using System;

namespace Nanocode.Extensions
{
    public static partial class ExtensionMethods
    {
        public static long ToUnixTimeMilliseconds(this DateTime @this)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64(Math.Floor((@this - epoch).TotalSeconds)) * 1000 + @this.Millisecond;
        }
    }
}