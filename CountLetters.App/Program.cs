using CountLetters.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // check if args are null or no args are passed
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please pass a string in quotes");
            }
            // check if more than 1 arg
            else if (args.Length > 1)
            {
                Console.WriteLine("Please only pass 1 string in quotes");
            }
            else
            {
                string argString = args[0];

                // iterator based approach
                ICountLettersService countLetterService = new IteratorCountLettersService();

                // Uncomment for LINQ based approach
                //ICountLettersService countLetterService = new LINQCountLettersService();

                countLetterService.ParseString(argString);

                Dictionary<char, int> letterCounts = countLetterService.GetLetterDictionary();

                PrintResults(letterCounts);

                Console.WriteLine("The text has been processed. Total letters counted: {0}", countLetterService.GetTotalLetterCount());
            }
        }

        static void PrintResults(Dictionary<char, int> results)
        {
            StringBuilder letterRow = new StringBuilder();
            StringBuilder valueRow = new StringBuilder();
            StringBuilder border = new StringBuilder();

            letterRow.Append("|");
            valueRow.Append("|");

            foreach (KeyValuePair<char, int> letter in results)
            {
                letterRow.Append(" ").Append(letter.Key).Append(" |");
                valueRow.Append(" ").Append(letter.Value).Append(" |");
            }

            border.Append(new String('-', letterRow.Length));

            Console.WriteLine(border);
            Console.WriteLine(letterRow);
            Console.WriteLine(border);
            Console.WriteLine(valueRow);
            Console.WriteLine(border);
        }


    }
}
