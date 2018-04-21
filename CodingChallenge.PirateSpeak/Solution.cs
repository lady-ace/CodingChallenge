using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            var result = new List<string>();

            //Solution 1:
            var jumbleSorted = new string(jumble.ToCharArray().OrderBy(x => x).ToArray());

            foreach (var word in dictionary)
            {
                if (word.Length == jumble.Length) 
                {
                    var wordSorted = word.ToCharArray().OrderBy(x => x).ToString();
                    if (string.Equals(wordSorted, jumbleSorted, StringComparison.OrdinalIgnoreCase))
                        result.Add(word);
                }

            //Solution 2:
            //var jumbleChar = jumble.ToCharArray();

            //foreach (var word in dictionary)
            //{
                //if (word.Length == jumble.Length)
                //{
                //    var wordChar = word.ToCharArray().ToList();
                //    var numberOfMatches = 0;

                //    foreach (var character in jumbleChar)
                //    {
                //        if (wordChar.Contains(character))
                //        {
                //            wordChar.Remove(character);
                //            numberOfMatches++;
                //        }
                //    }

                //    if (numberOfMatches == jumble.Length)
                //    result.Add(word);
                //}
            }

            return result.ToArray();
        }
    }
}