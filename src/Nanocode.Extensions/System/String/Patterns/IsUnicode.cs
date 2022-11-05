using System.Text;
using System.Text.RegularExpressions;

namespace Nanocode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        public static bool IsUnicode(this string @this)
        {
            int asciiBytesCount = Encoding.ASCII.GetByteCount(@this);
            int unicodBytesCount = Encoding.UTF8.GetByteCount(@this);

            return asciiBytesCount != unicodBytesCount;
        }
    }
}