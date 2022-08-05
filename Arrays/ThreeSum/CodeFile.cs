using System;
using System.Collections.Generic;

public class SolutionThreeSum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {

        List<IList<int>> result = new List<IList<int>>();

        if (nums.Length == 0)
        {
            return result;
        }
        Array.Sort(nums);

        //loop till len-2 becasue for triplet we need 3 elements
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                //look for element ie: x+y+z=0; means y+z=-x: like a 2 sum problem
                int sum = nums[j] + nums[k];
                if (sum == -nums[i])
                {
                    //check if not duplicate, then add in
                    List<int> newTriplet = new List<int>() { nums[i], nums[j], nums[k] };
                    if (!result.Any(triple =>
                            triple[0] == newTriplet[0] &&
                            triple[1] == newTriplet[1] &&
                            triple[2] == newTriplet[2]))
                    {
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });

                    }
                    j++;
                    k--;
                }
                else if (sum < -nums[i])
                {
                    j++;
                }
                else if (sum > -nums[i])
                {
                    k--;
                }
            }
        }

        return result;
    }
}