using System.Collections.Generic;
using System.Linq;

public class SolutionIntersectionUsingExtraSpace
{
    public IList<int> Intersection(int[][] nums)
    {
        int row = nums.Length;
        int col = nums[0].Length;

        Dictionary<int, int> set = new Dictionary<int, int>();

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                if (!set.ContainsKey(nums[i][j]))
                {
                    set.Add(nums[i][j], 1);
                }
                else
                {
                    set[nums[i][j]]++;
                }
            }
        }
        var result = set.Where(x => x.Value == nums.Length).Select(x => x.Key).OrderBy(x => x);
        return result.ToList();
    }
}