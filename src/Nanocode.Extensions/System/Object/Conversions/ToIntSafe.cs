using Nanocode.Extensions.Strings;
using System;
using System.Text;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static int ToIntSafe(this object @this)
        {
            var decValue = 0.0m;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) decimal.TryParse(strSafe, out decValue);
            return (int)decValue;
        }
    }
}