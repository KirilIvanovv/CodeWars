  using System;
  public static class Clock
  {
    public static int Past(int h, int m, int s)
    {
      int result = 0;
      result += s * 1000;
      result += m * 60 * 1000;
      result += h * 3600 * 1000;
      return result;
    }
  }
​