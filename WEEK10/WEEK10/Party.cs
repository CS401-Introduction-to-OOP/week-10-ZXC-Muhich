using System.Collections;

namespace WEEK10;

public class Party : IEnumerable<Character>
{
    private List<Character> _characters = new List<Character>();

    public void Add(Character character)
    {
        _characters.Add(character);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        for (int i = 0; i < _characters.Count; i++)
        {
            yield return _characters[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Character> GetActiveCharacters()
    {
        for (int i = 0; i < _characters.Count; i++)
        {
            if (_characters[i].State == "Active")
            {
                yield return _characters[i];
            }
        }
    }

    public IEnumerable<Character> GetCharactersWithLowHp()
    {
        for (int i = 0; i < _characters.Count; i++)
        {
            if (_characters[i].HP <= 4)
            {
                yield return _characters[i];
            }
        }
    }
}