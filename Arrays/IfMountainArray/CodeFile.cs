public class SolutionIsMountainArray
{
    public bool ValidMountainArray(int[] arr)
    {
        bool isMountain = false;
        if (arr.Length >= 3)
        {
            int i = 0;
            while (i < arr.Length - 1)
            {
                if (arr[i + 1] > arr[i])
                {
                    isMountain = true;
                    i++;
                }
                else
                {
                    break;
                }
            }

            
            if (i == arr.Length - 1)
            {
                isMountain = false;
            }

            if (isMountain)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        isMountain = true;
                    }
                    else
                    {
                        isMountain = false;
                        break;
                    }

                }
            }


        }
        return isMountain;
    }
}