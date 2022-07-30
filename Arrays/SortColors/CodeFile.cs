public class SolutionSortColorsDutchNationalFlagAlgo
{
    public void SortColors(int[] nums)
    {
        //Dutch national flag algo
        //We assume that al the lement to the low are 0 ie: a[0...low-1]==0
        //and all the element to right of high are 2 ie: a[high+1...]==2
        //and [low...mid-1} ie: 1
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;
        while (mid <= high)
        {
            if (nums[mid] == 0)//When mid is zero: Swap values at (nums[low] & nums[mid])
            {
                int temp = nums[low];
                nums[low] = nums[mid];
                nums[mid] = temp;
                low++;
                mid++;
            }
            else if (nums[mid] == 1)//if Mid is zero then simply increment Mid pointer
            {
                mid++;
            }
            else
            {
                int temp = nums[mid];
                nums[mid] = nums[high];
                nums[high] = temp;
                high--;
            }
        }


    }
}