public class SolutionRemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {

        int p = 0;
        p = nums.Length - 1;
        int counter = 0;
        for (int i = 0; i <= p;)
        {
            if (i <= p)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[p];
                    nums[p] = val;
                    p--;
                }
                else
                {
                    i++;
                    counter++;
                }
            }
        }
        return counter;
    }
}