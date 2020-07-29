using CountLetters.Core;
using System;
using System.Collections.Generic;
using Xunit;

namespace CountLetters.Test
{
    public class CountLettersTests
    {
        [Fact]
        public void CountLetters_ExampleTest_Returns2A2B3C()
        {
            // Arrange
            string str = "Cbb acCA";
            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act
            iter.ParseString(str);
            countIter = iter.GetLetterDictionary();

            linq.ParseString(str);
            countLinq = linq.GetLetterDictionary();

            // Assert
            Assert.Equal(2, countIter['A']);
            Assert.Equal(2, countIter['B']);
            Assert.Equal(3, countIter['C']);

            Assert.Equal(2, countLinq['A']);
            Assert.Equal(2, countLinq['B']);
            Assert.Equal(3, countLinq['C']);
        }

        [Fact]
        public void CountLetters_NonLetters_ReturnsOnlyLetterCounts()
        {
            // Arrange
            string str = "aABb`~!@#$%^&*()-_=+1234567890\\|]}[{'\";:/?.>,< CcDd";
            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act
            iter.ParseString(str);
            countIter = iter.GetLetterDictionary();

            linq.ParseString(str);
            countLinq = linq.GetLetterDictionary();

            // Assert
            Assert.Equal(2, countIter['A']);
            Assert.Equal(2, countIter['B']);
            Assert.Equal(2, countIter['C']);
            Assert.Equal(2, countIter['D']);

            Assert.Equal(2, countLinq['A']);
            Assert.Equal(2, countLinq['B']);
            Assert.Equal(2, countLinq['C']);
            Assert.Equal(2, countLinq['D']);
        }

        [Fact]
        public void CountLetters_AThruZ_Returns1LetterEach()
        {
            // Arrange
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act
            iter.ParseString(str);
            countIter = iter.GetLetterDictionary();

            linq.ParseString(str);
            countLinq = linq.GetLetterDictionary();

            // Assert
            Assert.Equal(1, countIter['A']);
            Assert.Equal(1, countIter['B']);
            Assert.Equal(1, countIter['C']);
            Assert.Equal(1, countIter['D']);
            Assert.Equal(1, countIter['E']);
            Assert.Equal(1, countIter['F']);
            Assert.Equal(1, countIter['G']);
            Assert.Equal(1, countIter['H']);
            Assert.Equal(1, countIter['I']);
            Assert.Equal(1, countIter['J']);
            Assert.Equal(1, countIter['K']);
            Assert.Equal(1, countIter['L']);
            Assert.Equal(1, countIter['M']);
            Assert.Equal(1, countIter['N']);
            Assert.Equal(1, countIter['O']);
            Assert.Equal(1, countIter['P']);
            Assert.Equal(1, countIter['Q']);
            Assert.Equal(1, countIter['R']);
            Assert.Equal(1, countIter['S']);
            Assert.Equal(1, countIter['T']);
            Assert.Equal(1, countIter['U']);
            Assert.Equal(1, countIter['V']);
            Assert.Equal(1, countIter['W']);
            Assert.Equal(1, countIter['X']);
            Assert.Equal(1, countIter['Y']);
            Assert.Equal(1, countIter['Z']);

            Assert.Equal(1, countLinq['A']);
            Assert.Equal(1, countLinq['B']);
            Assert.Equal(1, countLinq['C']);
            Assert.Equal(1, countLinq['D']);
            Assert.Equal(1, countLinq['E']);
            Assert.Equal(1, countLinq['F']);
            Assert.Equal(1, countLinq['G']);
            Assert.Equal(1, countLinq['H']);
            Assert.Equal(1, countLinq['I']);
            Assert.Equal(1, countLinq['J']);
            Assert.Equal(1, countLinq['K']);
            Assert.Equal(1, countLinq['L']);
            Assert.Equal(1, countLinq['M']);
            Assert.Equal(1, countLinq['N']);
            Assert.Equal(1, countLinq['O']);
            Assert.Equal(1, countLinq['P']);
            Assert.Equal(1, countLinq['Q']);
            Assert.Equal(1, countLinq['R']);
            Assert.Equal(1, countLinq['S']);
            Assert.Equal(1, countLinq['T']);
            Assert.Equal(1, countLinq['U']);
            Assert.Equal(1, countLinq['V']);
            Assert.Equal(1, countLinq['W']);
            Assert.Equal(1, countLinq['X']);
            Assert.Equal(1, countLinq['Y']);
            Assert.Equal(1, countLinq['Z']);

        }

        [Fact]
        public void CountLetters_AThruZaThruz_Returns2LettersEach()
        {
            // Arrange
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act
            iter.ParseString(str);
            countIter = iter.GetLetterDictionary();

            linq.ParseString(str);
            countLinq = linq.GetLetterDictionary();

            // Assert
            Assert.Equal(2, countIter['A']);
            Assert.Equal(2, countIter['B']);
            Assert.Equal(2, countIter['C']);
            Assert.Equal(2, countIter['D']);
            Assert.Equal(2, countIter['E']);
            Assert.Equal(2, countIter['F']);
            Assert.Equal(2, countIter['G']);
            Assert.Equal(2, countIter['H']);
            Assert.Equal(2, countIter['I']);
            Assert.Equal(2, countIter['J']);
            Assert.Equal(2, countIter['K']);
            Assert.Equal(2, countIter['L']);
            Assert.Equal(2, countIter['M']);
            Assert.Equal(2, countIter['N']);
            Assert.Equal(2, countIter['O']);
            Assert.Equal(2, countIter['P']);
            Assert.Equal(2, countIter['Q']);
            Assert.Equal(2, countIter['R']);
            Assert.Equal(2, countIter['S']);
            Assert.Equal(2, countIter['T']);
            Assert.Equal(2, countIter['U']);
            Assert.Equal(2, countIter['V']);
            Assert.Equal(2, countIter['W']);
            Assert.Equal(2, countIter['X']);
            Assert.Equal(2, countIter['Y']);
            Assert.Equal(2, countIter['Z']);

            Assert.Equal(2, countLinq['A']);
            Assert.Equal(2, countLinq['B']);
            Assert.Equal(2, countLinq['C']);
            Assert.Equal(2, countLinq['D']);
            Assert.Equal(2, countLinq['E']);
            Assert.Equal(2, countLinq['F']);
            Assert.Equal(2, countLinq['G']);
            Assert.Equal(2, countLinq['H']);
            Assert.Equal(2, countLinq['I']);
            Assert.Equal(2, countLinq['J']);
            Assert.Equal(2, countLinq['K']);
            Assert.Equal(2, countLinq['L']);
            Assert.Equal(2, countLinq['M']);
            Assert.Equal(2, countLinq['N']);
            Assert.Equal(2, countLinq['O']);
            Assert.Equal(2, countLinq['P']);
            Assert.Equal(2, countLinq['Q']);
            Assert.Equal(2, countLinq['R']);
            Assert.Equal(2, countLinq['S']);
            Assert.Equal(2, countLinq['T']);
            Assert.Equal(2, countLinq['U']);
            Assert.Equal(2, countLinq['V']);
            Assert.Equal(2, countLinq['W']);
            Assert.Equal(2, countLinq['X']);
            Assert.Equal(2, countLinq['Y']);
            Assert.Equal(2, countLinq['Z']);
        }

        [Fact]
        public void CountLetters_ReallyLongString_Returns100LettersEach()
        {
            // Arrange
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act
            iter.ParseString(str);
            countIter = iter.GetLetterDictionary();

            linq.ParseString(str);
            countLinq = linq.GetLetterDictionary();

            // Assert
            Assert.Equal(100, countIter['A']);
            Assert.Equal(100, countIter['B']);
            Assert.Equal(100, countIter['C']);
            Assert.Equal(100, countIter['D']);
            Assert.Equal(100, countIter['E']);
            Assert.Equal(100, countIter['F']);
            Assert.Equal(100, countIter['G']);
            Assert.Equal(100, countIter['H']);
            Assert.Equal(100, countIter['I']);
            Assert.Equal(100, countIter['J']);
            Assert.Equal(100, countIter['K']);
            Assert.Equal(100, countIter['L']);
            Assert.Equal(100, countIter['M']);
            Assert.Equal(100, countIter['N']);
            Assert.Equal(100, countIter['O']);
            Assert.Equal(100, countIter['P']);
            Assert.Equal(100, countIter['Q']);
            Assert.Equal(100, countIter['R']);
            Assert.Equal(100, countIter['S']);
            Assert.Equal(100, countIter['T']);
            Assert.Equal(100, countIter['U']);
            Assert.Equal(100, countIter['V']);
            Assert.Equal(100, countIter['W']);
            Assert.Equal(100, countIter['X']);
            Assert.Equal(100, countIter['Y']);
            Assert.Equal(100, countIter['Z']);

            Assert.Equal(100, countLinq['A']);
            Assert.Equal(100, countLinq['B']);
            Assert.Equal(100, countLinq['C']);
            Assert.Equal(100, countLinq['D']);
            Assert.Equal(100, countLinq['E']);
            Assert.Equal(100, countLinq['F']);
            Assert.Equal(100, countLinq['G']);
            Assert.Equal(100, countLinq['H']);
            Assert.Equal(100, countLinq['I']);
            Assert.Equal(100, countLinq['J']);
            Assert.Equal(100, countLinq['K']);
            Assert.Equal(100, countLinq['L']);
            Assert.Equal(100, countLinq['M']);
            Assert.Equal(100, countLinq['N']);
            Assert.Equal(100, countLinq['O']);
            Assert.Equal(100, countLinq['P']);
            Assert.Equal(100, countLinq['Q']);
            Assert.Equal(100, countLinq['R']);
            Assert.Equal(100, countLinq['S']);
            Assert.Equal(100, countLinq['T']);
            Assert.Equal(100, countLinq['U']);
            Assert.Equal(100, countLinq['V']);
            Assert.Equal(100, countLinq['W']);
            Assert.Equal(100, countLinq['X']);
            Assert.Equal(100, countLinq['Y']);
            Assert.Equal(100, countLinq['Z']);
        }

        [Fact]
        public void CountLetters_EmptyString_ReturnsNone()
        {
            // Arrange
            string str = "";
            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act
            iter.ParseString(str);
            countIter = iter.GetLetterDictionary();

            linq.ParseString(str);
            countLinq = linq.GetLetterDictionary();

            // Assert
            Assert.Equal(0, countIter['A']);
            Assert.Equal(0, countIter['B']);
            Assert.Equal(0, countIter['C']);
            Assert.Equal(0, countIter['D']);
            Assert.Equal(0, countIter['E']);
            Assert.Equal(0, countIter['F']);
            Assert.Equal(0, countIter['G']);
            Assert.Equal(0, countIter['H']);
            Assert.Equal(0, countIter['I']);
            Assert.Equal(0, countIter['J']);
            Assert.Equal(0, countIter['K']);
            Assert.Equal(0, countIter['L']);
            Assert.Equal(0, countIter['M']);
            Assert.Equal(0, countIter['N']);
            Assert.Equal(0, countIter['O']);
            Assert.Equal(0, countIter['P']);
            Assert.Equal(0, countIter['Q']);
            Assert.Equal(0, countIter['R']);
            Assert.Equal(0, countIter['S']);
            Assert.Equal(0, countIter['T']);
            Assert.Equal(0, countIter['U']);
            Assert.Equal(0, countIter['V']);
            Assert.Equal(0, countIter['W']);
            Assert.Equal(0, countIter['X']);
            Assert.Equal(0, countIter['Y']);
            Assert.Equal(0, countIter['Z']);

            Assert.Equal(0, countLinq['A']);
            Assert.Equal(0, countLinq['B']);
            Assert.Equal(0, countLinq['C']);
            Assert.Equal(0, countLinq['D']);
            Assert.Equal(0, countLinq['E']);
            Assert.Equal(0, countLinq['F']);
            Assert.Equal(0, countLinq['G']);
            Assert.Equal(0, countLinq['H']);
            Assert.Equal(0, countLinq['I']);
            Assert.Equal(0, countLinq['J']);
            Assert.Equal(0, countLinq['K']);
            Assert.Equal(0, countLinq['L']);
            Assert.Equal(0, countLinq['M']);
            Assert.Equal(0, countLinq['N']);
            Assert.Equal(0, countLinq['O']);
            Assert.Equal(0, countLinq['P']);
            Assert.Equal(0, countLinq['Q']);
            Assert.Equal(0, countLinq['R']);
            Assert.Equal(0, countLinq['S']);
            Assert.Equal(0, countLinq['T']);
            Assert.Equal(0, countLinq['U']);
            Assert.Equal(0, countLinq['V']);
            Assert.Equal(0, countLinq['W']);
            Assert.Equal(0, countLinq['X']);
            Assert.Equal(0, countLinq['Y']);
            Assert.Equal(0, countLinq['Z']);
        }

        [Fact]
        public void CountLetters_NULL_ThrowsException()
        {
            // Arrange
            string str = null;
            Dictionary<char, int> countIter = new Dictionary<char, int>();
            Dictionary<char, int> countLinq = new Dictionary<char, int>();
            IteratorCountLettersService iter = new IteratorCountLettersService();
            LINQCountLettersService linq = new LINQCountLettersService();

            // Act/Assert
            Assert.Throws<NullReferenceException>(() => iter.ParseString(str));

            Assert.Throws<ArgumentNullException>(() => linq.ParseString(str));
        }
    }
}
