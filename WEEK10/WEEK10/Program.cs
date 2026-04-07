using System;
using System.Linq;

namespace WEEK10;

public class Program
{
    public void Main()
    {
        Party party = new Party();
        EventLog eventLog = new EventLog();

        Character char1 = new Character("Arthas", "Monk",14, 33, 3, "Active");
        Character char2 = new Character("Muhich", "Cleric", 12, 2, 225, "Active");

        party.Add (char1);
        party.Add (char2);

        Event ev1 = new Event(1, "Goblins on the way","Battle", "-5HP");
        Event ev2 = new Event(2, "Some beer","Tavern", "+10HP");
        
        eventLog.Add (ev1);
        eventLog.Add (ev2);

        Console.WriteLine("All Chars:");
        foreach (Character character in party)
        {
            Console.WriteLine($"{character.Name} - {character.Clas}, {character.Lvl}, {character.HP}, {character.Gold} - {character.State}");
        }
        
        Console.WriteLine("Events Journal:");
        foreach (Event eventt in eventLog)
        {
            Console.WriteLine($"{eventt.TurnNumber}, {eventt.Description}, {eventt.Type} - {eventt.StatsChange}");
        }
        
        Console.WriteLine();
        Console.WriteLine("Characters with low HP:");
        foreach (Character character in party.GetCharactersWithLowHp())
        {
            Console.WriteLine(character.Name);
        }
        
    }
}