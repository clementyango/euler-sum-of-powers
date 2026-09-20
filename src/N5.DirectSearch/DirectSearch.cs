namespace DirectSearch;

public static class DirectSearcher
{
    public static void Run(int limit, int exponent)
    {
        Console.WriteLine($"Limit is {limit}.");

        long[] powers = new long[limit + 1];

        for (int i = 0; i <= limit; i++) // precalc powers up to limit
        {
            powers[i] = (long)Math.Pow(i, exponent);
        }

        for (long a = 1; a <= limit; a++)
        {
           for (long b = a; b <= limit; b++)
            {
               for (long c = b; c <= limit; c++)
                {
                    for (long d = c; d <= limit; d++)
                    {
                        long sum = powers[(int)a] + powers[(int)b] + powers[(int)c] + powers[(int)d];
                        double sumRoot = Math.Pow(sum, 1.0 / exponent);
                        int eCandidate = (int)Math.Round(sumRoot);
                        if (eCandidate <= limit)
                        {
                            if (powers[eCandidate] == sum)
                            {
                                Console.WriteLine($"Counterexample: a = {a} b = {b} c = {c} d = {d} e = {eCandidate}");
                            }
                        }
                 }
               }
            }
        }


    }

}
