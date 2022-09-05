using NanoCode.Extensions.Strings;
using System;
using System.Text;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static decimal ToDecimalSafe(this object @this)
        {
            decimal result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) decimal.TryParse(strSafe, out result);
            return result;
        }
    }
}