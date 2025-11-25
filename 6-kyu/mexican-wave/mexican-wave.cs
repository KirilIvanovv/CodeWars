using System.Collections.Generic;
​
namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
          List<string> result = new List<string>();
          
          for(int i = 0; i < str.Length; i++)
          {
            if(str[i] == ' ')
            {
              continue;
            }
            
            char[] chars = str.ToCharArray();
            chars[i] = char.ToUpper(chars[i]);
            
            result.Add(new string(chars));
            
            
          }
          
          return result;
        }
    }
}