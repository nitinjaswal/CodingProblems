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
    


    public class MyHashSet
    {
    
        

     
        public static void Main(String[] args)
        {
            int i = 0;
            //testmethod(out i);
           
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(1); // return True
            myHashSet.Contains(3); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(2); // return True
            myHashSet.Remove(2);   // set = [1]
            myHashSet.Contains(2); // return False, (already removed)
            string[] str = { "flow", "flower", "flight","cir" };
            string longest = LongestCommonPrefix(str);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            char[] first = strs[0].ToCharArray();
            char[] last = strs[strs.Length - 1].ToCharArray();
            StringBuilder longestCommonPrefix = new StringBuilder();
            for (int i = 0; i < first.Length; i++)
            {
                if(first[i]!=last[i])
                {
                    break;
                }
                else
                {
                    longestCommonPrefix.Append(first[i]);

                }
            }
            return longestCommonPrefix.ToString();
        }
        List<int> set = new List<int>();
        private int[] hashSet;
        public MyHashSet()
        {
            hashSet = new int[100000];

        }

        public void Add(int key)
        {
            hashSet[key] = key;
        }

        public void Remove(int key)
        {
            hashSet[key] = -1;
        }

        public bool Contains(int key)
        {
            if (hashSet[key] != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}









