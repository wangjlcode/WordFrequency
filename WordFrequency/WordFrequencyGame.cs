using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace WordFrequency
{
    public class WordFrequencyGame
    {
        private const string SpacePattern = @"\s+";

        public string GetResult(string inputStr)
        {
            string[] words = Regex.Split(inputStr, SpacePattern);

            var wordCountStringList = words
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key + " " + x.Count())
                .ToList();

            return string.Join("\n", wordCountStringList);
        }
    }
}
