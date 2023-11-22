namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        // x1 y1 r1, x2 y2 r2

        var str = Console.ReadLine();
        float[] circles = new float[6];

        CirclesMassive(str, ref circles);

        if (circles[0] == circles[3] && circles[1] == circles[4] && circles[2] == circles[5]) Console.WriteLine(1);


    }

    static void CirclesMassive (string str, ref float[] circles)
    {
        string[] newStr = str.Split(' ');

        for (int i = 0; i < 6; i++) {
            circles[i] = float.Parse(newStr[i]);
        }
    }
}

