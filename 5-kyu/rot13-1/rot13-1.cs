using System;
using System.Collections.Generic;
​
public class Kata
{
  public static string Rot13(string message)
  {
    string result = "";
​
    Dictionary<char, int> dict = new Dictionary<char, int>();
​
    for(char  c = 'a'; c <= 'z';  c++)
    {
      dict[c] = c - 'a' + 1;
    }
​
    for (char c = 'A'; c <= 'Z'; c++)
    {
      dict[c] = c - 'A' + 1;
    }
    
    
    foreach(char c in message)
    {
      if (dict.ContainsKey(c))
      {
        int index = dict[c];
        int new_index = index + 13;
​
        if (new_index > 26)
        {
          new_index -= 26;    
        }
​
        char new_char;
​
        if (char.IsUpper(c))
        {
            new_char = (char)('A' + new_index - 1);
        }
        else
        {
          new_char = (char)('a' + new_index - 1);
        }
​
        result += new_char;
      }
​
      else
      {
        result += c; 
      }
    }
    
    return result;
  }
}