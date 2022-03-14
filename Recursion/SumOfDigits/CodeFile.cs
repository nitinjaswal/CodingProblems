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
}
