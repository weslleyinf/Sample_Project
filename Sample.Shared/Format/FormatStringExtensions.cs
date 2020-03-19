using System.Linq;

namespace Sample.Kernel.Utility
{
    public static class FormatStringExtensions
    {
        public static string FirstCapitalLetter(this string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }

        public static string FirstCapitalLetters(this string text)
        {
            return string.Join(' ', text.Split(' ').Select(x => x.FirstCapitalLetter()));
        }
    }
}
