/*
Task 9: Game Character System
Task: Create a partial class.
    1) Create a partial class Character in two separate files:
    2) One part contains fields character, name and level.
    3) The other contains a method ShowCharacterInfo().
    4) In Main(), create a Character object and call ShowCharacterInfo().
*/

partial class Character
{
    string? _characterName;
    string? _characterLevel;
    public string Name
    {
        get => _characterName!;
    }
    public string Level
    {
        get => _characterLevel!;
    }
    public Character(string characterName, string characterLevel)
    {
        _characterName = characterName;
        _characterLevel = characterLevel;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Character newCharacter = new Character(".NET", "10");
        newCharacter.ShowCharacterInfo();
    }
}
