using System.Collections.Generic;

namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var n = ushort.Parse(Console.ReadLine());
        var m = ushort.Parse(Console.ReadLine());

        ushort res = 1;

        while (n > 0 || m > 0) {
            if (n > 1) {
                n--;
                res++;
            }
            else if (m > 1) {
                m--;
                res++;
            }
            else {
                res++;
                break;
            }
        }

        Console.WriteLine(res);
    }

}

