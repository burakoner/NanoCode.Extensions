using System;
using System.Text.RegularExpressions;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static int WordCount(this string @this)
        {
            var count = 0;
            try
            {
                // Exclude whitespaces, Tabs and line breaks
                var re = new Regex(@"[^\s]+");
                var matches = re.Matches(@this);
                count = matches.Count;
            }
            catch
            {
            }
            return count;
        }
    }
}