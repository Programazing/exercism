using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercism.Bob
{
    public static class Bob
    {
        static void Main(string[] args)
        {
            Hey("Wait! Hang on. Are you going to be OK?");
        }

        public static string Hey(string statement)
        {
            string whatever = "Whatever.";
            string chillOut = "Whoa, chill out!";
            string sure = "Sure.";
            string fine = "Fine. Be that way!";

            if (ContainsNewLine(statement))
                return whatever;

            if (IsQuestionMarkNotAtEndOfSentence(statement))
                return whatever;

            if (IsAllUpperCaseLettersOnly(statement))
                return chillOut;

            if (IsAllUpperCaseLettersAndSymbols(statement))
                return chillOut;

            if (Contains_A_Number_Before_A_Word_And_ExclamationPoint(statement))
                return chillOut;

            if (ContainsNumberAndQuestionMark(statement))
                return sure;

            if (IsLowerCaseQuestion(statement))
                return sure;

            if (ContainsThreeOrMoreSentences(statement))
                return sure;

            if (IsStringNullEmptyOrAllWhiteSpace(statement))
                return fine.ToString();


            return whatever;
        }

        private static bool ContainsNewLine(string input) => Regex.IsMatch(input, @"\n");

        private static bool IsQuestionMarkNotAtEndOfSentence(string input) => Regex.IsMatch(input, @"\s\?\s");

        private static bool IsAllUpperCaseLettersOnly(string input) => Regex.IsMatch(input, @"^([A-Z]+\s*)+$");

        private static bool IsAllUpperCaseLettersAndSymbols(string input) => Regex.IsMatch(input, @"^([A-Z]+\s*)+\W$");

        private static bool Contains_A_Number_Before_A_Word_And_ExclamationPoint(string input) => Regex.IsMatch(input, @"([0-9])+\s*\w*\!");

        private static bool ContainsNumberAndQuestionMark(string input) => Regex.IsMatch(input, @"\d\?");

        private static bool IsLowerCaseQuestion(string input) => Regex.IsMatch(input, @"[a-z]\w\?");

        private static bool HasDoubleWhiteSpaceAfterWord(string input) => Regex.IsMatch(input, @"\w\s\s");

        private static bool ContainsThreeOrMoreSentences(string input) => input.Split(new[] { '.', '!', '?' }).Count() >= 3;

        private static bool IsStringNullEmptyOrAllWhiteSpace(string input) => String.IsNullOrWhiteSpace(input);

    } 
}
