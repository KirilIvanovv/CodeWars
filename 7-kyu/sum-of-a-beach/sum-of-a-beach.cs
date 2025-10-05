public class Kata
{
    public static int SumOfABeach(string s)
    {
      s = s.ToLower();
      string[] check = { "sand", "sun", "water", "fish" };
      int count = 0;
        
      foreach (var c in check)
      {
        int index = s.IndexOf(c);
        while (index != -1)
        {
          count++;
          index = s.IndexOf(c, index + 1);
        }
      }
      
      return count;
    }
}