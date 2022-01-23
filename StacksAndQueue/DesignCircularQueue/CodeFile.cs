public class MyCircularQueue
{

    int front = 0;
    int rear = -1;
    int[] a;
    int n;
    int length;
    public MyCircularQueue(int k)
    {

        this.n = k; //length of the queue(array)
        a = new int[n];
    }

    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }
        //calculate rear
        rear = (rear + 1) % a.Length;
        a[rear] = value;
        length++;
        return true;

    }

    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }
        //calculate rear
        front = (front + 1) % a.Length;
        length--;
        return true;

    }

    public int Front()
    {
        if (IsEmpty())
        {
            return -1;
        }
        else
        {
            return a[front];
        }
    }

    public int Rear()
    {
        if (IsEmpty())
        {
            return -1;
        }
        else
        {
            return a[rear];
        }
    }

    public bool IsEmpty()
    {
        if (length == 0)
        {
            return true;
        }
        return false;
    }

    public bool IsFull()
    {
        if (length == a.Length)
        {
            return true;
        }
        return false;
    }
}
