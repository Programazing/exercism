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

        if (IsAllUpperCaseLettersOnly(statement) == true)
            return response[1].ToString();

        if (IsAllUpperCaseLettersAndSymbols(statement) == true)
            return response[1].ToString();

        if (ContainsNumberAndQuestionMark(statement) == true)
            return response[2].ToString();

        if (IsLowerCaseQuestion(statement) == true)
            return response[2].ToString();

        //if (HasDoubleWhiteSpaceAfterWord(statement) == true)
        //    return response[2].ToString();

        //if (IsStringEmpty(statement) == true)
        //    return response[3].ToString();

        //if (IsFourWhiteSpaces(statement) == true)
        //    return response[2].ToString();


        return response[0].ToString();
    }



    static bool IsAllUpperCaseLettersOnly(string input)
    {
        var pattern = new Regex(@"^([A-Z]+\s*)+$");
        var match = pattern.Match(input);

        if (match.Success)
            return true;

        return false;

    }

    static bool IsAllUpperCaseLettersAndSymbols(string input)
    {
        var pattern = new Regex(@"^([A-Z]+\s*)+\W$");
        var match = pattern.Match(input);

        if (match.Success)
            return true;

        return false;
    }

    private static bool HasDoubleWhiteSpaceAfterWord(string input) => Regex.IsMatch(input, @"\w\s\s");

    private static bool ContainsNumberAndQuestionMark(string input) => Regex.IsMatch(input, @"\d\?");

    private static bool IsLowerCaseQuestion(string input) => Regex.IsMatch(input, @"[a-z]\w\?");
}
