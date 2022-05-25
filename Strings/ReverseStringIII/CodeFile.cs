public class SolutionReverseStringII
{
    public static void reverseWords(char[] str)
    {
        // reverse the whole input 
        Reverse(str, 0, str.Length - 1);
        int start = 0;

        //Reverse each individual word
        for (int i = 0; i <= str.Length - 1; i++)
        {
            //when whitespace is encountered, means we have found one string(and pass its indices to reverse)
            if (str[i] == ' ')
            {
                Reverse(str, start, i - 1);
                start = i + 1;
            }
            // if i reaches to last word in string
            if (i == str.Length - 1)
            {
                Reverse(str, start, i);
            }
        }
    }

    //Method to reverse string
    private static void Reverse(char[] res, int start, int end)
    {
        while (start < end)
        {
            char temp = res[start];
            res[start] = res[end];
            res[end] = temp;
            start++;
            end--;
        }
    }
}
