using System;
using System.Collections.Generic;
​
public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
      string numStr = num.ToString();
      char[] chars = numStr.ToCharArray();
      List <string> result = new List<string>();
      string a = "";
      int b = numStr.Length - 1;
      
      for(int i = 0; i < numStr.Length; i++)
      {
        if(chars[i]!= '0')
        {
          a += chars[i];
          for(int j = 0; j < b; j++)
          {
            a += "0";
          }
          b -= 1;
          result.Add(a);
          a = "";
        }
        else
        {
          b -= 1;
        }
​
      }
      
      return string.Join(" + ", result);
      
      
    }
}