public class SolutionMyPow
{
    public double MyPow(double x, int n)
    {
        double power = n;
        double result = 1;

        //Edge case if power is -ve
        if (power < 0)
        {
            x = 1 / x;
            power = -power;
        }

        while (power > 0)
        {
            if (power % 2 == 1)
            {
                power = power - 1;
                result = result * x;
            }
            else //if power is even
            {
                power = power / 2;
                x = x * x;
            }
        }
        return result;
    }
}