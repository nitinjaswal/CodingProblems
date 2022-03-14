public class RecursiveSumOfDigits
{
    int SumOfDigits(int num)
    {
        if (num == 0)
        {
            return num;
        }
        return SumOfDigits(num / 10) + num % 10;
    }

    int ProuctOfDigits(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        return ProuctOfDigits(num / 10) * (num % 10);
    }
}
