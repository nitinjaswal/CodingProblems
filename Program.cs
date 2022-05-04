using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            int[] nums = { 1, 5, 10 };
            var index = FindClosestElements(nums, 1, 4);
        }

        public static IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;

            //Step 1:Calculate mid in sorted array
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    break;
                }
                if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            var result = new List<int>();

            
            if (mid >= 1)
            {
                low = mid - 1;
                high = mid;
            }
            else
            {
                low = mid;
                high = mid + 1;
            }
            //Step 2: now compare both sides of mid as in merge sorted array
            while (low >= 0 && high <= arr.Length - 1 && k > 0)
            {
                if (x - arr[low] <= arr[high] - x)
                {
                    result.Add(arr[low]);
                    low--;
                }
                else
                {
                    result.Add(arr[high]);
                    high++;
                }
                k--;
            }

            //adding pending element if any
            while (k > 0 && low >= 0)
            {
                result.Add(arr[low]);
                k--;
                low--;
            }

            while (k > 0 && high <= arr.Length - 1)
            {
                result.Add(arr[high]);
                k--;
                high++;
            }
            result.Sort();
            return result;
        }
    }
}








