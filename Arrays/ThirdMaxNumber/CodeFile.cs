using System;
using System.Collections;

public class SolutionThirdMax
{
    public int ThirdMax(int[] arr)
    {
        int maxCounter = 0;
        Array.Sort(arr);
        int max = 0;
        Hashtable hashtable = new Hashtable();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (!hashtable.ContainsValue(arr[i]))
            {
                hashtable.Add(arr[i], arr[i]);
                maxCounter++;
                if (maxCounter == 3)
                {
                    max = arr[i];
                    break;
                }
            }
        }

        return maxCounter != 3 ? arr[arr.Length - 1] : max;
    }
}