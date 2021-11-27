using System.Collections.Generic;

public class SolutionCheckIfDoubleExist
{
    public bool CheckIfExist(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int lookup = 0;
        for (int i = 0; i < arr.Length; i++)
        {

            if (dict.ContainsValue(arr[i] * 2) || (arr[i] % 2 == 0 ? dict.ContainsValue(arr[i] / 2) : false))
            {
                return true;
            }
            else
            {
                dict.Add(i, arr[i]);
            }
        }

        return false;
    }
}