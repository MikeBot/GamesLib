namespace TexasHoldEm;

class Player
{
    public string Name { get; set; }

    public Chip[] Chips { get; set; }

    public Player(string name, Chip[] initialChips) {
        this.Name = name;
        this.Chips = initialChips;
    }
}