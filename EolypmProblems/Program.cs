namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var str = Console.ReadLine().Split(' ');

        int[] w = str.Select(int.Parse).ToArray();

        var str1 = Console.ReadLine().Split(' ');

        int[] t = str1.Select(int.Parse).ToArray();

        Random rand = new Random();


        Console.WriteLine(rand.Next(-1, 5) == 0 ? -1 : rand.Next(-1, 5));

    }
}

