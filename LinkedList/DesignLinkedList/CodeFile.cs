public class Node1
{
    public int value;
    public Node1 nextNode;

    public Node1(int value)
    {
        this.value = value;
        this.nextNode = null;
    }
}
public class MyLinkedList
{
    public Node1 head;
    public Node1 tail;
    public int length;
    public MyLinkedList()
    {

    }
    public int Get(int index)
    {

        if (index >= length || index < 0)
        {
            return -1;
        }
        else
        {
            var currentode = this.head;
            int counter = 0;
            while (counter != index)
            {
                currentode = currentode.nextNode;
                counter++;
            }
            return currentode.value;
        }

    }

    public void AddAtHead(int val)
    {
        Node1 newNode = new Node1(val);
        newNode.nextNode = this.head;
        this.head = newNode;
        length++;
    }

    public void AddAtTail(int val)
    {
        if (length == 0)
        {
            AddAtHead(val);
            return;
        }
        else
        {
            Node1 newNode = new Node1(val);
            var currentode = this.head;
            while (currentode.nextNode != null)
            {
                currentode = currentode.nextNode;
            }
            currentode.nextNode = newNode;
            newNode.nextNode = null;
        }
        length++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > length)
        {
            return;
        }
        //Insert before first node or Head node
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == length)
        {
            AddAtTail(val);
            return;
        }
        else //Insert at given position
        {
            Node1 newNode = new Node1(val);
            var currentode = this.head;
            //Here we are using for loop because we know at which position we have to stop to insert new node.
            for (int i = 0; i < index - 1; i++)
            {
                currentode = currentode.nextNode;
            }
            var temp = currentode.nextNode;
            currentode.nextNode = newNode;
            newNode.nextNode = temp;
            length++;
        }
    }

    public void DeleteAtIndex(int index)
    {
        var currentNode = this.head;
        var previousNode = this.head;
        if (index >= length || index < 0)
        {
            return;
        }
        //Delete first node or head node
        if (index == 0)
        {
            this.head = currentNode.nextNode;
        }
        else
        {
            //Delete a node from any given index
            for (int i = 0; i < index; i++)
            {
                previousNode = currentNode;
                currentNode = currentNode.nextNode;
            }
            previousNode.nextNode = currentNode.nextNode;
        }
        length--;
    }
}