//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace Challenges
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyLinkedList obj = new MyLinkedList();
//            obj.AddAtHead(1);
//            obj.AddAtHead(4);
//            //obj.AddAtHead(15);
//            //obj.AddAtHead(10);

//            /*Create loop for testing */
//            //obj.head.nextNode.nextNode.nextNode.nextNode = obj.head;

//            bool exist = HasCycle(obj.head);
//        }

//        public bool HasCycle(ListNode head)
//        {
//            //Solvin the problem with 2 pointer approach using slow and fast pointer
//            var slowPointer = head;
//            var fastPointer = head;

//            //If first node is null or there is only head node, it means there is no cyc
//            while (fastPointer != null && fastPointer.next != null)
//            {
//                slowPointer = slowPointer.next;//slow pointer will move 1 step
//                fastPointer = fastPointer.next.next;//fast pointer will move 2 step ahead

//                if (slowPointer == fastPointer)///At some point "fastpointer" will cross "slowpointer"
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//    }

//    public class Node
//    {
//        public int value;
//        public Node nextNode;

//        public Node(int value)
//        {
//            this.value = value;
//            this.nextNode = null;
//        }
//    }
//    public class MyLinkedList
//    {
//        public Node head;
//        public Node tail;
//        public int length;
//        public MyLinkedList()
//        {

//        }
//        public void AddAtHead(int val)
//        {
//            Node newNode = new Node(val);
//            newNode.nextNode = this.head;
//            this.head = newNode;
//            length++;
//        }
//    }


//}





