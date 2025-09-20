public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
    int smile = 0;
    
    foreach(string c in smileys)
    {
      if(c.Length == 2)
      {
        if ((c[0] == ':' || c[0] == ';') && (c[1] == ')' || c[1] == 'D'))
        {
          smile++;
        }
      }
      else if(c.Length == 3)
      {
        if ((c[0] == ':' || c[0] == ';') && (c[1] == '-' || c[1] == '~') && (c[2] == ')' || c[2] == 'D'))
        {
          smile++;
        }
      }
    }
    
    return smile;
  }
}