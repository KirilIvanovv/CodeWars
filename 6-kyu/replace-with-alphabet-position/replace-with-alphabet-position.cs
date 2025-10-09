using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
​
public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string result = "";
​
        string text2 = Regex.Replace(text, @"[\d\p{P}\p{S}]", "").ToLower();
        text2 = text2.Replace(" ", "");
        char[] arr_char = text2.ToCharArray();
​
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (char c = 'a'; c <= 'z'; c++)
        {
            dict[c] = c - 'a' + 1;
        }
​
        for (int i = 0; i < arr_char.Length; i++)
        {
            if (dict.ContainsKey(arr_char[i]))
            {
                int val = dict[arr_char[i]];
                result += val.ToString() + " ";
            }
        }
​
        return result.Trim();
    }
}