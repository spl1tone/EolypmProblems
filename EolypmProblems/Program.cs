namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var input = Console.ReadLine();
        int[] nums = input.Split(' ').Select(int.Parse).ToArray();

        var count = 0;

        for (var i = nums[0]; i <= nums[1]; i++) {
            IsPrime(i, false, ref count);
        }

        Console.WriteLine(count);
    }

    static void IsPrime (int num, bool isRepeat, ref int count)
    {

        var repeatCount = 0;

        if (!isRepeat) {
            for (var i = 1; i <= num; i++) {
                if (num % i == 0) { repeatCount++; }
                if (repeatCount > 2) break;
            }
            IsPrime(ReverseNum(num), true, ref count);
        }
        if (isRepeat) {
            for (var i = 1; i <= num; i++) {
                if (num % i == 0) { repeatCount++; }
                if (repeatCount > 2) break;
            }
        }
    }


    static int ReverseNum (int num)
    {
        var newNum = 0;
        while (num > 0) {
            var digit = num % 10;
            newNum = newNum * 10 + digit;
            num /= 10;
        }
        // Console.WriteLine(newNum);
        return newNum;
    }
}


