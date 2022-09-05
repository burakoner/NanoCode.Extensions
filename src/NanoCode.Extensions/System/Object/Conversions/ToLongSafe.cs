using NanoCode.Extensions.Strings;
using System;
using System.Text;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static long ToLongSafe(this object @this)
        {
            var decValue = 0.0m;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) decimal.TryParse(strSafe, out decValue);
            return (long)decValue;
        }
    }
}