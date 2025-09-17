using System;
public class Triangular
{
    public bool isTriangular(int T)
    {
        if (T < 1) return false; 
​
        long d = 1 + 8L * T;           
        long sqrtD = (long)Math.Sqrt(d);
​
        if (sqrtD * sqrtD != d) return false; 
​
        return (-1 + sqrtD) % 2 == 0; 
    }
}