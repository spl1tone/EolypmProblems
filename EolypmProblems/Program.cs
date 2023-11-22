namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        /*
        Професор Самодєлкін вирішив змайструвати об'ємну модель кубиків з сірників використовуючи сірники для ребер кубиків. Довжина ребра кожного кубика дорівнює одному сірнику. Для побудови моделі трьох кубів в нього пішло 28 сірників.
        Яку найменшу кількість сірників потрібно Самодєлкіну для побудови моделі з N кубиків.
        Всі числа задачі не перевищують 2 * 10^9.
        Вхідні дані
        Одне число - кількість кубиків.
        Вихідні дані
        Одне число кількість сірників.
         */


        var cubeCount = int.Parse(Console.ReadLine());

        // Console.WriteLine(cubeCount * cubeCount * 12 - (cubeCount - 1) * 4);

        // var cubeCount = 9;

        /*    const int cubeRebr = 4;

            int similarRebrs = 0;

            if (cubeCount / 2 % 2 == 0 && cubeCount != 1) similarRebrs += 4;
            if (cubeCount / 3 % 3 == 0 && cubeCount != 1) similarRebrs += 2 * (cubeCount - 5);

            int result = (cubeCount * cubeRebr) - similarRebrs; //32 but need 24

            Console.WriteLine(result);*/
        Console.ReadLine();
    }
}

