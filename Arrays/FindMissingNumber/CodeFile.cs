using System.Linq;

public class SolutionMissingNumberMathematics
{
    public int MissingNumber(int[] arr)
    {
        //we know sum of n conseutive numbers  is (n * (n+1))/2.

        //STEP1: Find sum of n CONSECUTIVE numbers
        int n = arr.Length;
        int sum = (n * (n + 1)) / 2;

        //STEP2: Find sum of all the elements in array
        int arraySum = arr.Sum();

        //Return the difference adnd we will get missing number
        return sum - arraySum;
    }
}