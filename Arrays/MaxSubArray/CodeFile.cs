using System;

public class SolutionMaxSubArray
{
    public int MaxSubArray(int[] nums)
    {
        //Used KADANE's Algo to solve it
        //at every step Maitaining currentbest and overall best
        int currentBest = nums[0];
        int overAllBest = nums[0];
        for (int i = 1; i <= nums.Length - 1; i++)
        {
            //IF currentBest(or Sum of the items till now is less than 0, then we have to reset currentBest to current item in the loop)
            if (currentBest < 0)
            {
                currentBest = nums[i];
            }
            //Else maintainin sum of the items till now
            else
            {
                currentBest = currentBest + nums[i];
            }

            //IF currentBest(SUM of the value till now is greater than overAllBest then update overall best)
            if (currentBest > overAllBest)
            {
                overAllBest = currentBest;
            }


        }
        return overAllBest;
    }

    public static int MaxSubArray1(int[] nums)
    {
        int sum = 0;
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
            max = Math.Max(max, sum);
            if (sum < 0)
            {
                sum = 0;
            }
        }
        return max;
    }

}