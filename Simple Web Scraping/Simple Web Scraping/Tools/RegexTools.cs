using System;
using System.Text.RegularExpressions;

namespace Simple_Web_Scraping.Tools
{
    class RegexTools
    {
        String text;

        public void NewDocument(String _text)
        {
            text = _text;
        }

        public String Run(String _regularExpression)
        {
            var regex = new Regex(_regularExpression);
            var match = regex.Match(text);
            String resultRegex = match.ToString();
            Console.WriteLine(resultRegex);
            return resultRegex;
        }

        public String Run(String _regularExpression, String _replaceClearFirst)
        {
            var regex = new Regex(_regularExpression);
            var match = regex.Match(text);
            String resultRegex = match.ToString();
            String resultReplaceFirst = resultRegex.Replace(_replaceClearFirst, "");

            return resultReplaceFirst;
        }

        public String Run(String _regularExpression, String _replaceClearFirst, String _replaceClearSecond)
        {
            var regex = new Regex(_regularExpression);
            var match = regex.Match(text);
            String resultRegex = match.ToString();
            String resultReplaceFirst = resultRegex.Replace(_replaceClearFirst, "");
            String resultReplaceSecond = resultReplaceFirst.Replace(_replaceClearSecond, "");

            return resultReplaceSecond;
        }
    }

}
