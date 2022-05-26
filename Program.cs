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
        static ListNode listNode = null;
        public static void Main(String[] args)
        {

            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);

            int numberToFind = 6;
            int[,] array = new int[3, 3]
            {
                {1, 2, 3 },
                {4,5,6 },
                {7,8,9 }
            };
            int[] arr = new int[] { 2, 5, 6, 0, 0, 1, 2 };

            string[] str = { "flower", "flow", "flight" };
            string s = LongestCommonPrefix(str);

        }

        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int minDepth = 1;
            int currentDepth = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count();
                //looping all the item level order(which are present in queue)
                for (int i = 0; i < size; i++)
                {
                    var item = queue.Dequeue();
                    //as soon as leaf node is found we return the depth count as there is no need to traverse whole tree
                    if (item.left == null && item.right == null)
                    {
                        return minDepth;
                    }
                    if (item.left != null)
                    {
                        currentDepth++;
                        queue.Enqueue(item.left);

                    }
                    if (item.right != null)
                    {

                        queue.Enqueue(item.right);
                    }
                }
                minDepth++;
            }
            return minDepth;
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs, StringComparer.InvariantCulture);
            return "";
        }
        public static bool Search(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == arr[mid])
                {
                    return true;
                }
                //case 1: If array element at start is less than element at array mid
                if (arr[start] <= arr[mid])
                {
                    //Check if target element is in this range
                    if (target >= arr[start] && target <= arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (target >= arr[mid] && target <= arr[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return false;
        }
        public static int FindCeil(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return arr[mid];
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return low;
        }

        //Floor: greatest number smaller or equal to target
        public static int FindFloor(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return arr[mid];
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return high;
        }
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                // it means high element must be on left sidde of the mid
                if (arr[mid] > arr[mid + 1])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
        public static string ReverseWords(string s)
        {

            StringBuilder sb = new StringBuilder();
            var words = s.Split(' ');

            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i] != "")
                {
                    string reversedString = ReverseString(words[i].ToCharArray());
                    sb.Append(reversedString);
                    sb.Append(' ');
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static string ReverseString(char[] s)
        {
            int i = 0;
            for (int j = s.Length - 1; i < j; j--)
            {
                var temp = s[j];
                s[j] = s[i];
                s[i] = temp;
                i++;
            }
            string str = new string(s);
            return str.ToString();
        }
    }

}









