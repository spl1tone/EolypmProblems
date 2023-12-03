namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var str = Console.ReadLine().Split(' ');
        int height = int.Parse(str[0]); // height
        int width = int.Parse(str[1]); // width


        char[,] ornament = new char[height, width];

        int startIndex = 0;
        int lastIndex = width - 1;

        for (int a = 0; a < ornament.GetLength(0); a++) {

            if (startIndex == (width - 1) && lastIndex == 0) {
                (startIndex, lastIndex) = (lastIndex, startIndex);
            }

            for (int b = 0; b < ornament.GetLength(1); b++) {
                if (startIndex == b || lastIndex == b) {
                    ornament[a, b] = 'x';
                }
                else {
                    ornament[a, b] = '.';
                }

            }

            startIndex++;
            lastIndex--;

        }

        for (int i = 0; i < ornament.GetLength(0); i++) {
            for (int j = 0; j < ornament.GetLength(1); j++) {
                Console.Write(ornament[i, j]);
            }
            Console.WriteLine();
        }

    }

}