using System.Collections.Generic;

public class BFSShortestPath
{
    public class Node
    {
        public int Value { get; set; }
        public Node[] Nodes { get; set; }

        public Node()
        {
            Nodes = new Node[0];
        }
    }

    public int BFS(Node root, Node target)
    {
        Queue<Node> queue = new Queue<Node>(); // store all nodes which are waiting to be processed
        int step = 0;// number of steps neeeded from root to current node
        queue.Enqueue(root);// Add root to the queue

        //BFS
        while (queue.Count!=0)
        {
            step = step + 1;
            // iterate the nodes which are already in the queue
            int queueSize = queue.Count;
            for (int i = 0; i < queueSize; i++)
            {
                //Get first node from the queue
                Node currentNode = queue.Peek();

                //Return step is currentNode is equal to the target
                if (currentNode.Equals(target))
                {
                    return step;
                }
                //Add connectedNodes of the current node in the queue
                foreach (var item in currentNode.Nodes)
                {
                    queue.Enqueue(item);
                }
                queue.Dequeue();
            }
        }
        return -1;

    }
}
