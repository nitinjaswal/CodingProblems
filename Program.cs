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
            obj.AddAtHead(20);
            obj.AddAtHead(4);
            obj.AddAtHead(15);
            obj.AddAtHead(10);

            /*Create loop for testing */
            obj.head.nextNode.nextNode.nextNode.nextNode = obj.head;

            bool exist = HasCycle(obj.head);
        }

        public static bool HasCycle(Node head)
        {
            HashSet<Node> hashNode = new HashSet<Node>();
            while (head!= null)
            {
                if (hashNode.Contains(head))
                {
                    return true;
                }
                else
                {
                    hashNode.Add(head);
                }
                head = head.nextNode;
            }
            return false;
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





