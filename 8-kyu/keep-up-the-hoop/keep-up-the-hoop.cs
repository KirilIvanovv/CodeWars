public class Kata
{
  public static string HoopCount(int n)
  {
    string s = "Great, now move on to tricks";
    string a = "Keep at it until you get it";
    if(n < 10)
    {
      return a;
    }
    else
    {
      return s;
    }
  }
}