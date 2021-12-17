public class SolutionSortedSquares
{
    public int[] SortedSquares(int[] arr)
    {
        //Taking 2 pointers:
        //i: to start from 0 imdex and j: to start from end
        //Comparing squared value of i&j and inserting greater value in new array(sortedArray)
        //By doing this we are taking extra space,but we are solving it in O(n) time

        int[] sorterArray = new int[arr.Length];
        int j = arr.Length - 1;
        int c = arr.Length - 1;

        for (int i = 0; i <= arr.Length - 1;)
        {
            //When J and I crosses
            if (j < i)
            {
                break;
            }

            int val1 = arr[i] * arr[i];
            int val2 = arr[j] * arr[j];

            if (val1 >= val2)
            {
                sorterArray[c] = val1;
                i++;
                c--;
            }
            else
            {
                sorterArray[c] = val2;
                j--;
                c--;
            }
        }
        return sorterArray;
    }
}