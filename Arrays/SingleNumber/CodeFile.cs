public class SolutionSingleNumber
{
    public static int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
        {
            result = result ^ num;
        }
        return result;
    }
}
