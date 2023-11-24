namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var bus = Num(Console.ReadLine());
        var metro = Num(Console.ReadLine());
        var taxi = Num(Console.ReadLine());

        var m = Math.Min(bus, Math.Min(metro, taxi));

        if (bus == m) { Console.WriteLine("Bus"); }
        else if (metro == m) { Console.WriteLine("Metro"); }
        else if (taxi == m) { Console.WriteLine("Taxi"); }
        else if (bus == metro || bus == taxi) { Console.WriteLine("Bus"); }
        else if (metro == taxi && metro < bus) { Console.WriteLine("Metro"); }
        else { Console.WriteLine("Taxi"); }

    }

    static int Num (string input)
    {
        var res = 0;
        int[] nums = input.Split(' ').Select(int.Parse).ToArray();
        foreach (var n in nums) res += n;

        return res;
    }
}

