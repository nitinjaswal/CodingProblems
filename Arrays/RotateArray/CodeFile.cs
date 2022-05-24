public class SolutionRotateReverse
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        Reverse(nums, nums.Length - k, nums.Length - 1);
        Reverse(nums, 0, nums.Length - 1 - k);
        Reverse(nums, 0, nums.Length - 1);
    }
    private static void Reverse(int[] res, int start, int end)
    {
        while (start < end)
        {
            int temp = res[start];
            res[start] = res[end];
            res[end] = temp;
            start++;
            end--;
        }
    }
}