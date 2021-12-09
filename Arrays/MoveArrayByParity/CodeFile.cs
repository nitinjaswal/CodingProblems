public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums;
        }

        int i = 0;//
        int temp = 0;
        for (int j = 0; j <= nums.Length - 1;)
        {
            if (nums[j] % 2 != 0)
            {
                j++;
            }
            else
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j++;
            }
        }
        return nums;
    }
}