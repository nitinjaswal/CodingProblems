using System.Collections;

public class RecursiveLinearSearch
{
    static ArrayList FindAllIndex(int[] arr, int target, int i, ArrayList list)
    {
        if (i == arr.Length)
        {
            return list;
        }
        if (arr[i] == target)
        {
            list.Add(i);
        }
        return FindAllIndex(arr, target, i + 1, list);
    }

    static int FindIndex(int[] arr, int target, int i)
    {
        if (i == arr.Length)
        {
            return -1;
        }
        if (arr[i] == target)
        {
            return i;
        }
        else
        {
            return FindIndex(arr, target, i + 1);
        }
    }
}
