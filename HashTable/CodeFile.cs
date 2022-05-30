using System.Collections.Generic;

public class MyHashSet
{
    List<int> set = new List<int>();
    public MyHashSet()
    {

    }

    public void Add(int key)
    {
        if (!set.Contains(key))
        {
            set.Add(key);
        }
    }

    public void Remove(int key)
    {
        if (set.Contains(key))
        {
            set.Remove(key);
        }
    }

    public bool Contains(int key)
    {
        if (set.Contains(key))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}