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
    class MyHashSet
    {
        public static void Main(String[] args)
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(1); // return True
            myHashSet.Contains(3); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(2); // return True
            myHashSet.Remove(2);   // set = [1]
            myHashSet.Contains(2); // return False, (already removed)
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









