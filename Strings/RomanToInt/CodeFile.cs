using System.Collections.Generic;

public class SolutionRomanToInt
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> set = new Dictionary<char, int>();
        set.Add('I', 1);
        set.Add('V', 5);
        set.Add('X', 10);
        set.Add('L', 50);
        set.Add('C', 100);
        set.Add('D', 500);
        set.Add('M', 1000);

        int number = 0;
        var arr = s.ToCharArray();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (set[arr[i]] < set[arr[i + 1]])
            {
                number = number - set[arr[i]];
            }
            else
            {
                number = number + set[arr[i]];
            }
        }
        return number + set[arr[arr.Length - 1]];
    }
}