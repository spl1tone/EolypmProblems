namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var k = byte.Parse(Console.ReadLine());

        byte count = 0;

        for (byte i = 1; i <= 50; i++) {
            for (byte j = 1; j <= 50; j++) {
                if (i * j <= k) count++;
            }
        }

        Console.WriteLine(count == 1 ? 1 : count + 1);
    }


}

