using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters.Core
{
    // created interface so we can use for DI later
    public interface ICountLettersService
    {
        public void ParseString(string inputString);
        public Dictionary<char, int> GetLetterDictionary();
        public int GetTotalLetterCount();
    }
}
