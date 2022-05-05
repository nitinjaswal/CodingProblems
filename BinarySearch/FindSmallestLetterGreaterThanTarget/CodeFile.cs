public class SolutionNextGreatestLetter
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int low = 0;
        int high = letters.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (letters[mid] <= target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        if (low == letters.Length)
        {
            return letters[0];
        }
        else
        {
            return letters[low];
        }
    }
}