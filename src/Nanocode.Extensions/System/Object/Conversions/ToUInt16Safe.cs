using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static UInt16 ToUInt16Safe(this object @this)
        {
            UInt16 result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) UInt16.TryParse(strSafe, out result);
            return result;
        }
    }
}