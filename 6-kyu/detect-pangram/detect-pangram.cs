using System;
using System.Linq;
using System.Text.RegularExpressions;
​
public static class Kata
{
  public static bool IsPangram(string str)
  {
    string str_clean = Regex.Replace(str, @"[^a-zA-Z\s]", "").Replace(" ","").ToLower();
    
    char[] chars = str_clean.Distinct().ToArray();
    
    if(chars.Length == 26)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}