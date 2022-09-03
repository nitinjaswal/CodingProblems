public class SolutionGetConcatenation
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] newArray = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++)
        {
            newArray[i] = nums[i];
            newArray[i + nums.Length] = nums[i];
        }

        return newArray;
    }
}