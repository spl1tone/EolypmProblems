using System.Collections.Generic;

namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int res = m + (m - 1) * (n - 2);

        Console.WriteLine(res);
    }

}

