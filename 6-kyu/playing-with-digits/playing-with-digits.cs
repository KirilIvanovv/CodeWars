using System;
​
public class DigPow 
{
  public static long digPow(int n, int p) 
  {
    long result = 0;
    string num = n.ToString();
    char[] nums = num.ToCharArray();
    int[] arr = new int[nums.Length];
    
    for(int i = 0; i < num.Length; i++)
    {
      arr[i] = Int32.Parse(nums[i].ToString());
    }
    
    for(int i = 0; i < arr.Length; i++)
    {
      result += (long)Math.Pow(arr[i], p);
      p++;
    }
    
    if(result % n == 0)
    {
      result = result / n;
      return result;
    }
    else{ return -1; }
​
    
  }
}