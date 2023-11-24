namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var input = Console.ReadLine().Split(' ');

        ushort a = ushort.Parse(input[0]); // Робочі дні
        ushort b = ushort.Parse(input[1]); // Вихідні дні
        ushort n = ushort.Parse(input[2]); // Не працює в конкретний день
        ushort m = ushort.Parse(input[3]); // День в який він виконує подвійну роботу
        ushort k = ushort.Parse(input[4]); // Місяць

        ushort currentDay = 1;
        ushort result = 0;

        while (currentDay <= k) {

            for (var i = 1; i <= a && currentDay <= k; i++) {

                if (currentDay % n == 0) { result += 0; }
                else if (currentDay % m == 0) { result += 2; }
                else { result += 1; }

                currentDay++;
            }

            currentDay += b;
        }

        Console.WriteLine(result);
    }
}

