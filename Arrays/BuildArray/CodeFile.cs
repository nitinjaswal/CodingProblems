public class SolutionBuildArray
{
    public int[] BuildArray(int[] nums)
    {
        int[] newArray = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            newArray[i] = nums[nums[i]];
        }

        return newArray;
    }
}