using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static Int16 ToInt16Safe(this object @this)
        {
            Int16 result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) Int16.TryParse(strSafe, out result);
            return result;
        }
    }
}