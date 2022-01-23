using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Queue.ShortestDistance
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
}
