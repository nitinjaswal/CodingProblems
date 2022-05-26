public class SolutionFloorCeil
{
    //return the index of smallest number >=target
    public  int FindCeil(int[] arr, int target)
    {
        //if target number is greater than the greatest number in the array
        if(target>arr.Length-1)
        {
            return -1;
        }
        int low = 0;
        int high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return arr[mid];
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return low;
    }

    //Floor: greatest number smaller or equal to target
    public static int FindFloor(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return arr[mid];
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return high;
    }
}