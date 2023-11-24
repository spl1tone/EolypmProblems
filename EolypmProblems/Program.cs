namespace EolypmProblems;

internal class Program
{
    static void Main ()
    {
        var input = Console.ReadLine();
        ushort[] nums = input.Split(' ').Select(ushort.Parse).ToArray();

        ushort count = 0;

        for (var i = nums[0]; i <= nums[1]; i++) {
            if (IsPrime(i) == true && IsPrime(ReverseNum(i)) == true) count++;
        }

        Console.WriteLine(count);

        //Runtime
        // 100/100 71ms 25,465MB

    }

    static bool IsPrime (ushort num)
    {
        ushort count = 0;
        if (num == 1)
            return false;

        for (ushort i = 1; i <= num; i++) {
            if (num % i == 0) count++;
            if (count > 2) return false;
        }

        return true;
    }


    static ushort ReverseNum (ushort num)
    {
        ushort newNum = 0;
        while (num > 0) {
            ushort digit = (ushort)(num % 10);
            newNum = (ushort)(newNum * 10 + digit);
            num /= 10;
        }

        return newNum;
    }
}


