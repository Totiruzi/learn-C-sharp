using System;
using System.Text.RegularExpressions;

// https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?redirectedfrom=MSDN&view=netframework-4.8
namespace runoob
{
    class RegularExpression
    {
        public static void TestRegexp()
        {
            Regex regexp = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string text = "a b c d a a ab ab cde cde";
            MatchCollection matches = regexp.Matches(text);

            Console.WriteLine("{0} matches found in: {1}", matches.Count, text);
            foreach(Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at position {1} and {2}",
                    groups["word"].Value,
                    groups[0].Index,
                    groups[1].Index);
            }
        }
    }
}
