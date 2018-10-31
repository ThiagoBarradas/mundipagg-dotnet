using System.Linq;

namespace Mundipagg.Utils
{
    /// <summary>
    /// String utility
    /// </summary>
    public static class StringUtil
    {
        /// <summary>
        /// Cast string to snake case, something like MyTest to my_test
        /// </summary>
        /// <param name="text">string to cast</param>
        /// <returns></returns>
        public static string ToSnakeCase(this string text)
        {
            string stringSnake = string.Concat(
                text.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString().ToLower() : x.ToString().ToLower())
            );

            return stringSnake;
        }
    }
}
