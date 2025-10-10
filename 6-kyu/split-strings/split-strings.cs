public class SplitString
{
  public static string[] Solution(string str)
  {
    int pairs = str.Length / 2;
    char[] chars = str.ToCharArray();
    string a = "";
​
    if (str.Length % 2 == 0)
    {
      string[] result = new string[pairs];
​
      for (int i = 0; i < pairs; i++)
      {
        for (int j = 0; j <= 1; j++)
        {
          a += chars[i * 2 + j];
        }
        result[i] = a;
        a = "";
      }
​
      return result;
​
    }
    else
    {
      char add = '_';
      char[] chars1 = new char[chars.Length + 1];
​
      for (int i = 0; i < chars.Length; i++)
      {
        chars1[i] = chars[i];
      }
      chars1[chars1.Length - 1] = add;
​
      pairs = chars1.Length / 2;
      string[] result = new string[pairs];
​
      for (int i = 0; i < pairs; i++)
      {
        for (int j = 0; j <= 1; j++)
        {
          a += chars1[i * 2 + j];
        }
        result[i] = a;
        a = "";
      }
​
      return result;
    }    
  }
}