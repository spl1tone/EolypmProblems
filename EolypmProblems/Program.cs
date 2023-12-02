namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {

        var (n, m) = ParsePair(Console.ReadLine());

        int[] ai = new int[n];
        ai = Parsing(ai, n);

        int[] bi = new int[m];
        bi = Parsing(bi, m);

        int e = int.Parse(Console.ReadLine());


        int DanyaCount = PointCount(ai, e);
        int DianaCount = PointCount(bi, e);

        if (DanyaCount > DianaCount) {
            Console.WriteLine($"Danya\n{DanyaCount}:{DianaCount}");
        }
        else if (DanyaCount < DianaCount) {
            Console.WriteLine($"Diana\n{DianaCount}:{DanyaCount}");
        }
        else {
            Console.WriteLine($"Draw\n{DanyaCount}:{DianaCount}");
        }



    }

    static int PointCount (int[] nums, int e)
    {
        int taskCount = 0;
        int lastE = e;

        for (int i = 0; i < nums.Length; i++) {
            while (nums[i] > 0 && e != 0) {
                taskCount += Math.Min(nums[i], e);
                nums[i] -= e;
                e -= 1;
                if (e == 0 && nums[i] > 0) { lastE = 0; break; }
                else if (e == 0) { break; }

            }
            e = lastE;
        }

        return taskCount;
    }

    static (int, int) ParsePair (string input)
    {
        var str = input.Split(' ');
        return (int.Parse(str[0]), int.Parse(str[1]));
    }

    static int[] Parsing (int[] nums, int count)
    {
        var str = Console.ReadLine();
        return str.Split(' ').Select(int.Parse).ToArray();
    }
}

