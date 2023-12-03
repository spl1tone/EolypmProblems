namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var str = Console.ReadLine().Split(' ');
        var d1 = byte.Parse(str[0]);
        var m1 = byte.Parse(str[1]);

        var str1 = Console.ReadLine().Split(' ');
        var d2 = byte.Parse(str1[0]);
        var m2 = byte.Parse(str1[1]);

        if (d1 + 13 > 30) {
            d1 = (byte)(d1 + 13 - 30);
            if (m1 % 12 == 0) m1 = 1;
            else m1++;
        }
        else {
            d1 += 13;
        }

        Console.WriteLine(d1 == d2 && m1 == m2 ? "Same birthday!" : "Not the same");

    }
}

