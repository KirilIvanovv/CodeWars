using System;
​
public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
​
  if(cc.Length > 4)
  {
      int str_len = cc.Length - 4;
​
      string result = "";
​
      for (int i = 0; i < str_len; i++)
      {
          result += '#';
      }
​
      for (int j = str_len; j < cc.Length; j++)
      {
          result += cc[j];
      }
​
      return result;
  }
​
  else
  {
      return cc;
  }
  }
}
​