using NanoCode.Extensions.Strings;
using System;
using System.Text;

namespace NanoCode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        public static float ToFloatSafe(this object @this)
        {
            float result = 0;
            string strSafe = @this.ToStringSafe();
            if (strSafe.IsNotNullOrEmpty()) float.TryParse(strSafe, out result);
            return result;
        }
    }
}