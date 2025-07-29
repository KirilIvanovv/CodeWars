using System;
​
public static class Kata
{
  public static string GenerateShape(int n)
  {
    string str = "";
​
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            str += "+";
​
        }
​
        if(i != n - 1)
        {
            str += "\n";
        }
    }
    
    return str;
  }
}