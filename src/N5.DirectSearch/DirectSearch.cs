using System;
using System.Collections.Generic; // for lists

namespace DirectSearch;

public static class DirectSearcher
{
    public static void Run(int limit)
    {
        int exponent = 5;

        Console.WriteLine($"Limit is {limit}.");

        List<long> powers = new List<long>(); // declare list of powers

        for (int i = 0; i <= limit; i++) // precalc powers
        {
            long power = (long)Math.Pow(i, exponent);
            powers.Add(power);
        }

        
    }
}
