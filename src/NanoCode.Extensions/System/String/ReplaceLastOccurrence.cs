using System;

namespace NanoCode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static string ReplaceLastOccurrence(this string @this, string Find, string Replace)
        {
            int Place = @this.LastIndexOf(Find);
            return @this.Remove(Place, Find.Length).Insert(Place, Replace);
        }
    }
}