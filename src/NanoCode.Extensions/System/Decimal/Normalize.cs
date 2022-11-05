using System;

namespace Nanocode.Extensions
{
    public static partial class ExtensionMethods
    {
        public static decimal Normalize(this decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }
    }
}