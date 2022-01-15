
// Definition for a Node.
using System.Collections.Generic;

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}




public class SolutionCopyListWithRandomPointer
{
    Dictionary<Node, Node> map = new Dictionary<Node, Node>();
    public Node CopyRandomList(Node head)
    {
        // Hash map which contains node to node mapping of
        // original and clone linked list.
        if (head == null)
        {
            return head;
        }
        var originalNode = head;
        var copiedNode = new Node(head.val);
        map.Add(originalNode, copiedNode);
        // Traverse the original list and making a copy of that
        // in the clone linked list.
        while (originalNode != null)
        {
            //Copying value of orignialNode to copiedNode
            copiedNode.random = GetNode(originalNode.random);
            copiedNode.next = GetNode(originalNode.next);

            originalNode = originalNode.next;
            copiedNode = copiedNode.next;
        }
        return map[head];
    }

    private Node GetNode(Node node)
    {
        if (node != null)
        {
            if (map.ContainsKey(node))
            {
                return map[node];
            }
            else
            {
                var newNode = new Node(node.val);
                map.Add(node, newNode);
                return map[node];
            }
        }
        return null;
    }
}