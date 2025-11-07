using System;
using System.Collections.Generic;
​
public class DirReduction
{
    public static string[] dirReduc(string[] arr)
    {
        var stack = new Stack<string>();
​
        foreach (var dir in arr)
        {
            if (stack.Count == 0)
            {
                stack.Push(dir);
            }
            else
            {
                string last = stack.Peek();
​
                if ((dir == "NORTH" && last == "SOUTH") ||
                    (dir == "SOUTH" && last == "NORTH") ||
                    (dir == "EAST" && last == "WEST") ||
                    (dir == "WEST" && last == "EAST"))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(dir);
                }
            }
        }
​
        string[] result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}