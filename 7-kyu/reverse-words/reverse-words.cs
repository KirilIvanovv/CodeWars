using System;
using System.Linq;
​
public static class Kata
{
  public static string ReverseWords(string str)
  {
    string[] strings = str.Split(' ');
    
    for(int i = 0; i < strings.Length; i++)
    {
      strings[i] = new string(strings[i].Reverse().ToArray());
    }
    
    string result = string.Join(" ", strings);
    
    return result;
  }
}