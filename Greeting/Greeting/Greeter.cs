using System;
using System.Linq;

namespace Greeting
{
    public class Greeter
    {
        public string Greet(params string[] names)
        {
            var sanitisedNames = SanitiseNames(names);
            if (NameIsMissing(sanitisedNames))
            {
                sanitisedNames = new[] { "my friend" };
            }

            var spokenNames = sanitisedNames.Where(name => !NameIsShouted(name)).ToArray();
            var shoutedNames = sanitisedNames.Where(NameIsShouted).ToArray();

            var result = String.Empty;
            if (spokenNames.Any())
            {
                result = PrintSpokenNames(spokenNames);
            }

            if (shoutedNames.Any())
            {
                if (result != string.Empty)
                {
                    result += " AND ";
                }
                result += PrintShoutedNames(shoutedNames);
            }

            return result;
        }

        /// <summary>
        /// Performs the following transformations:
        ///   - Splits any names containing commas
        ///   - Trims any leading or trailing whitespace
        /// </summary>
        private string[] SanitiseNames(string[] names)
        {
            if (NameIsMissing(names))
                return names;

            return names
                .SelectMany(name => name.Split(','))
                .Select(name => name.Trim())
                .ToArray();
        }

        private bool NameIsMissing(string[] names)
        {
            return names == null || names.Length == 0 || string.IsNullOrWhiteSpace(names[0]);
        }

        private bool NameIsShouted(string printedName)
        {
            return printedName.All(char.IsUpper);
        }

        private string PrintSpokenNames(string[] spokenNames)
        {
            var prefix = "Hello, ";
            var suffix = ".";
            var printedSpokenNames = JoinNames(spokenNames);

            return prefix + printedSpokenNames + suffix;
        }

        private string PrintShoutedNames(string[] shoutedNames)
        {
            var prefix = "HELLO ";
            var suffix = "!";
            var printedShoutedNames = JoinNames(shoutedNames);

            return prefix + printedShoutedNames + suffix;
        }

        private string JoinNames(string[] names)
        {
            if (names.Length == 1)
                return names[0];

            if (names.Length == 2)
                return String.Join(" and ", names);

            return JoinNamesWithCommas(names);
        }

        private string JoinNamesWithCommas(string[] names)
        {
            var namesWithCommas = string.Join(", ", names);
            var lastCommaIndex = namesWithCommas.LastIndexOf(",");

            return namesWithCommas.Insert(lastCommaIndex + 1, " and");
        }
    }
}