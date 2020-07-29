using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters.Core
{
    public class IteratorCountLettersService : ICountLettersService
    {
        private Dictionary<char, int> _LetterCount;
        private int _TotalLetterCount;

        public IteratorCountLettersService()
        {
            _LetterCount = new Dictionary<char, int>();
            _TotalLetterCount = 0;
        }

        public void ParseString(string inputString)
        {
            try
            {
                ResetDictionary();

                // iterate over the string since all strings are just arrays of chars
                foreach (char c in inputString)
                {
                    // convert lowercase to uppercase
                    char charUpper = Char.ToUpper(c);
                    // check if the int value of the char is between the ASCII values of A - Z
                    if ((int)charUpper >= (int)'A' && (int)charUpper <= (int)'Z')
                    {
                        // if so, increment the dictionary value
                        _LetterCount[charUpper]++;
                        // and increment total letter count
                        _TotalLetterCount++;
                    }
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
