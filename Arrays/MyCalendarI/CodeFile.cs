using System.Collections.Generic;

public class MyCalendar
{
    Dictionary<int, int> calendar;
    public MyCalendar()
    {
        calendar = new Dictionary<int, int>();
    }

    public bool Book(int start, int end)
    {
        foreach (var e in calendar)
        {
            //it means events are overlapping 
            if (e.Key < end && start < e.Value)
            {
                return false;
            }
        }
        calendar.Add(start, end);
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */