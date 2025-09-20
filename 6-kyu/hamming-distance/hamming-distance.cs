using System;
​
public class Hamming
{
  public static int Distance(string a, string b)
  {   
    char[] arr_a = a.ToCharArray();
    char[] arr_b = b.ToCharArray();
    
    int result = 0;
    
    for(int i = 0; i < arr_a.Length; i++)
    {
      if(arr_a[i] != arr_b[i])
      {
        result++;
      }
    }
    
    return result;
  }
}