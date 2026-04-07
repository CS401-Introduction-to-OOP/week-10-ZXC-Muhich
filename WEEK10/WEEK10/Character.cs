namespace WEEK10;

public class Character
{
    public string Name { get; set; }
    public string Clas { get; set; }
    public int Lvl { get; set; }
    public int HP { get; set; }
    public int Gold { get; set; }
    public string State { get; set; }

    public Character(string name, string clas, int lvl, int hp, int gold, string state)
    {
        Name = name;
        Clas = clas;
        Lvl = lvl;
        HP = hp;
        Gold = gold;
        State = state;
    }
    
}