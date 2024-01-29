using Standard52CardDeck;

namespace TexasHoldEm;

class Player
{
    public string Name { get; set; }

    public int NumberOfChips { get; set; }

    public List<Card> Hand { get; set; }

    public Player(string name) {
        this.Name = name;
        this.Hand = new List<Card>();
        this.NumberOfChips = 0;
    }
}