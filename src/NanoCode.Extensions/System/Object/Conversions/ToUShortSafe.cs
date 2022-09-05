using NanoCode.Extensions.Strings;
using System;
using System.Text;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static ushort ToUShortSafe(this object @this)
        {
            ushort result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) ushort.TryParse(strSafe, out result);
            return result;
        }
    }
}