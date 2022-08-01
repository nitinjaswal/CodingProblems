public class SolutionMissingNumber
{
    public int MissingNumber(int[] arr)
    {
        //Cyclic sort
        for (int i = 0; i < arr.Length;)
        {
            //if element in array ie equal to length of array then skip it
            if (arr[i] == arr.Length)
            {
                i++;
                continue;
            }
            //Element correct index
            int correctIndex = arr[i];
            if (arr[i] != arr[correctIndex])
            {
                int temp = arr[i];
                arr[i] = arr[correctIndex];
                arr[correctIndex] = temp;
            }
            else
            {
                i++;
            }
        }

        //Once each element is at correct position after cycic sort
        //then check for element at wrong position 
        int j = 0;
        for (; j < arr.Length;)
        {
            if (arr[j] != j)
            {
                return j;
            }
            else
            {
                j++;
            }
        }
        return j;
    }
}