using System.Collections;
namespace WEEK10;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events = new List<Event>();

    public void Add(Event eventt)
    {
        _events.Add(eventt);
    }

    public IEnumerator<Event> GetEnumerator()
    {
        for (int i = 0; i < _events.Count; i++)
        {
            yield return _events[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Event> GetByType(string type)
    {
        for (int i = 0; i < _events.Count; i++)
        {
            if (_events[i].Type == type)
            {
                yield return _events[i];
            }
        }
    }

    public IEnumerable<Event> GetLastEvents(int count)
    {
        int first = _events.Count - count;
        if (first < 0)
        {
            first = 0;
        }

        for (int i = first; i < _events.Count; i++)
        {
            yield return _events[i];
        }
    }
}