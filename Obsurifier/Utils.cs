using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace obscurifier
{
    public static class Utils
    {
        public static string Obscurify(string fileContents)
        {
            Dictionary<string, string> replacementDict = new()
            {
                { "Kroger", "Companybrandname" },
                { "Boundary", "StructureOne" },
                { "Persistor", "PersistanceService" },
            };

            string commentsRemoved = Regex.Replace(fileContents, @"((['""])(?:(?!\2|\\).|\\.)*\2)|\/\/[^\n]*|\/\*(?:[^*]|\*(?!\/))*\*\/", string.Empty, RegexOptions.Multiline);

            foreach (var kvp in replacementDict)
            {
                commentsRemoved = ReplacePreservingCase(commentsRemoved, "Kroger", "CompanyBrandName");
            }


            return commentsRemoved;

        }

        private static string ReplacePreservingCase(string input, string oldValue, string newValue)
        {
            if (!input.Contains(oldValue, StringComparison.OrdinalIgnoreCase))
                return input;

            string pattern = Regex.Escape(oldValue);
            return Regex.Replace(input, pattern, match =>
            {
                if (match.Value == oldValue) return newValue;
                if (match.Value == oldValue.ToLower()) return newValue.ToLower();
                if (match.Value == oldValue.ToUpper()) return newValue.ToUpper();

                return ToMatchingCase(match.Value, newValue);
            }, RegexOptions.IgnoreCase);
        }

        private static string ToMatchingCase(string originalText, string replacementText)
        {
            if (string.IsNullOrEmpty(originalText) || string.IsNullOrEmpty(replacementText))
                return replacementText;

            char[] result = replacementText.ToCharArray();
            for (int i = 0; i < result.Length && i < originalText.Length; i++)
            {
                result[i] = char.IsUpper(originalText[i])
                    ? char.ToUpper(result[i])
                    : char.ToLower(result[i]);
            }

            return new string(result);
        }
    }
}
