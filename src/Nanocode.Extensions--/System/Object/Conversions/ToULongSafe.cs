using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static ulong ToULongSafe(this object @this)
        {
            ulong result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) ulong.TryParse(strSafe, out result);
            return result;
        }
    }
}