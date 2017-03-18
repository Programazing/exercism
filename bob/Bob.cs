using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    static void Main(string[] args)
    {
        Hey("WATCH OUT!");
    }

    public static string Hey(string statement)
    {
        Dictionary<int, string> response = new Dictionary<int, string>();
        response.Add(0, "Whatever.");
        response.Add(1, "Whoa, chill out!");
        response.Add(2, "Sure.");
        response.Add(3, "Fine. Be that way!");

        if (ContainsNewLine(statement))
            return response[0].ToString();

        if (IsQuestionMarkNotAtEndOfSentence(statement))
            return response[0].ToString();

        if (IsAllUpperCaseLettersOnly(statement))
            return response[1].ToString();

        if (IsAllUpperCaseLettersAndSymbols(statement))
            return response[1].ToString();

        if (ContainsANumberBeforeAWordAndExclamationPoint(statement))
            return response[1].ToString();

        if (ContainsNumberAndQuestionMark(statement))
            return response[2].ToString();

        if (IsLowerCaseQuestion(statement))
            return response[2].ToString();

        if (ContainsThreeOrMoreSentences(statement))
            return response[2].ToString();

        if (IsStringNullEmptyOrAllWhiteSpace(statement))
            return response[3].ToString();


        return response[0].ToString();
    }

    private static bool ContainsNewLine(string input) => Regex.IsMatch(input, @"\n");

    private static bool IsQuestionMarkNotAtEndOfSentence(string input) => Regex.IsMatch(input, @"\s\?\s");

    private static bool IsAllUpperCaseLettersOnly(string input) => Regex.IsMatch(input, @"^([A-Z]+\s*)+$");

    private static bool IsAllUpperCaseLettersAndSymbols(string input) => Regex.IsMatch(input, @"^([A-Z]+\s*)+\W$");

    private static bool ContainsANumberBeforeAWordAndExclamationPoint(string input) => Regex.IsMatch(input, @"([0-9])+\s*\w*\!");

    private static bool ContainsNumberAndQuestionMark(string input) => Regex.IsMatch(input, @"\d\?");

    private static bool IsLowerCaseQuestion(string input) => Regex.IsMatch(input, @"[a-z]\w\?");

    private static bool HasDoubleWhiteSpaceAfterWord(string input) => Regex.IsMatch(input, @"\w\s\s");

    private static bool ContainsThreeOrMoreSentences(string input)
    {
        string[] sentences = Regex.Split(input, @"[\.\!\?]");
        int count = 0;

        foreach (string sentence in sentences)
        {
            count++;
        }

        if (count >= 3)
            return true;

        return false;
    }

    private static bool IsStringNullEmptyOrAllWhiteSpace(string input) => String.IsNullOrWhiteSpace(input);

    

    

    

    
}
