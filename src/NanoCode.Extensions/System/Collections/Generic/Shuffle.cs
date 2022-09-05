using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            var rnd = new Random();
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = rnd.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]);
            }
        }
    }
}