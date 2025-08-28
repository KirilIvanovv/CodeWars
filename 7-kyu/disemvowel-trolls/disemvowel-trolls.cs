using System;
using System.Linq;
​
public static class Kata
{
    public static string Disemvowel(string str)
    {
      char[] chars = {'a', 'e', 'u', 'i', 'o'};
      string result = "";
      
      foreach(char c in str)
      {
        if(!chars.Contains(char.ToLower(c)))
        {
          result += c;
        }
      }
      return result;
    }
}