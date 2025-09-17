using System;
using System.Collections.Generic;
​
public class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
            return "now";
​
        int years = seconds / 31536000;
        seconds %= 31536000;
​
        int days = seconds / 86400;
        seconds %= 86400;
​
        int hours = seconds / 3600;
        seconds %= 3600;
​
        int minutes = seconds / 60;
        seconds %= 60;
​
        var parts = new List<string>();
​
        if (years > 0) parts.Add(years == 1 ? "1 year" : $"{years} years");
      
        if (days > 0) parts.Add(days == 1 ? "1 day" : $"{days} days");
        if (hours > 0) parts.Add(hours == 1 ? "1 hour" : $"{hours} hours");
      
        if (minutes > 0) parts.Add(minutes == 1 ? "1 minute" : $"{minutes} minutes");
        if (seconds > 0) parts.Add(seconds == 1 ? "1 second" : $"{seconds} seconds");
​
        if (parts.Count == 1)
            return parts[0];
​
        return string.Join(", ", parts.GetRange(0, parts.Count - 1)) + " and " + parts[^1];
    }
}
​