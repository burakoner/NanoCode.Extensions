using NanoCode.Extensions.Strings;
using System;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static Int64 ToInt64Safe(this object @this)
        {
            var decValue = 0.0m;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) decimal.TryParse(strSafe, out decValue);
            return (Int64)decValue;
        }
    }
}