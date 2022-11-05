using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static UInt64 ToUInt64Safe(this object @this)
        {
            UInt64 result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) UInt64.TryParse(strSafe, out result);
            return result;
        }
    }
}