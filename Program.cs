using System;

namespace Challenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class LinkedList
    {
        public static void Main(String[] args)
        {
            int result = 5;
            int[] arr = { 4, 6, 2, 5, 7, 9, 1, 3 };
            QuickSort(arr, 0, arr.Length - 1);

        }

        private static void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int start = low;
                int end = high;
                int pivot = nums[low];
                while (start < end)
                {
                    while (nums[start] <= pivot)//When start is less than pivot 
                    {
                        start++;
                    }
                    while (nums[end] > pivot)//When end is greater than pivot
                    {
                        end--;
                    }

                    if (start < end)
                    {
                        int temp = nums[start];
                        nums[start] = nums[end];
                        nums[end] = temp;
                    }
                }

                //place pivot at its right position

                int temp1 = nums[end];
                nums[end] = nums[low];
                nums[low] = temp1;

                pivot = end;
                QuickSort(nums, low, pivot - 1);
                QuickSort(nums, pivot + 1, high);
            }
        }

        public static int ClimbStairs(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            var r = ClimbStairs(n - 1) + ClimbStairs(n - 2);

            return r;
        }
        private static void Sort(int[] nums, int low, int high)//low and high is used to figure out what parts of array we are working on
        {

        }
    }

}








