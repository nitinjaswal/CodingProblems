using System.Collections.Generic;

public class SolutionTwoSum
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var output = new List<int>();
        int low = 0;
        int high = numbers.Length - 1;
        while (low < high)
        {
            int sum = numbers[low] + numbers[high];
            if (sum == target)
            {
                output.Add(low + 1);
                output.Add(high + 1);
                return output.ToArray();
            }
            else if (sum > target)
            {
                high--;
            }
            else
            {
                low++;
            }
        }
        return output.ToArray();
    }
}