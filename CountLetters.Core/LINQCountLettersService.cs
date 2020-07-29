using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CountLetters.Core
{
    public class LINQCountLettersService : ICountLettersService
    {
        private Dictionary<char, int> _LetterCount;
        private int _TotalLetterCount;

        public LINQCountLettersService()
        {
            _LetterCount = new Dictionary<char, int>();
            _TotalLetterCount = 0;
        }

        public void ParseString(string inputString)
        {
            try
            {
                ResetDictionary();

                // LINQ
                // Set the where clause to only char letters
                // group by letters and set them to uppercase
                // select a keyvaluepair with the character that is uppercase from the groupby, and the count from the group by
                var valuePairs = inputString.Where(Char.IsLetter).GroupBy(c => Char.ToUpper(c)).Select(c => new KeyValuePair<char, int>(c.Key, c.Count()));

                // iterate over the keyvaluepairs and update the dictionary values
                // and update the total letter count 
                foreach (var item in valuePairs)
                {
                    _LetterCount[item.Key] = item.Value;
                    _TotalLetterCount += item.Value;
                }
            }
            catch
            {
                throw;
            }
        }

        public Dictionary<char, int> GetLetterDictionary()
        {
            return _LetterCount;
        }

        public int GetTotalLetterCount()
        {
            return _TotalLetterCount;
        }

        private void ResetDictionary()
        {
            _LetterCount = new Dictionary<char, int>();

            // Initialize the dictionary
            // Interate over the ASCII values for A - Z and set the key and value to 0
            for (int letter = (int)'A'; letter <= (int)'Z'; letter++)
            {
                _LetterCount.Add((char)letter, 0);
            }

            _TotalLetterCount = 0;
        }
    }
}
