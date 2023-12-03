namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var m = byte.Parse(Console.ReadLine());
        var n = byte.Parse(Console.ReadLine());

        Console.WriteLine(m - n * 3);
    }
}

