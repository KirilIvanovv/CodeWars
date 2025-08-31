public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    int dist = 0;
    int count = 0;
​
    foreach (string c in walk)
    {
        if (c == "e")
        {
            dist -= 2;
            count++;
        }
        else if (c == "w")
        {
            dist += 2;
            count++;
        }
        else if (c == "n")
        {
            dist += 1;
            count++;
        }
        else if (c == "s")
        {
            dist -= 1;
            count++;
        }
    }
​
    if (count == 10 && dist == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
  }
}