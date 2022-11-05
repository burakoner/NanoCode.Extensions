using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static long ToUInt32Safe(this object @this)
        {
            UInt32 result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) UInt32.TryParse(strSafe, out result);
            return result;
        }
    }
}