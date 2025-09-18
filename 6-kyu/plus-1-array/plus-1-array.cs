using System;
using System.Linq;
​
namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
    {
      
    if (num == null || num.Length == 0) 
      {
        return null;
      }
​
    foreach (int d in num)
    {
        if (d < 0 || d > 9)
        {
          return null; 
        }        
    }
      
    int carry = 1;
​
    for(int i = num.Length - 1;  i >= 0; i--)
    {
        int sum = num[i] + carry;
        if (sum == 10)
        {
            num[i] = 0;
            carry = 1;
        }
        else
        {
            num[i] = sum;
            carry = 0;   
            break;
        }
​
    }
​
    if (carry == 1)
    {
        int[] result = new int[num.Length + 1];
        result[0] = 1;
        Array.Copy(num, 0, result, 1, num.Length);
        return result;
    }
    else
    {
      return num;
    }      
      
    }
  }
}