public class SolutionFindDuplicateFloydDetection
{
    public int FindDuplicate(int[] nums)
    {
        int slow = nums[0];
        int fast = nums[0];

        do
        {
            slow = nums[slow];//slow pointer will move one step
            fast = nums[nums[fast]];//fast pointer will move 2 steps
        }
        while (slow != fast);//loop until slow and fast meet

        fast = nums[0];
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
}