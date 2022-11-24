using System.Collections;

public class SolutionFindMaxConsecutiveOnes
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {

        int counter = 0;
        ArrayList window = new ArrayList();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                counter++;
                if (i == nums.Length - 1)
                {
                    window.Add(counter);
                }
            }
            else
            {
                window.Add(counter);
                counter = 0;
            }
        }

        int max = 0;

        foreach (int i in window)
        {
            if (i > max)
            {
                max = i;
            }
        }
        return max;
    }
}