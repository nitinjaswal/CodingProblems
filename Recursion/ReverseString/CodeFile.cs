//You must do this by modifying the input array in-place with O(1) extra memory.
public class RecusrsivelyReverseString
{
    public void ReverseString(char[] s)
    {
        ReverseHelper(s, 0, s.Length - 1);
    }

    private void ReverseHelper(char[] s, int leftPointer, int rightPointer)
    {
        if (leftPointer >= rightPointer)
        {
            return;
        }
        var temp = s[rightPointer];
        s[rightPointer] = s[leftPointer];
        s[leftPointer] = temp;
        leftPointer++;
        rightPointer--;
        ReverseHelper(s, leftPointer, rightPointer);
    }
}