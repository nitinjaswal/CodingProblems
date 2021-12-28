using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList obj = new MyLinkedList();
            obj.AddAtHead(4);
            //obj.AddAtHead(0);
            //obj.AddAtHead(2);
            //obj.AddAtHead(3);

            /*Create loop for testing */
            obj.head.nextNode = null;

            var nodr = HasCycle(obj.head);
        }

        public static Node HasCycle(Node head)
        {
            //Solvin the problem with 2 pointer approach using slow and fast pointer
            var slowPointer = head;
            var fastPointer = head;
            //If first node is null or there is only head node, it means there is no cyc
            while (fastPointer != null && fastPointer.nextNode != null)
            {
                slowPointer = slowPointer.nextNode;//slow pointer will move 1 step
                fastPointer = fastPointer.nextNode.nextNode;//fast pointer will move 2 step ahead

                if (slowPointer == fastPointer)///At some point "fastpointer" will cross "slowpointer"
                {
                    break;
                }
            }

            if (slowPointer != fastPointer)
            {
                return null;
            }

            if (head.nextNode == null)
            {
                return null;
            }
            slowPointer = head;
            while (slowPointer != fastPointer)
            {
                slowPointer = slowPointer.nextNode;//slow pointer will move 1 step
                fastPointer = fastPointer.nextNode;//fast pointer will move 1 step ahead
            }
            
            return slowPointer;
        }
    }

    public class Node
    {
        public int value;
        public Node nextNode;

        public Node(int value)
        {
            this.value = value;
            this.nextNode = null;
        }
    }
    public class MyLinkedList
    {
        public Node head;
        public Node tail;
        public int length;
        public MyLinkedList()
        {

        }
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            newNode.nextNode = this.head;
            this.head = newNode;
            length++;
        }
    }


}





