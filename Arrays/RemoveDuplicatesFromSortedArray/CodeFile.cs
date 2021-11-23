public class SolutionRemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int length = 0;
        int i = 0;
        if (nums.Length == 0)
        {
            return length;
        }

        for (int j = 1; j <= nums.Length - 1;)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }
            else
            {
                j++;
            }
            length = i;
        }
        return length + 1;
    }
}