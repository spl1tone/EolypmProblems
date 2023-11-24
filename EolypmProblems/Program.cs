namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        /*
         Перший рядок мiстить одне цiле число a (1 <= a <= 100) — кiлькiсть гривень, якi є в Алiси.
         Другий рядок мiстить одне цiле число b (1 <= b <= 100) — кiлькiсть гривень, якi винен Петрик
         Алiсi.
         Третiй рядок мiстить одне цiле число c (1 <= c <= 100) — кiлькiсть гривень, якi винна Свiтлана
         Алiсi.
         Четвертий рядок мiстить одне цiле число d (1 <= d <= 100) — кiлькiсть гривень, якi винна Алiса
         Ромчику.
         Гарантується, що в Алiси в кiнцi буде невiд’ємна кiлькiсть гривень.
         */

        byte a, b, c, d;
        a = byte.Parse(Console.ReadLine());
        b = byte.Parse(Console.ReadLine());
        c = byte.Parse(Console.ReadLine());
        d = byte.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c - d);
    }

}

