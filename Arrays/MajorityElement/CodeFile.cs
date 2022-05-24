public class SolutionMajorityElement
{
    public int MajorityElement(int[] nums)
    {
        int res = nums[0];//Be default we are assuming that first element is the majority element
        int count = 1;//Default occurence is 1
        for (int i = 1; i < nums.Length; i++)
        {
            //if number is same then increment its occurence
            if (res == nums[i])
            {
                count++;
            }//if number is changed,then decrement the occurence of the number
            else
            {
                count--;
            }

            //if count is zero, means there is no majority element , then take new element as new majority element
            if (count == 0)
            {
                res = nums[i];
                count = 1;
            }
        }
        return res;
    }
}