using System;

namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        /*
        Програма зчитує двоцифрове число і виводить через пропуск кожну цифру окремо.

        Вхідні дані
        Натуральне число на проміжку від 10 до 99 включно.
        
        Вихідні дані
        Спочатку першу цифру числа і через пропуск другу.

        */

        var num = byte.Parse(Console.ReadLine());
        Console.WriteLine($"{num / 10} {num % 10}");

        //Runtime
        // 100/100 39ms 24,672MB
    }

}

