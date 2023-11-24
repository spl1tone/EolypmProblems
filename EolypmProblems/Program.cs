namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var input = Console.ReadLine();
        ushort[] nums = input.Split(' ').Select(ushort.Parse).ToArray();

        Console.WriteLine(

       ((nums[0] - nums[2] + (nums[1] - nums[3]) * 2) * 100) / (nums[0] + nums[1] * 2) >= 51 ? "YES" : "NO"

            );

    }
}

