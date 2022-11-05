using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static uint ToUIntSafe(this object @this)
        {
            uint result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) uint.TryParse(strSafe, out result);
            return result;
        }
    }
}