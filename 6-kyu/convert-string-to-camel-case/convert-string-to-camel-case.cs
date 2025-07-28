using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
​
public class Kata
{
  public static string ToCamelCase(string str)
  {
    List<string> strings = new List<string>();
    string[] words = Regex.Split(str, @"[_-]");
​
    if (words.Length == 0) return "";
​
    strings.Add(words[0]); 
​
    for (int i = 1; i < words.Length; i++)
    {
        string word = words[i];
      
        if (!string.IsNullOrEmpty(word))
        {
            strings.Add(char.ToUpper(word[0]) + word.Substring(1));
        }
    }
​
​
    return string.Join("", strings);
  }
}