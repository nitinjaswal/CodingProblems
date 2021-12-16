using System;
using System.Collections.Generic;

public class SolutionFindDisappearedNumbers
{
    public IList<int> FindDisappearedNumbers(int[] arr)
    {
        List<int> missingElements = new List<int>();
        int j = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            j = Math.Abs(arr[i]) - 1;
            arr[j] = Math.Abs(arr[j]) * -1;
        }
        for (j = 0; j <= arr.Length - 1; j++)
        {
            if (arr[j] > 0)
            {
                missingElements.Add(j + 1);
            }
        }
        return missingElements;
    }
}