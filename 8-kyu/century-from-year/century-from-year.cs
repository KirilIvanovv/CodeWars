public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    int result;
    
    if (year % 100 == 0)
    {
      result = (year / 100);
    }
    
    else
    {
       result = (year / 100) + 1;
    }
    
    return result;
  }
}