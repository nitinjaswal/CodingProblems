public class SolutionRotateExtraArray
{
    public void Rotate(int[] nums, int k)
    {
        int size = nums.Length;
        int[] result = new int[size + 1];
        k = k % size;
        int i = 0;
        int j = nums.Length - k;
        while (i < k)
        {
            result[i] = nums[j];
            i++;
            j++;
        }
        int l = 0;
        while (i <= nums.Length - 1)
        {
            result[i] = nums[l];
            i++;
            l++;
        }

        for (int start = 0; start <= nums.Length - 1; start++)
        {
            nums[start] = result[start];
        }
    }
}