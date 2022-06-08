using System.Collections.Generic;

public class SolutionFindDisappearedNumbersCyclicSort
{
    public IList<int> FindDisappearedNumbers(int[] arr)
    {
        //USING: CYCLIC SORT
        var missingNumbers = new List<int>();
        for (int i = 0; i <= arr.Length - 1;)
        {
            int correctIndex = arr[i] - 1;
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
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (arr[i] != i + 1)
            {
                missingNumbers.Add(i + 1);
            }
        }
        return missingNumbers;
    }
}