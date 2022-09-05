using NanoCode.Extensions.Strings;
using System;
using System.Text;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static short ToShortSafe(this object @this)
        {
            short result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) short.TryParse(strSafe, out result);
            return result;
        }
    }
}