using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
​
public class TopWords
{
    public static List<string> Top3(string s)
    {
        s = Regex.Replace(s.ToLower(), @"[^a-z']+", " ");
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Where(w => Regex.IsMatch(w, @"[a-z]"))
                     .ToList();
​
        Dictionary<string, int> freq = new();
        foreach (var word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }
​
        return freq
            .OrderByDescending(x => x.Value)
            .Take(3)
            .Select(x => x.Key)
            .ToList();
    }
}